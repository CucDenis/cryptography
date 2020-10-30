using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator1.SubstitutiiMonoalfabetice
{
    class ROT13 : AlgoritmSimetric
    {
        public override int StepsCount { get; set; }
        public override char[] SimpleText { get; set; }
        public override char[] EncryptedText { get; set; }


        public ROT13(string text)
        {
            SimpleText = text.ToCharArray();
            EncryptedText = text.ToCharArray();
            StepsCount = 13;
        }

        public override string Encryption()
        {
            for (int i = 0; i < SimpleText.Length; i++)
            {
                if (SimpleText[i] != ' ')
                {
                    EncryptedText[i] = Convert.ToChar(Convert.ToInt32(SimpleText[i]) + StepsCount);
                }
            }
            return new string(EncryptedText);
        }

        public override string Decryption()
        {
            for (int i = 0; i < EncryptedText.Length; i++)
            {
                if (EncryptedText[i] != ' ')
                {
                    SimpleText[i] = Convert.ToChar(Convert.ToInt32(EncryptedText[i]) - StepsCount);
                }
            }
            return new string(SimpleText);
        }

        public override string EncryptionBreak()
        {
            throw new NotImplementedException();
        }
    }
}
