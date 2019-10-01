using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game1task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rand = new Random();
        int randomnumber = 0;
        int chances = 3;

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = randomnumber + "";
            //MessageBox.Show(Convert.ToString(randomNumber));
            if (chances > 0)
            {
                if (Convert.ToInt32(textBox1.Text) == randomnumber)
                {
                    MessageBox.Show("you win");
                }
                else if (Convert.ToInt32(textBox1.Text)  != randomnumber)
                {
                    MessageBox.Show("you have " + chances + " number of Chance(s) left");
                    //chances = chances - 1;
                    //chances -=1;
                    chances--;
                    //TextBox.Visible = false;7 

                }

                }
            else
            {
                MessageBox.Show("you lose");
            }
                 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            randomnumber = rand.Next(0, 10);
        }
    }
}
