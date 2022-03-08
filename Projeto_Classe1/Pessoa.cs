using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Classe1
{
    internal class Pessoa
    {
        string nome;
        int idade;


        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public void setIdade(int idade)
        { 
            this.idade = idade; 
        }

        public string getNome()
        {
            return nome;
        }

        public int getIdade()
        {
            return idade;
        }
    }
}
