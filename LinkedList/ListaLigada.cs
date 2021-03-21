using System;
using System.Text;

namespace LinkedList
{
    public class ListaLigada<T> where T : class
    {
        private Celula<T> Primeira;
        private Celula<T> Ultima;
        private int TotalDeElementos;

        public void Adiciona(T elemento)
        {
            if(this.TotalDeElementos == 0){
                AdicionaNoComeco(elemento);
            }
            else{
                Celula<T> novaCelula = new Celula<T>(elemento);
                this.Ultima.Proxima = novaCelula;
                this.Ultima = novaCelula;
                this.TotalDeElementos++;
            }
        }

        public void AdicionaNoComeco(T elemento)
        {
            Celula<T> novaCelula = new Celula<T>(Primeira, elemento);
            this.Primeira = novaCelula;

            if(this.TotalDeElementos == 0)
            {
                this.Ultima = novaCelula;
            }

            this.TotalDeElementos++;
        }

        public void Adiciona(int posicao, T elemento)
        {
            if(posicao == 0)
            {
                AdicionaNoComeco(elemento);
            }else if(posicao == this.TotalDeElementos)
            {
                Adiciona(elemento);
            }else
            {
                Celula<T> anterior = PegaCelulaAnterior(posicao);
                Celula<T> nova = new Celula<T>(anterior.Proxima, elemento);
                anterior.Proxima = nova;
                this.TotalDeElementos++;
            }
        }

        private Celula<T> PegaCelulaAnterior(int posicao)
        {
            if(!PosicaoOcupada(posicao))
            {
                throw new ArgumentException("Posição não existe!");
            }
            Celula<T> atual = Primeira;

            for(int i = 0; i < posicao; i++)
            {
                atual = atual.Proxima;
            }
            return atual;
        }

        private bool PosicaoOcupada(int posicao)
        {
            return posicao >= 0 && posicao < this.TotalDeElementos;
        }

        public T Pega(int posicao)
        {
            return null;
        }

        public void Remove(int posicao)
        {

        }

        public void RemoveDoComeco()
        {

        }

        public void RemoveDoFim()
        {

        }

        public int Tamanho()
        {
            return 0;
        }

        public bool Contem(T item)
        {
            return false;
        }

        public string Imprime()
        {
            if(this.TotalDeElementos == 0)
            {
                return "[]";
            }
            
            StringBuilder builder = new StringBuilder("[");
            Celula<T> atual = Primeira;

            for(int i = 0; i < this.TotalDeElementos - 1; i++)
            {
                builder.Append(atual.Elemento);
                builder.Append(", ");
                atual = atual.Proxima;
            }

            builder.Append(atual.Elemento);
            builder.Append("]");
            return builder.ToString();
        }
    }
}