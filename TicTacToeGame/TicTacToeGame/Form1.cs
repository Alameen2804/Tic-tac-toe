using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeGame
{
    public partial class Form1 : Form
    {
        TicTacToe Tgame = new TicTacToe();
         
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Tgame.Flag==0)
            {
                if (button1.Text=="")
                {
                    Tgame.Choice = 0;
                    Tgame.MarkInBoard();
                    button1.Text = Convert.ToString(Tgame.Array[0]);
                }
                else
                {
                    MessageBox.Show("Button is already marked !");
                }
            }
            label3.Text = Tgame.WinOrDraw();
            if (label3.Text=="")
            {
                label2.Text = Tgame.ChanceOfThePlayer();   
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Tgame.Flag==0)
            {
                if (button2.Text=="")
                {
                    Tgame.Choice = 1;
                    Tgame.MarkInBoard();
                    button2.Text = Convert.ToString(Tgame.Array[1]);
                }
                else
                {
                    MessageBox.Show("Button is already marked !");
                }
            }
            label3.Text = Tgame.WinOrDraw();
            if (label3.Text == "")
            {
                label2.Text = Tgame.ChanceOfThePlayer();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Tgame.Flag == 0)
            {
                if (button3.Text == "")
                {
                    Tgame.Choice = 2;
                    Tgame.MarkInBoard();
                    button3.Text = Convert.ToString(Tgame.Array[2]);
                }
                else
                {
                    MessageBox.Show("Button is already marked !");
                }
            }
            label3.Text = Tgame.WinOrDraw();
            if (label3.Text == "")
            {
                label2.Text = Tgame.ChanceOfThePlayer();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Tgame.Flag == 0)
            {
                if (button4.Text == "")
                {
                    Tgame.Choice = 3;
                    Tgame.MarkInBoard();
                    button4.Text = Convert.ToString(Tgame.Array[3]);
                }
                else
                {
                    MessageBox.Show("Button is already marked !");
                }
            }
            label3.Text = Tgame.WinOrDraw();
            if (label3.Text == "")
            {
                label2.Text = Tgame.ChanceOfThePlayer();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Tgame.Flag == 0)
            {
                if (button5.Text == "")
                {
                    Tgame.Choice = 4;
                    Tgame.MarkInBoard();
                    button5.Text = Convert.ToString(Tgame.Array[4]);
                }
                else
                {
                    MessageBox.Show("Button is already marked !");
                }
            }
            label3.Text = Tgame.WinOrDraw();
            if (label3.Text == "")
            {
                label2.Text = Tgame.ChanceOfThePlayer();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Tgame.Flag == 0)
            {
                if (button6.Text == "")
                {
                    Tgame.Choice = 5;
                    Tgame.MarkInBoard();
                    button6.Text = Convert.ToString(Tgame.Array[5]);
                }
                else
                {
                    MessageBox.Show("Button is already marked !");
                }
            }
            label3.Text = Tgame.WinOrDraw();
            if (label3.Text == "")
            {
                label2.Text = Tgame.ChanceOfThePlayer();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Tgame.Flag == 0)
            {
                if (button7.Text == "")
                {
                    Tgame.Choice = 6;
                    Tgame.MarkInBoard();
                    button7.Text = Convert.ToString(Tgame.Array[6]);
                }
                else
                {
                    MessageBox.Show("Button is already marked !");
                }
            }
            label3.Text = Tgame.WinOrDraw();
            if (label3.Text == "")
            {
                label2.Text = Tgame.ChanceOfThePlayer();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Tgame.Flag == 0)
            {
                if (button8.Text == "")
                {
                    Tgame.Choice = 7;
                    Tgame.MarkInBoard();
                    button8.Text = Convert.ToString(Tgame.Array[7]);
                }
                else
                {
                    MessageBox.Show("Button is already marked !");
                }
            }
            label3.Text = Tgame.WinOrDraw();
            if (label3.Text == "")
            {
                label2.Text = Tgame.ChanceOfThePlayer();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Tgame.Flag == 0)
            {
                if (button9.Text == "")
                {
                    Tgame.Choice = 8;
                    Tgame.MarkInBoard();
                    button9.Text = Convert.ToString(Tgame.Array[8]);
                }
                else
                {
                    MessageBox.Show("Button is already marked !");
                }
            }
            label3.Text = Tgame.WinOrDraw();
            if (label3.Text == "")
            {
                label2.Text = Tgame.ChanceOfThePlayer();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Tgame = new TicTacToe();

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            label2.Text = Tgame.ChanceOfThePlayer();
            label3.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = Tgame.ChanceOfThePlayer();
            label3.Text = "";
        }
    }
}