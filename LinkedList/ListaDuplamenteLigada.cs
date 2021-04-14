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
                Celula<T> anterior = PegaCelula(posicao);
                Celula<T> nova = new Celula<T>(anterior.Proxima, elemento);
                anterior.Proxima = nova;
                this.TotalDeElementos++;
            }
        }

        private Celula<T> PegaCelula(int posicao)
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
            return this.PegaCelula(posicao).Elemento;
        }

        public void Remove(int posicao)
        {
            if(!this.PosicaoOcupada(posicao)){
                throw new ArgumentException("Posição não existe");
            }

            if(posicao == 0){
                this.RemoveDoComeco();
            }else if(posicao == this.TotalDeElementos - 1){
                this.RemoveDoFim();
            }else{
                Celula<T> atual = this.PegaCelula(posicao - 1);
                Celula<T> anterior = atual.Anterior;
                Celula<T> proxima = atual.Proxima;
                anterior.Proxima = proxima;
                proxima.Anterior = anterior;

                this.TotalDeElementos--;
            }


        }

        public void RemoveDoComeco()
        {
            if(!this.PosicaoOcupada(0)){
                throw new ArgumentException("Posição não existe");
            }

            this.Primeira = this.Primeira.Proxima;
            this.TotalDeElementos --;

            if(this.TotalDeElementos == 0){
                this.Ultima = null;
            }
        }

        public void RemoveDoFim()
        {
            if(!this.PosicaoOcupada(this.TotalDeElementos - 1)){
                throw new ArgumentException("Posição não existe");
            }

            if(this.TotalDeElementos == 1){
                this.RemoveDoComeco();
            }

            else{
                Celula<T> penultima = this.Ultima.Anterior;
                penultima.Proxima = null;
                this.Ultima = penultima;
                this.TotalDeElementos --;
            }
        }

        public int Tamanho()
        {
            return this.TotalDeElementos;
        }

        public bool Contem(T item)
        {
            Celula<T> atual = this.Primeira;

            while(atual != null){
                if(atual.Elemento.Equals(item)){
                    return true;
                }
                atual = atual.Proxima;
            }
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