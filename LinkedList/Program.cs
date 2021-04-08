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
            Console.WriteLine(lista.Imprime());

            lista.Adiciona("Sam");
            Console.WriteLine(lista.Imprime());

            lista.Adiciona(2, "Legolas");
            Console.WriteLine(lista.Imprime());

            lista.RemoveDoComeco();
            Console.WriteLine(lista.Imprime());
        }
    }
}
