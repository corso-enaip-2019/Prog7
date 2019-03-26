using System.Collections.Generic;

namespace studentClasse
{
    internal class list<T> : List<Student>
    {
        private string v;

        public list(string v)
        {
            this.v = v;
        }
    }
}