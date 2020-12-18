using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PraktikumWeek14_reversesort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonReverse_Click(object sender, EventArgs e)
        {
            string tempatreverse = "";
            if (textBoxInput.Text == String.Empty)
            {
                MessageBox.Show("Tolong isi text box terlebih dahulu");
                labelOutput.Text = "Output";
            }
            else
            {
                labelOutput.Text = textBoxInput.Text;
                for (int i = textBoxInput.TextLength - 1; i >= 0; i--)
                {
                    tempatreverse += textBoxInput.Text[i];
                }
                labelOutput.Text = tempatreverse;
            }
        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonUrut_Click(object sender, EventArgs e)
        {
            
            if (textBoxInput.Text == String.Empty)
            {
                MessageBox.Show("Tolong isi text box terlebih dahulu");
                labelOutput.Text = "Output";
            }
            else
            {
                string input1 = textBoxInput.Text;
                char[] sort = input1.ToCharArray();
                //string listsymbol = "`~!@#$%^&*()_+-=[]{}|;':[]<>?,./";
                //char[] symbol1 = listsymbol.ToCharArray();
                string symbol = String.Empty;
                string besar = String.Empty;
                string kecil = String.Empty;
                string angka = String.Empty;
                Array.Sort(sort);

                for (int i = 0; i < textBoxInput.TextLength - 1; i++)
                {
                    if (char.IsSymbol(sort[i]) == true || sort[i] == '!' || sort[i] =='@' || sort[i] =='#' || sort[i] =='$' || sort[i] =='%' || sort[i] =='^' || sort[i] =='&' || sort[i] =='*' || sort[i] =='(' || sort[i] ==')' || sort[i] =='?' || sort[i] =='.' || sort[i] ==',')
                    {
                        symbol += sort[i];
                    }
                    if (char.IsLower(sort[i]) == true)
                    {
                        kecil += sort[i];
                    }
                    if (char.IsUpper(sort[i]) == true)
                    {
                        besar += sort[i];
                    }
                    if (char.IsNumber(sort[i]) == true)
                    {
                        angka += sort[i];
                    }

                }
                labelOutput.Text = kecil + besar + angka + symbol;
            }
        }

        private void labelOutput_Click(object sender, EventArgs e)
        {

        }
    }
}
