using System.Collections.Generic;
using System.Text;
using System;

namespace Stack
{    public class Pilha<T> where T : class
    {
        private LinkedList<T> objetos = new LinkedList<T>();

        public void Insere(T objeto)
        {
            this.objetos.AddLast(objeto);
        }

        public Object Remove()
        {
            if(Vazia())
            {
                throw new ArgumentException("A pilha está vazia!");
            }
                var ultimoElemento = objetos.Last;
                this.objetos.RemoveLast();
                return ultimoElemento.Value;
        }

        public int Tamanho(){
            return this.objetos.Count;
        }

        public bool Vazia()
        {
            return this.objetos.Count == 0;
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