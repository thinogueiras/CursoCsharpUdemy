using System;
using System.Collections.Generic;
using System.Text;

namespace Estrutura_de_Dados
{
    public class ExercicioVetorClasse
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int NumeroQuarto { get; set; }

        public override string ToString()
        {
            return $"{NumeroQuarto}: {Nome.ToUpper()}, {Email.ToLower()}";
        }
    }
}
