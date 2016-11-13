using System;
using System.Windows.Forms;

namespace lesson5describeobject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            decimal price = 24.99M;//use decimal data type for monetary values
            bool hasSaber = true;//Use bool to represent true or false values
            string color = "black";//Use string data types to represent values like words
            double height = 6.5;//double data types are good for representing measured things
            //line below produces a description shown in the form when the program runs
            //\n has the result of stack the output vertically over several horizontal lines
            descLabel.Text = $"Price:{price}\nHas Saber:{hasSaber}\nColor:{color}\nHeight:{height}";
        }
    }
}
