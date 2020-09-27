-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 26-Set-2020 às 04:49
-- Versão do servidor: 10.4.13-MariaDB
-- versão do PHP: 7.4.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `dbuniversidade`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `ca_aluno`
--

CREATE TABLE `ca_aluno` (
  `ID` int(30) NOT NULL,
  `NOME` varchar(300) NOT NULL,
  `UF` varchar(2) NOT NULL,
  `MUNICIPIO` int(30) NOT NULL,
  `LOGRADOURO` varchar(300) NOT NULL,
  `NUMERO` int(10) NOT NULL,
  `CURSO` int(30) NOT NULL,
  `TURMA` int(30) NOT NULL,
  `STATUS` int(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `ca_aluno`
--

INSERT INTO `ca_aluno` (`ID`, `NOME`, `UF`, `MUNICIPIO`, `LOGRADOURO`, `NUMERO`, `CURSO`, `TURMA`, `STATUS`) VALUES
(1, 'Ana Paula Antunes Araujo', 'SC', 2, ' Rua Uruguai', 125, 3, 1, 2),
(2, 'Kaue Rodrigo Pacheco', 'SC', 8, ' Rua Uruguai', 452, 3, 3, 2),
(3, 'Micael Douglas Silva Santana', 'SC', 1, ' Rua Uruguai', 200, 3, 3, 2),
(4, 'Enzo Henrique da Rocha', 'SC', 7, ' Rua Uruguai', 1236, 2, 2, 2);

-- --------------------------------------------------------

--
-- Estrutura da tabela `ca_curso`
--

CREATE TABLE `ca_curso` (
  `ID` int(30) NOT NULL,
  `NOME` varchar(300) NOT NULL,
  `GRAU` varchar(40) NOT NULL,
  `COORDENADOR` varchar(300) NOT NULL,
  `CARGAHORARIA` int(11) NOT NULL,
  `POLO` varchar(300) NOT NULL,
  `STATUS` int(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `ca_curso`
--

INSERT INTO `ca_curso` (`ID`, `NOME`, `GRAU`, `COORDENADOR`, `CARGAHORARIA`, `POLO`, `STATUS`) VALUES
(1, 'Administração', 'Bacharel', 'Camila da Silva Schmitt', 3000, 'Itajaí | SC', 2),
(2, 'ComéComércio Exterior EADrcio Exterior EAD', 'Tecnólogo', 'Andre Graf de Almeida', 1600, 'Itajaí | SC', 2),
(3, 'Análise e Desenvolvimento de Sistemas - EaD', 'Tecnólogo', 'Camila da Silva Schmitt', 2000, 'Itajaí | SC', 2);

-- --------------------------------------------------------

--
-- Estrutura da tabela `ca_municipio`
--

CREATE TABLE `ca_municipio` (
  `ID` int(30) NOT NULL,
  `NOME` varchar(100) NOT NULL,
  `CODIGOIBGE` int(30) NOT NULL,
  `UF` varchar(2) NOT NULL,
  `STATUS` int(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `ca_municipio`
--

INSERT INTO `ca_municipio` (`ID`, `NOME`, `CODIGOIBGE`, `UF`, `STATUS`) VALUES
(1, 'Balneário Camboriú', 4202008, 'SC', 1),
(2, 'Itajaí', 4208203, 'SC', 2),
(3, 'Camboriú', 4203204, 'SC', 2),
(4, 'São Geraldo', 3161502, 'MG', 2),
(5, 'Assis Chateaubriand', 4102000, 'PR', 2),
(6, 'Juína', 5105150, 'MT', 2),
(7, 'Chapecó', 4204202, 'SC', 2),
(8, 'Brusque', 4202909, 'SC', 2);

-- --------------------------------------------------------

--
-- Estrutura da tabela `ca_professor`
--

CREATE TABLE `ca_professor` (
  `ID` int(30) NOT NULL,
  `NOME` varchar(300) NOT NULL,
  `FORMACAO` varchar(100) NOT NULL,
  `MUNICIPIO` int(30) NOT NULL,
  `LOGRADOURO` varchar(300) NOT NULL,
  `NUMERO` int(10) NOT NULL,
  `STATUS` int(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `ca_professor`
--

INSERT INTO `ca_professor` (`ID`, `NOME`, `FORMACAO`, `MUNICIPIO`, `LOGRADOURO`, `NUMERO`, `STATUS`) VALUES
(1, 'ALEX LUCIANO ROESLER RESE', 'Mestrado', 8, 'Rua Uruguai', 252, 2),
(2, 'LUCAS DEBATIN', 'Mestrado', 2, 'Rua Uruguai', 484, 2);

-- --------------------------------------------------------

--
-- Estrutura da tabela `ca_turmas`
--

CREATE TABLE `ca_turmas` (
  `ID` int(30) NOT NULL,
  `POLO` varchar(300) NOT NULL,
  `CURSO` int(30) NOT NULL,
  `PROFESSOR` int(30) NOT NULL,
  `STATUS` int(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `ca_turmas`
--

INSERT INTO `ca_turmas` (`ID`, `POLO`, `CURSO`, `PROFESSOR`, `STATUS`) VALUES
(1, 'Itajaí | SC', 3, 1, 2),
(2, 'Itajaí | SC', 2, 2, 2),
(3, 'Itajaí | SC', 3, 1, 2);

-- --------------------------------------------------------

--
-- Estrutura da tabela `status`
--

CREATE TABLE `status` (
  `ID` int(30) NOT NULL,
  `NOME` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `status`
--

INSERT INTO `status` (`ID`, `NOME`) VALUES
(1, 'Cancelado'),
(2, 'Ativo');

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `ca_aluno`
--
ALTER TABLE `ca_aluno`
  ADD PRIMARY KEY (`ID`);

--
-- Índices para tabela `ca_curso`
--
ALTER TABLE `ca_curso`
  ADD PRIMARY KEY (`ID`);

--
-- Índices para tabela `ca_municipio`
--
ALTER TABLE `ca_municipio`
  ADD PRIMARY KEY (`ID`);

--
-- Índices para tabela `ca_professor`
--
ALTER TABLE `ca_professor`
  ADD PRIMARY KEY (`ID`);

--
-- Índices para tabela `ca_turmas`
--
ALTER TABLE `ca_turmas`
  ADD PRIMARY KEY (`ID`);

--
-- Índices para tabela `status`
--
ALTER TABLE `status`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `ca_aluno`
--
ALTER TABLE `ca_aluno`
  MODIFY `ID` int(30) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de tabela `ca_curso`
--
ALTER TABLE `ca_curso`
  MODIFY `ID` int(30) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de tabela `ca_municipio`
--
ALTER TABLE `ca_municipio`
  MODIFY `ID` int(30) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT de tabela `ca_professor`
--
ALTER TABLE `ca_professor`
  MODIFY `ID` int(30) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de tabela `ca_turmas`
--
ALTER TABLE `ca_turmas`
  MODIFY `ID` int(30) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de tabela `status`
--
ALTER TABLE `status`
  MODIFY `ID` int(30) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
