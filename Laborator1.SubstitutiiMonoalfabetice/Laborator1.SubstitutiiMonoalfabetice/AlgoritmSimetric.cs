using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator1.SubstitutiiMonoalfabetice
{
    abstract class AlgoritmSimetric
    {
        public abstract int StepsCount { get; set; }
        public abstract char[] SimpleText { get; set; }
        public abstract char[] EncryptedText { get; set; }

        //Encryptiom method
        public abstract string Encryption();

        //Decryption method
        public abstract string Decryption();

        //EncryptionBreak method
        public abstract string EncryptionBreak();
    }
}
