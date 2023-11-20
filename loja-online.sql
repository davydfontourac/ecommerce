-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 20/11/2023 às 21:44
-- Versão do servidor: 10.4.28-MariaDB
-- Versão do PHP: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `loja-online`
--

-- --------------------------------------------------------

--
-- Estrutura para tabela `usuarios`
--

CREATE TABLE `usuarios` (
  `cpf` bigint(11) NOT NULL,
  `nome` varchar(15) NOT NULL,
  `sobrenome` varchar(30) NOT NULL,
  `senha` varchar(20) NOT NULL,
  `email` varchar(30) NOT NULL,
  `genero` varchar(11) NOT NULL,
  `enderecoRua` varchar(40) NOT NULL,
  `cep` bigint(8) NOT NULL,
  `telefone` int(11) NOT NULL,
  `admin` tinyint(1) DEFAULT NULL,
  `enderecoNumero` int(11) NOT NULL,
  `enderecoComplemento` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `usuarios`
--

INSERT INTO `usuarios` (`cpf`, `nome`, `sobrenome`, `senha`, `email`, `genero`, `enderecoRua`, `cep`, `telefone`, `admin`, `enderecoNumero`, `enderecoComplemento`) VALUES
(123456, 'Mauricio', '', '123456', 'mauricio@senai.com', '', '', 0, 0, 0, 0, '');

--
-- Índices para tabelas despejadas
--

--
-- Índices de tabela `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`cpf`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
