using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Classe1
{
    internal class Endereco
    {
        public string Localidade { get; set; }
        public string Logradouro { get; set; } 
        public int Numero { get; set; }

        public override string ToString()
        {
            return $"A cidade é {Localidade}.\nO endereço é: {Logradouro}, número {Numero}.";
        }

        public Endereco(string Localidade, String Logradouro, int Numero)
        {
            this.Localidade = Localidade;
            this.Logradouro = Logradouro;
            this.Numero = Numero;   



        }

    }
}
