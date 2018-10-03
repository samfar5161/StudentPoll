using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentPoll
{
    public partial class Form1 : Form
    {
        private int[,] output = new int[10, 2];     // 2D array to hold results of student poll
        private int input;                          // value from TxtInput textbox

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // initialize array values for first column
            for (int i = 0; i < output.Length / 2; i++)
                output[i, 0] = i + 1;
        }

        private void BtnDone_Click(object sender, EventArgs e)
        {
            try
            {
                input = Convert.ToInt16(TxtInput.Text);

                for (int i = 0; i < output.Length; i++)
                {
                    if (input == i + 1)
                        output[i, 1] += 1;
                }
                TxtInput.Clear();             
            }
            catch (FormatException)
            {
                MessageBox.Show("Rating must be a number 1 - 10", "Hold up...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Rating must be a number 1 - 10", "Index out of range", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
                
            finally
            {
                TxtInput.Clear();
            }      
        }

        private void BtnShowResults_Click(object sender, EventArgs e)
        {

            TxtOutput.Text = String.Format("{0,-12}{1,14}\n", "Rating", "Frequency", TxtOutput.Text);
            TxtOutput.AppendText(Environment.NewLine);
            
            for(int i = 0; i < output.Length / 2; i++)
            {
                TxtOutput.Text += String.Format("{0, -12}{1, 14}", output[i, 0], output[i, 1]);
                TxtOutput.AppendText(Environment.NewLine);
            }
        }

        private void TxtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
                BtnDone.PerformClick();
        }
    }
}
