INFO IMPORTANTE: Devido a quantidade de arquivos exceder o limite de upload de arquivos
no GitHub, a pasta "packages" contendo o o pacote do MySQL foi deletada.
Será necessário instalar o pacote do NuGet de MySQL dentro do Visual Studio
novamente para que o algoritmo funcione corretamente.
___________________________________________

COPIE E COLE o conteúdo SQL abaixo*

-- Criação do banco de dados
CREATE DATABASE BancoDeDadosUsuarios;

USE BancoDeDadosUsuarios;

-- Criação da tabela usuarios
CREATE TABLE usuarios (
    Id INT AUTO_INCREMENT PRIMARY KEY,    -- Coluna para o ID único do usuário
    Nome VARCHAR(100),                    -- Coluna para o Nome do usuário
    Email VARCHAR(100),                   -- Coluna para o Email do usuário
);

SELECT * FROM Alunos;