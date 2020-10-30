using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace Laborator1.SubstitutiiMonoalfabetice
{
    class SM : AlgoritmSimetric
    {
        public override int StepsCount { get; set; }
        public override char[] SimpleText { get; set; }
        public override char[] EncryptedText { get; set; }

        private static List<int> SMAlphabet = new List<int>();
        private static List<int> NormalAlphabet = new List<int>();

        public SM()
        {
            Permutation();
            Alphabet();
        }

        public override string Decryption()
        {
            char NowChar;
            for (int i = 0; i < EncryptedText.Length; i++)
            {
                for (int j = 0; j < SMAlphabet.Count; j++)
                {
                    NowChar = Convert.ToChar(SMAlphabet.ElementAt(j));
                    if (NowChar == EncryptedText[i])
                    {
                        for (int k = 0; k < NormalAlphabet.Count; k++)
                        {
                            if (SMAlphabet.ElementAt(j) == NormalAlphabet.ElementAt(k))
                            {
                                EncryptedText[i] = Convert.ToChar(Convert.ToInt32(NormalAlphabet.ElementAt(k)));
                            }
                        }
                    }
                }
            }
            return new string(EncryptedText);
        }
public override string Encryption()
        { 
            char NowChar;
            for (int i = 0; i < SimpleText.Length; i++)
            {
                for (int j = 0; j < NormalAlphabet.Count; j++)
                {
                    NowChar = Convert.ToChar(NormalAlphabet.ElementAt(j));
                    if (NowChar == SimpleText[i])
                    {
                        for (int k = 0; k < SMAlphabet.Count; k++)
                        {
                            if (NormalAlphabet.ElementAt(j) == SMAlphabet.ElementAt(k))
                            {
                                EncryptedText[i] = Convert.ToChar(Convert.ToInt32(NormalAlphabet.ElementAt(k)));
                            }
                        }
                    }
                }
            }
            return new string(EncryptedText);
        }

        public override string EncryptionBreak()
        {
            return null;
        }

        private void Permutation()
        {
            Random rnd = new Random();
            int nowValue = 0;
            bool exist = false;

            while(SMAlphabet.Count != 26)
            {
                exist = false;
                nowValue = rnd.Next(97,122);
                for (int i = 0; i < SMAlphabet.Count; i++)
                {
                    if (SMAlphabet[i] == nowValue)
                    {
                        exist = true;
                        break;
                    }
                }

                if (!exist)
                {
                    SMAlphabet.Add(nowValue);
                }
            }
        }

        private void Alphabet()
        {
            int i = 97;
            while (NormalAlphabet.Count < 26 && i <= 122)
            {
                NormalAlphabet.Add(i);
                i++;
            }
        }

        public void AddText(string text)
        {
            SimpleText = text.ToCharArray();
            EncryptedText = text.ToCharArray();
        }
    }
}
