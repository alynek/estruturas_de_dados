using System;
using System.Text;

namespace List
{
    public class Lista<T>
    {
        private T[] ListaGenerica = new T[100];
        private int Total { get; set; } = 0;

        public void Adiciona(T item)
        {
            ListaGenerica[Total] = item;
            Total += 1;
        }

        public void Adiciona(T item, int posicao)
        {

        }

        public T Pega(int posicao)
        {
            if(!PosicaoOcupada(posicao)) throw new ArgumentException("Posição inválida!");
            return ListaGenerica[posicao];
        }

        private bool PosicaoOcupada(int posicao)
        {
            return posicao >= 0 && posicao < Total;
        }

        public void Remove(int posicao)
        {

        }

        public bool Contem(T item)
        {
            for(int i = 0; i < Total; i++)
            {
                if(item.Equals(ListaGenerica[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public int Tamanho()
        {
            return Total;
        }

        public string Imprime()
        {
            if(Total == 0)
            {
                return "[]";
            }

            StringBuilder builder = new StringBuilder();
            builder.Append("[");

            for(int i = 0; i < Total - 1; i++)
            {
                builder.Append(ListaGenerica[i]);
                builder.Append(", ");
            }
            
            builder.Append(ListaGenerica[Total - 1]);
            builder.Append("]");
            return builder.ToString();
        }
    }
}