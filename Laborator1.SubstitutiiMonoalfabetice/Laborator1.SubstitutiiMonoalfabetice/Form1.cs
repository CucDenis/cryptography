using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laborator1.SubstitutiiMonoalfabetice
{
    public partial class Form1 : Form
    {
        SM SM = new SM();
        public static string Encrypted;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCezar_Click(object sender, EventArgs e)
        {
            Cezar Cezar = new Cezar(txtbInitial.Text);
            lbTxtFinal.Text = Cezar.Encryption();
        }

        private void btnCezarN_Click(object sender, EventArgs e)
        {
            CezarN CezarN = new CezarN(txtbInitial.Text,Convert.ToInt32(numericUDNumarPasi.Value));
            lbTxtFinal.Text = CezarN.Encryption();
        }

        private void btnRot13_Click(object sender, EventArgs e)
        {
            ROT13 ROT13 = new ROT13(txtbInitial.Text);
            lbTxtFinal.Text = ROT13.Encryption();
        }

        private void btnCezarDecipher_Click(object sender, EventArgs e)
        {
            Cezar Cezar = new Cezar(lbTxtFinal.Text);
            lbTxtFinal.Text = Cezar.Decryption();
        }

        private void btnCezarNDecipher_Click(object sender, EventArgs e)
        {
            CezarN CezarN = new CezarN(lbTxtFinal.Text, Convert.ToInt32(numericUDNumarPasi.Value));
            lbTxtFinal.Text = CezarN.Decryption();
        }

        private void btnRot13Decipher_Click(object sender, EventArgs e)
        {
            ROT13 ROT13 = new ROT13(lbTxtFinal.Text);
            lbTxtFinal.Text = ROT13.Decryption();
        }

        private void btnSMDecipher_Click(object sender, EventArgs e)
        {
            SM.AddText(Encrypted);
            lbTxtFinal.Text = SM.Decryption();
        }

        private void btnSM_Click(object sender, EventArgs e)
        {
            SM.AddText(txtbInitial.Text);
            lbTxtFinal.Text = Encrypted = SM.Encryption();
        }
    }
}
