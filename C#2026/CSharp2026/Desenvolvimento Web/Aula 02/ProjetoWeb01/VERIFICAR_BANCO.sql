-- Verificar a estrutura da tabela Alunos
USE [Aluno];

-- Informações das colunas
SELECT 
    COLUMN_NAME,
    DATA_TYPE,
    IS_NULLABLE,
    COLUMN_DEFAULT
FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'Alunos'
ORDER BY ORDINAL_POSITION;

-- Verificar constraints
SELECT 
    CONSTRAINT_NAME,
    CONSTRAINT_TYPE
FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS
WHERE TABLE_NAME = 'Alunos';

-- Verificar defaults
SELECT 
    OBJECT_NAME(d.parent_object_id) AS TableName,
    c.name AS ColumnName,
    d.name AS ConstraintName,
    d.definition AS DefaultValue
FROM sys.default_constraints d
JOIN sys.columns c ON d.parent_object_id = c.object_id AND d.parent_column_id = c.column_id
WHERE d.parent_object_id = OBJECT_ID('Alunos');

-- Contar registros
SELECT 'Total de alunos:' AS Info, COUNT(*) AS Quantidade FROM [dbo].[Alunos];
