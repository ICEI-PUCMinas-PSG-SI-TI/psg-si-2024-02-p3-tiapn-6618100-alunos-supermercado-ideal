O banco de dados foi hospedado no Host: sql10.freesqldatabase.com
Database name: sql10751637
Database user: sql10751637
Port number: 3306

O desenho DER está no documento do trabalho e o código usado para criação e inserção de dados no Banco segue abaixo:

-- Criando o banco de dados
CREATE DATABASE SistemaDeGestao;
USE SistemaDeGestao;

-- Tabela Produto
CREATE TABLE Produto (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(100) NOT NULL,
    Descricao TEXT,
    Preco DECIMAL(10, 2) NOT NULL,
    Quant_Atual INT NOT NULL
);

-- Tabela Fornecedor
CREATE TABLE Fornecedor (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(100) NOT NULL,
    Email VARCHAR(100),
    Telefone VARCHAR(15)
);

-- Tabela Compra
CREATE TABLE Compra (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    Data DATE NOT NULL,
    Quantidade INT NOT NULL,
    Valor_UN DECIMAL(10, 2) NOT NULL,
    FornecedorID INT,
    FOREIGN KEY (FornecedorID) REFERENCES Fornecedor(ID)
);

-- Tabela Cliente
CREATE TABLE Cliente (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(100) NOT NULL,
    Email VARCHAR(100),
    Telefone VARCHAR(15)
);

-- Tabela Usuario
CREATE TABLE Usuario (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(100) NOT NULL,
    Email VARCHAR(100),
    Telefone VARCHAR(15)
);

-- Tabela Venda
CREATE TABLE Venda (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    Data DATE NOT NULL,
    Valor DECIMAL(10, 2) NOT NULL,
    ClienteID INT,
    FOREIGN KEY (ClienteID) REFERENCES Cliente(ID)
);

-- Tabela Item_Venda
CREATE TABLE Item_Venda (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    VendaID INT,
    ProdutoID INT,
    Quantidade INT NOT NULL,
    Preco DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (VendaID) REFERENCES Venda(ID),
    FOREIGN KEY (ProdutoID) REFERENCES Produto(ID)
);

-- Tabela Pagamento
CREATE TABLE Pagamento (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    VendaID INT,
    Data DATE NOT NULL,
    Valor DECIMAL(10, 2) NOT NULL,
    Metodo VARCHAR(50) NOT NULL,
    FOREIGN KEY (VendaID) REFERENCES Venda(ID)
);

-- Tabela que registra quem fez o registro (Compra ou Venda)
CREATE TABLE Registro (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    UsuarioID INT,
    TipoRegistro ENUM('Compra', 'Venda') NOT NULL,
    RegistroID INT NOT NULL,
    FOREIGN KEY (UsuarioID) REFERENCES Usuario(ID)
);

-- Inserindo dados fictícios

-- Produtos
INSERT INTO Produto (Nome, Descricao, Preco, Quant_Atual) VALUES
('Arroz', 'Pacote de 5kg de arroz branco', 20.00, 50),
('Feijão', 'Pacote de 1kg de feijão carioca', 8.50, 100),
('Macarrão', 'Pacote de 500g de macarrão espaguete', 4.75, 200);

-- Fornecedores
INSERT INTO Fornecedor (Nome, Email, Telefone) VALUES
('Fornecedor Alimentos Ltda', 'contato@fornecedor.com', '11987654321'),
('Distribuidora Brasil', 'vendas@distribuidorabrasil.com', '21987654321');

-- Compras
INSERT INTO Compra (Data, Quantidade, Valor_UN, FornecedorID) VALUES
('2024-12-01', 20, 19.00, 1),
('2024-12-02', 50, 7.50, 2);

-- Clientes
INSERT INTO Cliente (Nome, Email, Telefone) VALUES
('João Silva', 'joao.silva@gmail.com', '31987654321'),
('Maria Oliveira', 'maria.oliveira@gmail.com', '21976543210');

-- Usuários
INSERT INTO Usuario (Nome, Email, Telefone) VALUES
('Admin', 'admin@sistemagestao.com', '11999999999'),
('Operador', 'operador@sistemagestao.com', '21988888888');

-- Vendas
INSERT INTO Venda (Data, Valor, ClienteID) VALUES
('2024-12-05', 40.00, 1),
('2024-12-06', 17.00, 2);

-- Itens de Venda
INSERT INTO Item_Venda (VendaID, ProdutoID, Quantidade, Preco) VALUES
(1, 1, 2, 20.00),
(1, 3, 1, 4.75),
(2, 2, 2, 8.50);

-- Pagamentos
INSERT INTO Pagamento (VendaID, Data, Valor, Metodo) VALUES
(1, '2024-12-05', 40.00, 'Cartão de Crédito'),
(2, '2024-12-06', 17.00, 'Dinheiro');

-- Registros
INSERT INTO Registro (UsuarioID, TipoRegistro, RegistroID) VALUES
(1, 'Compra', 1),
(1, 'Compra', 2),
(2, 'Venda', 1),
(2, 'Venda', 2);
