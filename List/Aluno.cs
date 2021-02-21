namespace List
{
    public class Aluno
    {
        public string Nome{get; set;}
        public override string ToString()
        {
            return this.Nome;
        }

        public override bool Equals(object o)
        {
            Aluno outro = (Aluno) o;
            return Nome.Equals(outro.Nome);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}