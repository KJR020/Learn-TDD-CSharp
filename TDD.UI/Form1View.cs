using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDD.UI 
{
    public partial class Form1View : Form
    {
        public Form1ViewModel _viewModel = new Form1ViewModel();
        private List<int> nums = new List<int>(5);
        

        public Form1View()
        {
            InitializeComponent();

            // TextBox,LabelのTextプロパティとViewModelのTextBoxTextプロパティをバインドする(連動)
            ATextBox.DataBindings.Add("Text", _viewModel, "ATextBoxText");
            BTextBox.DataBindings.Add("Text", _viewModel, "BTextBoxText");
            ResultLabel.DataBindings.Add("Text", _viewModel, "ResultLabelText");
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            var ave_val =  TDD.UI.Calculation.Ave(nums);
            // label1のテキストを変更する
            label1.Text = ave_val.ToString();
        }

        private void textBox_common_process(String text, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                int parsedvalue;
                if (int.TryParse(text, out parsedvalue))
                {
                    nums.Add(int.Parse(text));   
                }
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            textBox_common_process(textBox1.Text, e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox_common_process(textBox2.Text, e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox_common_process(textBox3.Text, e);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox_common_process(textBox4.Text, e);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox_common_process(textBox5.Text, e);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CalcularionButton_Click(object sender, EventArgs e)
        {
            _viewModel.CalculationAction();
           
        }
    }
}
