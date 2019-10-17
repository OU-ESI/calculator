using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TestCalculator
{
    public partial class Form1 : Form
    {
        private Fortan _myClass;
        public Form1()
        {
            InitializeComponent();
            _myClass = new Fortan();
            _myClass.UpdateTxt += UpdateTxtFromMyClass;

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            int first = Convert.ToInt32(box1.Text);
            int second = Convert.ToInt32(box2.Text);
            _myClass.Addition(first, second);
        }

        public void UpdateTxtFromMyClass(string txt)
        {
            this.BeginInvoke((Action) (()=> { ansBox.Text = txt; }));
        }

        private void multiplyBtn_Click(object sender, EventArgs e)
        {
            int first = Convert.ToInt32(box1.Text);
            int second = Convert.ToInt32(box2.Text);
            _myClass.Multiplication(first, second);

        }

        private void subBtn_Click(object sender, EventArgs e)
        {
            int first = Convert.ToInt32(box1.Text);
            int second = Convert.ToInt32(box2.Text);
            _myClass.Subtraction(first, second);
        }

        private void divBtn_Click(object sender, EventArgs e)
        {
            int first = Convert.ToInt32(box1.Text);
            int second = Convert.ToInt32(box2.Text);
            if (first % second == 0)
            {
                _myClass.Divide(first, second);
            }
            else
            {

            }
            _myClass.DivideDiff(first, second);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ansBox.Text = (Convert.ToInt32(box1.Text) + Convert.ToInt32(box2.Text)).ToString();
        }
    }
}
