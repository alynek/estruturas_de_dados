using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaLigada<String> lista = new ListaLigada<String>();

            lista.AdicionaNoComeco("Gandalf");
            lista.AdicionaNoComeco("Frodo");
            System.Console.WriteLine(lista.Imprime());

            lista.Adiciona("Sam");
            System.Console.WriteLine(lista.Imprime());

            lista.Adiciona(2, "Legolas");
            System.Console.WriteLine(lista.Imprime());
        }
    }
}
