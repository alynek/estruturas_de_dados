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
        }
    }
}
