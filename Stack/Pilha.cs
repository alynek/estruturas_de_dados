using System.Collections.Generic;
using System.Text;

namespace Stack
{    public class Pilha<T> where T : class
    {
        private LinkedList<T> objetos = new LinkedList<T>();

        public void Insere(T objeto)
        {
            this.objetos.AddLast(objeto);
        }

        public int Tamanho(){
            return this.objetos.Count;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder("[");
            foreach(var objeto in objetos)
            {
                builder.Append(objeto);
                builder.Append(", ");
            }
            builder.Append("]");
            return builder.ToString();
        }
    }
}