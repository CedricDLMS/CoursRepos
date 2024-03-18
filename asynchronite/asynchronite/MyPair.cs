using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asynchronite
{
    public class MyPair<T,U>
    {
        public T First;
        public U Second;

        public override string ToString()
        {
            return $"Value 1: {First} + Value 2: {Second}";
        }

        public MyPair(T First, U Second)
        {
            this.First = First;
            this.Second = Second;
        }
    }
}
