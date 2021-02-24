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
            Aluno a4 = new Aluno();
            Aluno a5 = new Aluno();
            Aluno a6 = new Aluno();
            a1.Nome = "Rafael";
            a2.Nome = "Paulo";
            a3.Nome = "Ana";
            a4.Nome = "Susan";
            a5.Nome = "Robert";
            a6.Nome = "Bruce";

            Lista<Aluno> lista = new Lista<Aluno>();

            lista.Adiciona(a1);
            lista.Adiciona(a2);
            lista.Adiciona(a4);

            System.Console.WriteLine(lista.Imprime()); //Rafael, paulo, susan

            
            System.Console.WriteLine(lista.Contem(a1));
            System.Console.WriteLine(lista.Contem(a3));

            
            System.Console.WriteLine(lista.Pega(1));
            //System.Console.WriteLine(lista.Pega(6));

            System.Console.WriteLine(lista.Tamanho());
            lista.Adiciona(a3, 1); 
            lista.Adiciona(a5, 0); 
            lista.Adiciona(a6, 2);
            System.Console.WriteLine(lista.Tamanho());
            System.Console.WriteLine(lista.Imprime());

            lista.Remove(1); 
            System.Console.WriteLine(lista.Imprime());

            lista.Remove(a4); 
            System.Console.WriteLine(lista.Imprime());
            lista.Remove(a5);
            System.Console.WriteLine(lista.Imprime());
        }
    }
}
