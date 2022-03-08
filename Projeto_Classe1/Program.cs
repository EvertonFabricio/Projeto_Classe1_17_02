using System;

namespace Projeto_Classe1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pessoa p1; //só criei o controlador da classe, da mesma forma que declara variavel. Ele que vai criar a pessoa
            //p1 = new Pessoa(); //criei a pessoa (instanciei o objeto). Nela eu posso colocar o nome e a idade, que estão na classe.

            //Pessoa p2 = new Pessoa(); //assim eu declarei o controlador p2 ja instanciando ele como um objeto.


            Pessoa p1 = new Pessoa();

            p1.setNome(Console.ReadLine());
            p1.setIdade(int.Parse(Console.ReadLine()));

            Console.WriteLine(p1.getNome());
            Console.WriteLine($"{p1.getIdade()} anos.");














        }
    }
}
