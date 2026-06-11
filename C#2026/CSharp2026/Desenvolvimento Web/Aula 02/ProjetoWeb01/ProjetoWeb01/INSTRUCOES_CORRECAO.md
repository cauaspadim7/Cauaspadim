## 🔧 INSTRUÇÕES PARA CORRIGIR O ERRO DE COLUNA 'Regra' NULL

### ⚠️ PASSO 1: Parar a aplicação (IMPORTANTE!)
1. No Visual Studio, clique em "Stop Debugging" (ou pressione Shift+F5)
2. Feche completamente a aplicação Blazor

---

### 📝 PASSO 2: Executar o script SQL

#### Opção A: Usar SQL Server Management Studio (RECOMENDADO)
1. Abra o **SQL Server Management Studio**
2. Conecte-se ao seu servidor: `ECFP507D1319382\SQLEXPRESS02`
3. Selecione o banco de dados `Aluno` 
4. Abra uma nova janela de Query (Ctrl+N)
5. Copie **TODO** o conteúdo do arquivo `FIX_REGRA_COLUMN.sql`
6. Cole no SQL Management Studio
7. **Execute o script completo** (F5)
8. Verifique que todas as etapas completaram **sem erros**

---

### 💻 PASSO 3: Recompilar e testar

1. No Visual Studio, execute um clean build:
   - Build → Clean Solution
   - Build → Rebuild Solution

2. Pressione **F5** para iniciar a aplicação

3. Tente cadastrar um aluno novamente

---

### 🛡️ PROTEÇÕES IMPLEMENTADAS

Foram adicionadas 5 camadas de proteção contra NULL:

1. **Aluno.cs** - Inicialização no construtor
2. **AlunoService.cs** - Validação antes de salvar
3. **AlunoSaveChangesInterceptor.cs** - Interceptor EF Core
4. **AlunoContext.cs** - Configuração Fluent
5. **SQL Server** - DEFAULT constraint + NOT NULL

---

### ✅ Resultado esperado:

- Coluna TipoRegra é INT NOT NULL
- Tem DEFAULT VALUE = 0
- Nenhum valor NULL existe na tabela
- Novos cadastros funcionam normalmente
