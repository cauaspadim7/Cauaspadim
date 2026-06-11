-- ============================================================================
-- Script para CORRIGIR DEFINITIVAMENTE a coluna 'TipoRegra' na tabela Alunos
-- ============================================================================
-- Este script garante que:
-- 1. A coluna TipoRegra existe e é do tipo INT
-- 2. A coluna NÃO aceita NULL
-- 3. Tem um DEFAULT VALUE de 0 (TipoRegra.Usuario)
-- 4. Todos os valores NULL existentes são atualizados para 0
-- ============================================================================

USE [Aluno];

PRINT '=== INICIANDO CORRECAO DA COLUNA TipoRegra ===';

-- ============================================================================
-- ETAPA 1: Verificar estado atual
-- ============================================================================
PRINT '';
PRINT '--- ETAPA 1: Verificando estado atual ---';

SELECT 
    COLUMN_NAME,
    DATA_TYPE,
    IS_NULLABLE,
    COLUMN_DEFAULT
FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'Alunos' AND COLUMN_NAME = 'TipoRegra'
ORDER BY ORDINAL_POSITION;

-- ============================================================================
-- ETAPA 2: Remover constraint DEFAULT existente (se houver)
-- ============================================================================
PRINT '';
PRINT '--- ETAPA 2: Removendo constraints existentes ---';

DECLARE @ConstraintName NVARCHAR(255);

-- Procurar constraint DEFAULT
SELECT @ConstraintName = CONSTRAINT_NAME 
FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS 
WHERE TABLE_NAME = 'Alunos' 
  AND CONSTRAINT_TYPE = 'DEFAULT' 
  AND CONSTRAINT_NAME LIKE '%TipoRegra%';

-- Se encontrou, remover
IF @ConstraintName IS NOT NULL
BEGIN
    DECLARE @SQL NVARCHAR(MAX) = 'ALTER TABLE [dbo].[Alunos] DROP CONSTRAINT ' + QUOTENAME(@ConstraintName);
    EXEC sp_executesql @SQL;
    PRINT 'Constraint removido: ' + @ConstraintName;
END
ELSE
BEGIN
    PRINT 'Nenhum constraint DEFAULT encontrado para remover.';
END

-- ============================================================================
-- ETAPA 3: Atualizar todos os valores NULL para 0
-- ============================================================================
PRINT '';
PRINT '--- ETAPA 3: Atualizando valores NULL para 0 ---';

UPDATE [dbo].[Alunos] 
SET [TipoRegra] = 0 
WHERE [TipoRegra] IS NULL;

PRINT 'Valores NULL atualizados para 0: ' + CAST(@@ROWCOUNT AS VARCHAR(10)) + ' registros afetados.';

-- ============================================================================
-- ETAPA 4: Modificar coluna para NOT NULL (se necessário)
-- ============================================================================
PRINT '';
PRINT '--- ETAPA 4: Configurando coluna como NOT NULL ---';

DECLARE @IsNullable NVARCHAR(3);
SELECT @IsNullable = IS_NULLABLE
FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'Alunos' AND COLUMN_NAME = 'TipoRegra';

IF @IsNullable = 'YES'
BEGIN
    ALTER TABLE [dbo].[Alunos] 
    ALTER COLUMN [TipoRegra] INT NOT NULL;
    PRINT 'Coluna TipoRegra alterada para NOT NULL.';
END
ELSE
BEGIN
    PRINT 'Coluna TipoRegra já é NOT NULL.';
END

-- ============================================================================
-- ETAPA 5: Adicionar constraint DEFAULT
-- ============================================================================
PRINT '';
PRINT '--- ETAPA 5: Adicionando constraint DEFAULT ---';

BEGIN TRY
    ALTER TABLE [dbo].[Alunos] 
    ADD CONSTRAINT DF_Alunos_TipoRegra_New DEFAULT (0) FOR [TipoRegra];
    PRINT 'Constraint DEFAULT adicionado com sucesso!';
END TRY
BEGIN CATCH
    PRINT 'Erro ao adicionar constraint: ' + ERROR_MESSAGE();
END CATCH

-- ============================================================================
-- ETAPA 6: Verificar resultado final
-- ============================================================================
PRINT '';
PRINT '--- ETAPA 6: Verificando resultado final ---';

SELECT 
    COLUMN_NAME,
    DATA_TYPE,
    IS_NULLABLE,
    COLUMN_DEFAULT
FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'Alunos' AND COLUMN_NAME = 'TipoRegra';

-- Verificar dados
PRINT '';
SELECT 
    'Total de registros' AS Descricao, COUNT(*) AS Valor 
FROM [dbo].[Alunos]
UNION ALL
SELECT 
    'Registros com TipoRegra = 0', COUNT(*) 
FROM [dbo].[Alunos] WHERE [TipoRegra] = 0
UNION ALL
SELECT 
    'Registros com TipoRegra = NULL', COUNT(*) 
FROM [dbo].[Alunos] WHERE [TipoRegra] IS NULL
UNION ALL
SELECT 
    'Registros com TipoRegra = 1', COUNT(*) 
FROM [dbo].[Alunos] WHERE [TipoRegra] = 1;

PRINT '';
PRINT '=== CORRECAO CONCLUIDA ===';

