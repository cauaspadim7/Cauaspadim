--OP READ - LER
/*

SELECT * FROM Contas;
GO
*/
/*
SELECT Id, Titular,Numero_da_conta,Sakdo FROM Contas
WHERE Saldo > 1000;
GO

SELECT * FROM Contas
WHERE TITULAR LIKE '%Maria%';
GO

SELECT * FROM Contas
WHERE Numero_da_conta = 1002
GO
-- Ordenadas por saldo do maior p/ menor
SELECT * FROM Contas
ORDER BY Saldo DESC
GO
*/
-- Contar quantas contas existem na tabela		
SELECT COUNT(*) AS Total_Contas FROM Contas

-- Ordenadas por saldo do maior p/ menor
SELECT * FROM Contas
ORDER BY Saldo DESC
GO

-- Soma todos Saldos das contas na tabela 
SELECT SUM(Saldo) AS SaldoTotal FROM Contas

--Média de saldo nas contas
SELECT AVG (Saldo) AS MediasSaldos FROM Contas
GO