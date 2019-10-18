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
    /// <summary>
    /// GUI class
    /// </summary>
    public partial class Form1 : Form
    {
        private Fortan _myClass; // declared object of Fortran.cs Class
        /// <summary>
        /// Constructor initializes all compenents, as well as the Fortran object declared above and updates the UpdateTxt function from said class 
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            _myClass = new Fortan();
            _myClass.UpdateTxt += UpdateTxtFromMyClass;

        }

        /// <summary>
        /// Takes in input from the two textboxes, converts them to integers, then passes them to Fortran.cs addition function.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addBtn_Click(object sender, EventArgs e)
        {
            int first = Convert.ToInt32(box1.Text);
            int second = Convert.ToInt32(box2.Text);
            _myClass.Addition(first, second);
        }

        /// <summary>
        /// Invokes an action listener allowing the answer box to be updated from the txt taken from the Fortran.cs UpdateTxt function
        /// </summary>
        /// <param name="txt"></param>
        public void UpdateTxtFromMyClass(string txt)
        {
            this.BeginInvoke((Action) (()=> { ansBox.Text = txt; }));
        }

        //Works like the addition button click
        private void multiplyBtn_Click(object sender, EventArgs e)
        {
            int first = Convert.ToInt32(box1.Text);
            int second = Convert.ToInt32(box2.Text);
            _myClass.Multiplication(first, second);

        }

        //Same as last comment
        private void subBtn_Click(object sender, EventArgs e)
        {
            int first = Convert.ToInt32(box1.Text);
            int second = Convert.ToInt32(box2.Text);
            _myClass.Subtraction(first, second);
        }

        //A work in progress for dealing with both integers and floats accordingly
        private void divBtn_Click(object sender, EventArgs e)
        {
            int first = Convert.ToInt32(box1.Text);
            int second = Convert.ToInt32(box2.Text);
            if (second == 0)
            {
                MessageBox.Show("Cannot divide by zero!");
                ansBox.Text = "";
            }
            else if (first == 0) {
                ansBox.Text = (0).ToString();
            }
            else
            {
                if (first % second == 0)
                {
                    _myClass.Divide(first, second);
                }
                else
                {
                    // Still working on this _myClass.DivideDiff(first, second);
                }
            }  
        }

        /// <summary>
        /// To show how easier it can be to do the addition function with only C# instead of wrapping.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            ansBox.Text = (Convert.ToInt32(box1.Text) + Convert.ToInt32(box2.Text)).ToString();
        }
    }
}
