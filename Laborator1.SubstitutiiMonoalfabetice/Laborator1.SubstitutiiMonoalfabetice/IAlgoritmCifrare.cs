using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laborator1.SubstitutiiMonoalfabetice
{
    interface IAlgoritmCifrare
    {
        int NumarPasi();
        char[] Text();
    }
}
