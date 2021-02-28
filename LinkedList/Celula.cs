namespace LinkedList
{
    public class Celula<T> where T : class
    {
        private Celula<T> _proxima{get; set;}
        private T _elemento{get;}

        public Celula(Celula<T> proxima, T elemento)
        {
            _proxima = proxima;
            _elemento = elemento;
        }

        public Celula(T elemento)
        {
            _elemento = elemento;
        }
    }
}