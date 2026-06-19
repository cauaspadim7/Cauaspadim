using System;
using System.Collections.Generic;
using System.Text;

namespace AplicativoDesktop01.Classes.DTO
{
    internal class LoginResponseDTO
    {
        public  string Email { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;

        public string Nome { get; set; } = string.Empty;
        public int Regra { get; set; }
    }
}
