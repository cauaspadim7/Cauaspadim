## 🎯 SOLUÇÃO FINAL - 3 PASSOS SIMPLES

### ✅ Passo 1: PARAR a aplicação
```
Visual Studio → Debug → Stop Debugging
ou pressione: Shift+F5
```

---

### ✅ Passo 2: EXECUTAR Script SQL
**MUITO IMPORTANTE!** Este é o passo que faltava!

1. Abra **SQL Server Management Studio**
2. Conecte em: `ECFP507D1319382\SQLEXPRESS02`
3. Selecione banco: `Aluno`
4. Nova Query: Ctrl+N
5. **Copie TUDO** do arquivo `FIX_REGRA_COLUMN.sql` (pasta raiz do projeto)
6. Cole no SSMS
7. Execute: F5

**Você deve ver no final:**
```
=== CORRECAO CONCLUIDA ===
```

❌ Se der erro, copie e mostre a mensagem.

---

### ✅ Passo 3: INICIAR a aplicação novamente
```
Visual Studio → F5
ou pressione: F5
```

Tente cadastrar um aluno e veja se funciona!

---

## 🔧 Código foi CORRIGIDO

- ✅ `AlunoContext.cs` - Agora usa `HasDefaultValueSql("0")` em vez de `HasDefaultValue(0)`
- ✅ Compila sem erros
- ✅ Pronto para usar

**A chave foi usar `HasDefaultValueSql()` para SQL server e não `HasDefaultValue()` para C#**
