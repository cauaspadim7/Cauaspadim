## 🚀 PRÓXIMOS PASSOS - EXECUTE AGORA!

### ⏱️ Tempo estimado: 5 minutos

---

## PASSO 1: Parar a Aplicação
```
Visual Studio → Debug → Stop Debugging (ou Shift+F5)
```

---

## PASSO 2: Executar Script SQL (CRÍTICO!)

### No SQL Server Management Studio:

1. **Abra** o SSMS
2. **Conecte** em: `ECFP507D1319382\SQLEXPRESS02`
3. **Selecione** banco: `Aluno`
4. **Ctrl+N** para nova Query
5. **Copie** TUDO de `FIX_REGRA_COLUMN.sql` (arquivo na raiz do projeto)
6. **Cole** na Query
7. **F5** para executar

### ✅ Resultado esperado:
```
=== INICIANDO CORRECAO DA COLUNA TipoRegra ===
--- ETAPA 1: Verificando estado atual ---
--- ETAPA 2: Removendo constraints existentes ---
--- ETAPA 3: Atualizando valores NULL para 0 ---
Valores NULL atualizados para 0: X registros afetados.
--- ETAPA 4: Configurando coluna como NOT NULL ---
Coluna TipoRegra alterada para NOT NULL.
--- ETAPA 5: Adicionando constraint DEFAULT ---
Constraint DEFAULT adicionado com sucesso!
--- ETAPA 6: Verificando resultado final ---
=== CORRECAO CONCLUIDA ===
```

❌ **Se houver erro:** Copie e compartilhe a mensagem de erro

---

## PASSO 3: Recompilar

```
Visual Studio → Build → Clean Solution
Visual Studio → Build → Rebuild Solution
```

✅ Deve compilar sem erros.

---

## PASSO 4: Testar

```
Visual Studio → F5 (Iniciar debug)
```

Na aplicação:
- Clique em "Novo usuário"
- Preencha:
  - Nome: "Teste Silva"
  - RA: 99999
  - Curso: (selecione qualquer um)
- Clique "Cadastrar"

✅ Deve aparecer: **"Aluno cadastrado com sucesso!"**

---

## 📊 Verificação Final (Opcional)

Execute no SSMS:
```sql
SELECT TOP 1 Id, Nome, RA, TipoRegra 
FROM [dbo].[Alunos] 
ORDER BY Id DESC;
```

Deve retornar um registro com `TipoRegra = 0` (e não NULL)

---

## ⚠️ Problema Persistindo?

Execute:
```sql
-- Verificar problema
SELECT 
    COLUMN_NAME, 
    DATA_TYPE, 
    IS_NULLABLE, 
    COLUMN_DEFAULT
FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'Alunos' AND COLUMN_NAME = 'TipoRegra';

-- Deve retornar:
-- TipoRegra, int, NO, ((0))
```

Se `IS_NULLABLE = YES`:
```sql
ALTER TABLE [dbo].[Alunos] 
ALTER COLUMN [TipoRegra] INT NOT NULL;
```

---

## 📞 Suporte Rápido

| Problema | Solução |
|----------|---------|
| Script SQL não rodou | Verifique se todos os comandos foram colados |
| Compilação com erro | Verifique se Visual Studio tem erros (Ctrl+Shift+B) |
| Ainda diz NULL | Execute o TESTE_RAPIDO.sql para diagnosticar |
| Tabela não tem coluna TipoRegra | Pode estar com outro nome, verifique no SSMS |

---

## ✅ Checklist Final

- [ ] Aplicação parada
- [ ] Script FIX_REGRA_COLUMN.sql executado com sucesso
- [ ] Visual Studio recompilado
- [ ] Aplicação iniciada
- [ ] Aluno cadastrado sem erro
- [ ] Verificação final confirmou TipoRegra = 0

🎉 **Se todos os itens estão marcados, o problema está RESOLVIDO!**
