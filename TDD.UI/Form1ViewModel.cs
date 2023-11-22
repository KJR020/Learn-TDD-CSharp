using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDD.UI
{
    public class Form1ViewModel :INotifyPropertyChanged
    {
        //private System.Windows.Forms.Button button1;
        //private System.Windows.Forms.Label label1;
        //private System.Windows.Forms.ListView listView1;
        //private System.Windows.Forms.TextBox textBox1;
        //private System.Windows.Forms.TextBox textBox2;
        //private System.Windows.Forms.TextBox textBox3;
        //private System.Windows.Forms.TextBox textBox4;
        //private System.Windows.Forms.TextBox textBox5;
        //private System.Windows.Forms.Label label2;
        //private System.Windows.Forms.Label label3;
        //private System.Windows.Forms.Label ResultLabel;
        //private System.Windows.Forms.TextBox ATextBox;
        //private System.Windows.Forms.TextBox BTextBox;
        //private System.Windows.Forms.Button CalculationButton;

        private string _aTextBoxText = string.Empty;
        public string ATextBoxText 
        { 
            get { return _aTextBoxText; }
            set
            {
                if(_aTextBoxText == value)
                {
                    return;
                }
                _aTextBoxText = value;
                OnPropertyChanged("ATextBoxText");
            }
        }
        private string _bTextBoxText = string.Empty;
        public string BTextBoxText
        {
            get { return _bTextBoxText; }
            set 
            { 
                if(_bTextBoxText == value)
                {
                    return;
                }
                _bTextBoxText = value;
                OnPropertyChanged("BTextBoxText");
            }
        }
        private string _resultLabelText = string.Empty;
        public string ResultLabelText
        {
            get { return _resultLabelText; }
            set 
            { 
                if(_resultLabelText == value)
                {
                    return;
                }
                _resultLabelText = value;
                OnPropertyChanged("ResultLabelText");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {             
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        
        public void CalculationAction()
        {
            int a = Convert.ToInt32(ATextBoxText);
            int b = Convert.ToInt32(BTextBoxText);

            ResultLabelText = Calculation.Sum(a,b).ToString();

            OnPropertyChanged(String.Empty);
        }
    }
}
