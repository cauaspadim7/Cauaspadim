--Criação do Banco de Dados --
CREATE TABLE Contas(
Id INT IDENTITY(1,1) PRIMARY KEY,
Titular NVARCHAR(30) NOT NULL,
Numero_da_conta INT NOT NULL UNIQUE,
Saldo DECIMAl(10,2) NOT NULL,
);
GO