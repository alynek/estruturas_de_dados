namespace LinkedList
{
    public class ListaLigada<T> where T : class
    {
        private Celula<T> Primeira;
        private Celula<T> Ultima;
        private int TotalDeElementos;

        public void Adiciona(T elemento)
        {

        }

        public void Adiciona(int posicao, T elemento)
        {

        }

        public void AdicionaNoComeco(T elemento)
        {
            Celula<T> novaCelula = new Celula<T>(Primeira, elemento);
            Primeira = novaCelula;

            if(TotalDeElementos == 0)
            {
                Ultima = novaCelula;
            }

            TotalDeElementos++;
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
    }
}