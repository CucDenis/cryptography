using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator1.SubstitutiiMonoalfabetice
{
    public abstract class Cifrare
    {
        //abstract properties 
        public  int NumarPasi;
        public  char[] Text;

        public Cifrare(string text)
        {
            Text = text.ToCharArray();
        }

        //abstract methods
        public abstract void Algoritm(char[] Text);
    }
}
