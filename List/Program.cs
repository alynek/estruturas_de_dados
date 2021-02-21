using System;

namespace List
{
    public class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno();
            Aluno a2 = new Aluno();
            a1.Nome = "Rafael";
            a2.Nome = "Paulo";
            Lista<Aluno> lista = new Lista<Aluno>();
            lista.Adiciona(a1);
            lista.Adiciona(a2);

            lista.Imprime();
        }
    }
}
