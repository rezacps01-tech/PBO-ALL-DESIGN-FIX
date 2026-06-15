-- AgroGrandong Database Schema
-- Database: agrograndong

-- Drop existing tables if exists
DROP TABLE IF EXISTS bookings CASCADE;
DROP TABLE IF EXISTS schedules CASCADE;
DROP TABLE IF EXISTS users CASCADE;
DROP TABLE IF EXISTS roles CASCADE;

-- Create roles table
CREATE TABLE roles (
    role_id SERIAL PRIMARY KEY,
    role_name VARCHAR(50) NOT NULL UNIQUE,
    description TEXT,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

-- Create users table
CREATE TABLE users (
    user_id SERIAL PRIMARY KEY,
    username VARCHAR(50) NOT NULL UNIQUE,
    password VARCHAR(255) NOT NULL,
    full_name VARCHAR(100) NOT NULL,
    phone VARCHAR(20),
    address TEXT,
    role_id INTEGER NOT NULL,
    is_active BOOLEAN DEFAULT TRUE,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (role_id) REFERENCES roles(role_id)
);

-- Create schedules table (Jadwal mesin giling)
CREATE TABLE schedules (
    schedule_id SERIAL PRIMARY KEY,
    location VARCHAR(200) NOT NULL,
    address TEXT NOT NULL,
    schedule_date DATE NOT NULL,
    start_time TIME NOT NULL,
    end_time TIME NOT NULL,
    capacity INTEGER NOT NULL, -- Jumlah maksimal konsumen yang bisa booking
    current_booking INTEGER DEFAULT 0, -- Jumlah booking saat ini
    price_per_kg DECIMAL(10,2) NOT NULL,
    status VARCHAR(20) DEFAULT 'available', -- available, full, cancelled, completed
    notes TEXT,
    created_by INTEGER NOT NULL,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (created_by) REFERENCES users(user_id)
);

-- Create bookings table (Booking konsumen)
CREATE TABLE bookings (
    booking_id SERIAL PRIMARY KEY,
    schedule_id INTEGER NOT NULL,
    user_id INTEGER NOT NULL, -- ID konsumen yang booking
    booking_date TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    estimated_weight DECIMAL(10,2) NOT NULL, -- Estimasi berat padi (kg)
    actual_weight DECIMAL(10,2), -- Berat aktual setelah giling
    total_price DECIMAL(10,2),
    status VARCHAR(20) DEFAULT 'pending', -- pending, confirmed, completed, cancelled
    notes TEXT,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (schedule_id) REFERENCES schedules(schedule_id),
    FOREIGN KEY (user_id) REFERENCES users(user_id)
);

-- Insert default roles
INSERT INTO roles (role_name, description) VALUES 
('Admin', 'Administrator - Pemilik grandong'),
('Konsumen', 'Konsumen - Pengguna yang memesan jasa giling');

-- Insert default admin user (password: admin123)
INSERT INTO users (username, password, full_name, phone, role_id) VALUES 
('admin', 'admin123', 'Administrator', '081234567890', 1);

-- Insert sample konsumen users (password: konsumen123)
INSERT INTO users (username, password, full_name, phone, address, role_id) VALUES 
('konsumen1', 'konsumen123', 'Budi Santoso', '081234567891', 'Desa Makmur RT 01/RW 02', 2),
('konsumen2', 'konsumen123', 'Siti Aminah', '081234567892', 'Desa Sejahtera RT 03/RW 01', 2);

-- Insert sample schedules
INSERT INTO schedules (location, address, schedule_date, start_time, end_time, capacity, price_per_kg, created_by, notes) VALUES 
('Desa Makmur', 'Lapangan Desa Makmur, RT 01/RW 01', CURRENT_DATE + INTERVAL '1 day', '08:00', '12:00', 10, 500, 1, 'Bawa karung sendiri'),
('Desa Sejahtera', 'Balai Desa Sejahtera', CURRENT_DATE + INTERVAL '2 days', '09:00', '13:00', 15, 500, 1, 'Tersedia layanan antar hasil'),
('Desa Subur', 'Pos Ronda Desa Subur', CURRENT_DATE + INTERVAL '3 days', '07:00', '11:00', 12, 500, 1, '');

-- Create indexes for better performance
CREATE INDEX idx_users_username ON users(username);
CREATE INDEX idx_users_role ON users(role_id);
CREATE INDEX idx_schedules_date ON schedules(schedule_date);
CREATE INDEX idx_schedules_status ON schedules(status);
CREATE INDEX idx_bookings_schedule ON bookings(schedule_id);
CREATE INDEX idx_bookings_user ON bookings(user_id);
CREATE INDEX idx_bookings_status ON bookings(status);

-- Create views for easier querying
CREATE VIEW v_bookings_detail AS
SELECT 
    b.booking_id,
    b.booking_date,
    b.estimated_weight,
    b.actual_weight,
    b.total_price,
    b.status AS booking_status,
    b.notes AS booking_notes,
    u.full_name AS konsumen_name,
    u.phone AS konsumen_phone,
    u.address AS konsumen_address,
    s.location,
    s.address AS schedule_address,
    s.schedule_date,
    s.start_time,
    s.end_time,
    s.price_per_kg
FROM bookings b
JOIN users u ON b.user_id = u.user_id
JOIN schedules s ON b.schedule_id = s.schedule_id;

CREATE VIEW v_schedules_summary AS
SELECT 
    s.schedule_id,
    s.location,
    s.address,
    s.schedule_date,
    s.start_time,
    s.end_time,
    s.capacity,
    s.current_booking,
    (s.capacity - s.current_booking) AS available_slots,
    s.price_per_kg,
    s.status,
    s.notes,
    u.full_name AS created_by_name
FROM schedules s
JOIN users u ON s.created_by = u.user_id;
