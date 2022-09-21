-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 25 Jun 2022 pada 06.12
-- Versi server: 10.4.17-MariaDB
-- Versi PHP: 7.3.27

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_barak`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `makanan`
--

CREATE TABLE `makanan` (
  `id_makanan` varchar(50) NOT NULL,
  `nama_makanan` varchar(50) NOT NULL,
  `harga_makanan` int(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `makanan`
--

INSERT INTO `makanan` (`id_makanan`, `nama_makanan`, `harga_makanan`) VALUES
('001', 'AYAM RUJAK', 20000),
('002', 'AYAM KRIUK', 15000),
('003', 'TOGE', 50000),
('004', 'MAKANAN SAJA', 50000);

-- --------------------------------------------------------

--
-- Struktur dari tabel `minuman`
--

CREATE TABLE `minuman` (
  `id_minuman` varchar(50) NOT NULL,
  `nama_minuman` varchar(255) NOT NULL,
  `harga_minuman` int(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `minuman`
--

INSERT INTO `minuman` (`id_minuman`, `nama_minuman`, `harga_minuman`) VALUES
('001', 'POP ICE VANILA', 5000),
('002', 'JUS MELON', 10000),
('003', 'JERUK NIPISS', 11000),
('004', 'CAPPUCINO', 5000);

-- --------------------------------------------------------

--
-- Struktur dari tabel `transaksi`
--

CREATE TABLE `transaksi` (
  `id_transaksi` int(11) NOT NULL,
  `nama_menu` varchar(50) NOT NULL,
  `tanggal` date DEFAULT NULL,
  `jumlah` int(11) NOT NULL,
  `total_harga` int(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `transaksi`
--

INSERT INTO `transaksi` (`id_transaksi`, `nama_menu`, `tanggal`, `jumlah`, `total_harga`) VALUES
(1, 'AYAM KRIUK', '2022-06-22', 1, 15000),
(2, 'POP ICE VANILA', '2022-06-22', 1, 5000),
(3, 'AYAM RUJAK', '2022-06-22', 1, 20000),
(4, 'AYAM RUJAK', '2022-06-22', 1, 20000),
(5, 'TOGE', '2022-06-22', 1, 50000),
(6, 'AYAM RUJAK', '2022-06-25', 1, 20000);

-- --------------------------------------------------------

--
-- Struktur dari tabel `users`
--

CREATE TABLE `users` (
  `id` varchar(10) NOT NULL,
  `nama` varchar(30) NOT NULL,
  `password` varchar(30) NOT NULL,
  `level` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `users`
--

INSERT INTO `users` (`id`, `nama`, `password`, `level`) VALUES
('ADM001', 'Ahmad Rizki Akbar', 'ADMIN', 'ADMIN'),
('ADM002', 'KASIR', 'KASIR', 'KASIR'),
('haikal', 'Rafli Haikal', 'test', 'ADMIN'),
('riskimeji', 'Riski Meji', 'jelek123', 'ADMIN'),
('test', 'test', 'test', 'ADMIN');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `makanan`
--
ALTER TABLE `makanan`
  ADD PRIMARY KEY (`id_makanan`);

--
-- Indeks untuk tabel `minuman`
--
ALTER TABLE `minuman`
  ADD PRIMARY KEY (`id_minuman`);

--
-- Indeks untuk tabel `transaksi`
--
ALTER TABLE `transaksi`
  ADD PRIMARY KEY (`id_transaksi`);

--
-- Indeks untuk tabel `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `transaksi`
--
ALTER TABLE `transaksi`
  MODIFY `id_transaksi` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
