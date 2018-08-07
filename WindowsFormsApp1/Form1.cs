using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Random RN = new Random();
        int TA = 4;
        public Form1()
        {
            InitializeComponent();

            //TA = ((int)(RN.NextDouble() * 100)) + 1;
            TA = RN.Next(1,100) ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int top, down;
            int guess = (int)(this.numericUpDown1.Value);
            this.textBox1.Text = "" + guess;
            top = int.Parse(numericUpDown1.Maximum.ToString());  //把numericUpDown1中最大值給top
            down = int.Parse(numericUpDown1.Minimum.ToString()); //把numericUpDown1中最小值給down
            if (guess > TA)
            {
                top = guess;               
                this.textBox1.Text += /*Environment.NewLine*/ "\r\n" + "你猜太大了"+"\r\n";  //Environment.NewLine可以用\r\n取代
                this.textBox1.Text += top + "~" + down;
                numericUpDown1.Maximum =guess;//更改numericUpDown1中最大值
            }
            else if (guess < TA)
            {
                down = guess;              
                this.textBox1.Text += /*Environment.NewLine*/ "\r\n" + "你猜太小了"+"\r\n";
                this.textBox1.Text += top + "~" + down;
                numericUpDown1.Minimum = guess; //numericUpDown1中最小值給down
            }
            else
            {
                this.textBox1.Text += /*Environment.NewLine*/ "\r\n" + "你猜對了";
                TA = ((int)(RN.NextDouble() * 100)) + 1;
                numericUpDown1.Maximum = 100;
                numericUpDown1.Minimum = 1;
            }
           
        }
    }
}
