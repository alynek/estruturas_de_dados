﻿using System;

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

            lista.Adiciona("Gollum");
            Console.WriteLine(lista.Imprime());

            lista.Adiciona("Bilbo");
            Console.WriteLine(lista.Imprime());

            lista.Adiciona(2, "Legolas");
            Console.WriteLine(lista.Imprime());

            lista.RemoveDoComeco();
            Console.WriteLine(lista.Imprime());

            Console.WriteLine(lista.Tamanho()); //Imprime tamanho 5

            lista.RemoveDoFim();
            Console.WriteLine(lista.Imprime());

            lista.Remove(2);
            Console.WriteLine(lista.Imprime());

            Console.WriteLine(lista.Contem("Bilbo")); //False pois foi excluído com o método RemoveDoFim - linha 31
            Console.WriteLine(lista.Contem("Gandalf")); //True

            Console.WriteLine(lista.Pega(2)); //Retorna o elemento Gollum
            Console.WriteLine(lista.Pega(5)); //Retorna um ArgumentException falando que a posição não existe
        }
    }
}
