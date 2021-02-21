using System;

namespace List
{
    public class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno();
            Aluno a2 = new Aluno();
            Aluno a3 = new Aluno();
            a1.Nome = "Rafael";
            a2.Nome = "Paulo";
            a3.Nome = "Ana";

            Lista<Aluno> lista = new Lista<Aluno>();

            //Testando o método Adiciona
            lista.Adiciona(a1);
            lista.Adiciona(a2);
            System.Console.WriteLine(lista.Imprime());

            //Testando o método Contem
            System.Console.WriteLine(lista.Contem(a1));
            System.Console.WriteLine(lista.Contem(a3));
        }
    }
}
