using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace StudentGradeApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {
            string studentName = textBox1.Text;
            double EnglishGrade = Convert.ToDouble(TextboxEnglish.Text);
            double MathGrade = Convert.ToDouble(TextboxMath.Text);
            double ScienceGrade = Convert.ToDouble(TextboxMath.Text);
            double FilipinoGrade = Convert.ToDouble(TextboxFilipino.Text);
            double HistoryGrade = Convert.ToDouble(TextboxHistory.Text);


            double ave_grade = (EnglishGrade + MathGrade + ScienceGrade +FilipinoGrade + HistoryGrade) / 5;


            Result.Text = ave_grade >= 75 ? "The Student is passed" + "the general average of " + studentName + " is " + ave_grade : "The Student is failed" + "the general average of " + studentName + " is " + ave_grade; 
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void TextboxMath_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Result_Click(object sender, EventArgs e)
        {

        }
    }
}
