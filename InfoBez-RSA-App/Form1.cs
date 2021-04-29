using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoBez_RSA_App
{
    public partial class Form1 : Form
    {
        RSA RSA = new RSA();

        public Form1()
        {
            InitializeComponent();
            textBox_PrimeNumbers_From.Text = RSA.PrimesFrom.ToString();
            textBox_PrimeNumbers_To.Text = RSA.PrimesTo.ToString();
        }

        private void button_GenerateP_Click(object sender, EventArgs e)
        {
            RSA.GenerateP();
            textBox_P.Text = RSA.P.ToString();
        }

        private void button_GenerateQ_Click(object sender, EventArgs e)
        {
            RSA.GenerateQ();
            textBox_Q.Text = RSA.Q.ToString();
        }

        private void button_GenerateE_Click(object sender, EventArgs e)
        {
            var textE = textBox_E_From.Text;
            ulong fromE = 5;
            if (textE != "")
            {
                fromE = (ulong)int.Parse(textE);
            }
            RSA.GenerateE(fromE);
            textBox_E.Text = RSA.E.ToString();

            var textD = textBox_D_From.Text;
            ulong fromD = 5;
            if (textD != "")
            {
                fromD = (ulong)int.Parse(textD);
            }
            RSA.GenerateD(fromD);
            textBox_D.Text = RSA.D.ToString();
        }

        private void button_D_SetN_Click(object sender, EventArgs e)
        {
            var n = RSA.P * RSA.Q;
            textBox_D_From.Text = n.ToString();
        }

        private void button_Encrypt_Click(object sender, EventArgs e)
        {
            if (textBox_P.Text == "" || textBox_Q.Text == "" || textBox_E.Text == "" || textBox_D.Text == "")
            {
                richTextBox_InputText.Text = "Generate all parameters";
                return;
            }
            if (richTextBox_InputText.Text == "")
            {
                richTextBox_InputText.Text = "Type some text here...";
                return;
            }
            RSA.InputText = richTextBox_InputText.Text;
            RSA.Encrypt();
            richTextBox_EncryptedText.Text = RSA.EncryptedText;
        }

        private void button_Decrypt_Click(object sender, EventArgs e)
        {
            RSA.EncryptedText = richTextBox_EncryptedText.Text;
            RSA.Decrypt();
            richTextBox_DecryptedText.Text = RSA.DecrypredText;
        }

        private void textBox_PrimeNumbers_From_TextChanged(object sender, EventArgs e)
        {
            if (textBox_PrimeNumbers_From.Text != "")
            {
                ulong from = (ulong)int.Parse(textBox_PrimeNumbers_From.Text);
                RSA.PrimesFrom = from;
                RSA.PrimeNumbers.Clear();
            }

            if (RSA.PrimesFrom > RSA.PrimesTo)
            {
                RSA.PrimesFrom = RSA.PrimesTo - 1;
                textBox_PrimeNumbers_From.Text = RSA.PrimesFrom.ToString();
            }
        }

        private void textBox_PrimeNumbers_To_TextChanged(object sender, EventArgs e)
        {
            if (textBox_PrimeNumbers_To.Text != "")
            {
                ulong to = (ulong)int.Parse(textBox_PrimeNumbers_To.Text);
                RSA.PrimesTo = to;
                RSA.PrimeNumbers.Clear();
            }

            if (RSA.PrimesTo < RSA.PrimesFrom)
            {
                RSA.PrimesTo = RSA.PrimesFrom + 1;
                textBox_PrimeNumbers_To.Text = RSA.PrimesTo.ToString();
            }
        }
    }
}
