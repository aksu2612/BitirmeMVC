-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 03 Mar 2017, 14:01:53
-- Sunucu sürümü: 5.7.14
-- PHP Sürümü: 5.6.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `suapii`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `login`
--

CREATE TABLE `login` (
  `ID` int(11) NOT NULL,
  `Ad` varchar(20) NOT NULL,
  `Soyad` varchar(20) NOT NULL,
  `Adres` varchar(150) NOT NULL,
  `Telefon` bigint(20) NOT NULL,
  `email` varchar(255) NOT NULL,
  `sifre` varchar(255) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Tablo döküm verisi `login`
--

INSERT INTO `login` (`ID`, `Ad`, `Soyad`, `Adres`, `Telefon`, `email`, `sifre`) VALUES
(1, 'Ismail', 'Aksu', 'sürsürü mah.', 5312972006, 'a', '1');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `lokasyon`
--

CREATE TABLE `lokasyon` (
  `ID` int(11) NOT NULL,
  `X_koordinat` float NOT NULL,
  `Y_koordinat` float NOT NULL,
  `urun_id` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `siparis`
--

CREATE TABLE `siparis` (
  `ID` int(11) NOT NULL,
  `alis_tarihi` date NOT NULL,
  `teslim_tarihi` date NOT NULL,
  `adet` int(11) NOT NULL,
  `urunID` int(11) NOT NULL,
  `kullaniciID` int(11) NOT NULL,
  `adres` varchar(255) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `urunler`
--

CREATE TABLE `urunler` (
  `ID` int(11) NOT NULL,
  `u_t` date NOT NULL,
  `s_k_t` date NOT NULL,
  `boyut` float NOT NULL,
  `fiyat` float NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Tablo döküm verisi `urunler`
--

INSERT INTO `urunler` (`ID`, `u_t`, `s_k_t`, `boyut`, `fiyat`) VALUES
(1, '2017-02-26', '2017-04-26', 3.5, 4),
(2, '2017-02-27', '2017-03-28', 0.5, 0.3);

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`ID`);

--
-- Tablo için indeksler `lokasyon`
--
ALTER TABLE `lokasyon`
  ADD PRIMARY KEY (`ID`);

--
-- Tablo için indeksler `siparis`
--
ALTER TABLE `siparis`
  ADD PRIMARY KEY (`ID`);

--
-- Tablo için indeksler `urunler`
--
ALTER TABLE `urunler`
  ADD PRIMARY KEY (`ID`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `login`
--
ALTER TABLE `login`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- Tablo için AUTO_INCREMENT değeri `lokasyon`
--
ALTER TABLE `lokasyon`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;
--
-- Tablo için AUTO_INCREMENT değeri `siparis`
--
ALTER TABLE `siparis`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;
--
-- Tablo için AUTO_INCREMENT değeri `urunler`
--
ALTER TABLE `urunler`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
