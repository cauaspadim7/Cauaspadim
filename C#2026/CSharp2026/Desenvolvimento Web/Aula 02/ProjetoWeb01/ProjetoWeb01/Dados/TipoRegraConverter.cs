using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoWeb01.Classes.Enumeracoes;

namespace ProjetoWeb01.Dados
{
    public class TipoRegraConverter : ValueConverter<TipoRegra, int>
    {
        public TipoRegraConverter()
            : base(
                v => (int)v,
                v => (TipoRegra)v,
                new ConverterMappingHints(size: 4))
        {
        }
    }
}
