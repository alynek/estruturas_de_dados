namespace LinkedList
{
    public class Celula<T> where T : class
    {
        public Celula<T> Proxima{get; set;}
        public Celula<T> Anterior{get; set;}
        public T Elemento{ get; private set; }

        public Celula(Celula<T> proxima, T elemento)
        {
            Proxima = proxima;
            Elemento = elemento;
        }

        public Celula(T elemento)
        {
            Elemento = elemento;
        }
    }
}