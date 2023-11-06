using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuDuPendu
{
    public partial class FRM_JeuDuPendu : Form
    {

        public FRM_JeuDuPendu()
        {
            InitializeComponent();
            LetterList();
            TXB_WordToGuess.Focus();
            BTN_Retry.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CMB_LetterList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        
        private void LetterList()
        {
            CMB_LetterList.Items.Clear();
            for (int i = -1; i < 25; i++)
            {
                CMB_LetterList.Items.Add((char)('A' + (i + 1)));
            }
        }


        private void WordIsCorrect ()
        {

            string wordToGuess;
            bool wordValid = false;

            wordToGuess = TXB_WordToGuess.Text;
            foreach (char c in wordToGuess)
            {
                if (!Char.IsLetter(c))
                {
                    MessageBox.Show("Veuillez entrer un mot valide", "Erreur", MessageBoxButtons.OK);
                    wordValid = false;
                    break;
                }
                else
                {
                    wordValid = true;
                }
            }
            if (wordValid)
            {
                TXB_WordToGuess.Clear();
                BTN_Retry.Enabled = true;
                BTN_AddWord.Enabled = false;
            }
        }

        private void GuessWord ()
        {
            /*for (int i = 0; i < (wordToGuess.Length); i++)
            {
                TXB_WordToGuess.Text += "_ ";
            }

            TXB_WordToGuess.Enabled = false;*/
        }

        private void BTN_AddWord_Click(object sender, EventArgs e)
        {
            WordIsCorrect();
        }

        private void KeyPressTest(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BTN_AddWord_Click(null, null);
            }
        }
    }
}
