using System;

namespace Stack
{
    public class Program
    {
        static void Main(string[] args)
        {
            Pilha<string> nomes = new Pilha<string>();
            nomes.Insere("Harry");
            nomes.Insere("Rony");
            nomes.Insere("Hermione");

            Console.WriteLine(nomes.ToString());

            System.Console.WriteLine("Último elemento removido: " + nomes.Remove());
            Console.WriteLine(nomes.ToString());
            System.Console.WriteLine("Último elemento removido: " + nomes.Remove());
            Console.WriteLine(nomes.ToString());
        }
    }
}
