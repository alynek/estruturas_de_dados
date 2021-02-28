namespace LinkedList
{
    public class Celula
    {
        private Celula _proxima{get; set;}
        private T _elemento{get;}

        public Celula(Celula proxima, T elemento)
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