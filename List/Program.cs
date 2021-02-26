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

            Console.WriteLine(lista.Imprime());

            
            Console.WriteLine(lista.Contem(a1));
            Console.WriteLine(lista.Contem(a3));

            
            Console.WriteLine(lista.Pega(1));
            //.Console.WriteLine(lista.Pega(6));

            Console.WriteLine(lista.Tamanho());

            lista.Adiciona(a3, 1); 
            lista.Adiciona(a5, 0); 
            lista.Adiciona(a6, 2);
            Console.WriteLine(lista.Imprime());
            
            Console.WriteLine("Tamanho: " + lista.Tamanho());

            lista.Remove(1); 
            Console.WriteLine(lista.Imprime());

            lista.Remove(a4); 
            Console.WriteLine(lista.Imprime());
            lista.Remove(a5);
            Console.WriteLine(lista.Imprime());

            Console.WriteLine("Índice: " + lista.Indice(a5));

            lista.Limpa();
            Console.WriteLine(lista.Imprime());
        }
    }
}
