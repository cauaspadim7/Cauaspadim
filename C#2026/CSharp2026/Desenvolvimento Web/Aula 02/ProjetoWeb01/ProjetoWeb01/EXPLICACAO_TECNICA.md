# 🔧 EXPLICAÇÃO TÉCNICA - Por que mudamos de HasDefaultValue() para HasDefaultValueSql()

## O Problema

```csharp
// ❌ ISTO DAVA ERRO:
entity.Property(e => e.Regra)
    .IsRequired()
    .HasDefaultValue(0)  // ← Erro aqui!
```

**Erro:**
```
System.InvalidOperationException: 'Default value '0' of type 'int' 
cannot be set on property 'Regra' of type 'ProjetoWeb01.Classes.Enumeracoes.TipoRegra'
```

---

## Por que Acontecia?

Entity Framework Core distingue entre:

### 1. **HasDefaultValue()** - Para CLR (C# em runtime)
```csharp
.HasDefaultValue(TipoRegra.Usuario)  // Espera TipoRegra, não int!
```
- Usado quando você quer um valor padrão na **aplicação C#**
- Aplicado quando criar um novo objeto em memória
- Tipo **DEVE** ser o mesmo da propriedade (TipoRegra, não int)

### 2. **HasDefaultValueSql()** - Para SQL Server (database)
```csharp
.HasDefaultValueSql("0")  // Valor literal SQL
```
- Usado quando você quer um valor padrão no **banco de dados**
- Aplicado quando INSERT é executado SEM especificar o valor
- Tipo é **string SQL**, não C#

---

## A Solução

```csharp
// ✅ CORRETO:
entity.Property(e => e.Regra)
    .IsRequired()
    .HasColumnName("TipoRegra")
    .HasDefaultValueSql("0")      // ← SQL DEFAULT
    .HasConversion<int>();        // ← Converter enum ↔ int
```

### Por que funciona?

1. **`.HasConversion<int>()`** - Diz ao EF que `TipoRegra` (enum) é armazenado como `int` (0, 1) no SQL
2. **`.HasDefaultValueSql("0")`** - Diz ao SQL Server: "Se não mandar valor, use 0"
3. **`.IsRequired()`** - Diz ao SQL: "Não aceita NULL"

---

## Fluxo de Execução

### Cenário 1: Novo Aluno no C#
```csharp
var aluno = new Aluno();  // Construtor executa
// Regra = TipoRegra.Usuario (0) ✅
```

### Cenário 2: INSERT no SQL Server (mesmo se C# mandar null)
```sql
INSERT INTO Alunos (Nome, RA, TipoRegra, ...) 
VALUES ('João', 123, NULL, ...)  -- Even if null...
```

**O que acontece:**
1. SQL vê `TipoRegra = NULL`
2. Constraint NOT NULL rejeita
3. ❌ ERRO

**Solução:**
- O **Interceptor** força C# a nunca mandar NULL
- Ou a coluna teria DEFAULT e aceitaria NULL (não é o caso)
- Ou migration criaria DEFAULT no banco

---

## Comparação: Outras Opções Testadas

### ❌ Opção 1: HasDefaultValue(0)
```csharp
.HasDefaultValue(0)
// Erro: tipo mismatch (int ≠ TipoRegra)
```

### ❌ Opção 2: HasDefaultValue(TipoRegra.Usuario)
```csharp
.HasDefaultValue(TipoRegra.Usuario)
// Erro: não suporta enums diretamente com HasDefaultValue
```

### ✅ Opção 3: HasDefaultValueSql("0")
```csharp
.HasDefaultValueSql("0")
// Funciona! SQL interpreta como int literal
```

### ✅ Opção 4: Aceitar NULL + NOT NULL Constraint
```csharp
.IsRequired()  // SQL: NOT NULL
// Mas isso causaria erro se C# mandasse NULL
// Por isso adicionar Interceptor
```

---

## Stack Completo de Proteção

```
┌─────────────────────────────────────────────┐
│ 1. C# Construtor (Aluno.cs)                 │
│    Regra = TipoRegra.Usuario                │
└─────────────────────────────────────────────┘
                    ↓
┌─────────────────────────────────────────────┐
│ 2. Service Layer (AlunoService.cs)          │
│    aluno.Regra = TipoRegra.Usuario          │
└─────────────────────────────────────────────┘
                    ↓
┌─────────────────────────────────────────────┐
│ 3. EF Core Interceptor (antes de SaveChanges) │
│    if (aluno.Regra == null)                 │
│       aluno.Regra = TipoRegra.Usuario       │
└─────────────────────────────────────────────┘
                    ↓
┌─────────────────────────────────────────────┐
│ 4. EF Core Configuration                     │
│    .HasConversion<int>()                    │
│    .HasDefaultValueSql("0")                 │
└─────────────────────────────────────────────┘
                    ↓
┌─────────────────────────────────────────────┐
│ 5. SQL Server                               │
│    Column: TipoRegra INT NOT NULL           │
│    DEFAULT: (0)                             │
│    Constraint: DF_Alunos_TipoRegra_New      │
└─────────────────────────────────────────────┘
```

---

## Resumo

| Método | Uso | Tipo | Status |
|--------|-----|------|--------|
| `HasDefaultValue()` | CLR default | C# type | ❌ Não funciona com enum |
| `HasDefaultValueSql()` | SQL default | String SQL | ✅ CORRETO |
| `HasConversion<T>()` | Tipo storage | Type mapping | ✅ Necessário |
| Interceptor | Última linha de defesa | C# logic | ✅ Extra segurança |
| Constraint NOT NULL | DB enforcement | SQL constraint | ✅ Força válido |

---

## Referências EF Core

- `HasDefaultValue()` - CLR default value: https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.metadata.builders.propertybuilder.hasdefaultvalue
- `HasDefaultValueSql()` - Database default value: https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.metadata.builders.relationalpropertybuilderextensions.hasdefaultvaluesql
- `HasConversion()` - Value converters: https://docs.microsoft.com/en-us/ef/core/modeling/value-converters
