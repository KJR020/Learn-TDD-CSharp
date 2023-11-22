using System.Runtime.CompilerServices;

namespace TDD.UI
{
    partial class Form1View
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.ATextBox = new System.Windows.Forms.TextBox();
            this.BTextBox = new System.Windows.Forms.TextBox();
            this.CalculationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(619, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(293, 317);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(594, 708);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(84, 331);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(278, 323);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(413, 331);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 31);
            this.textBox1.TabIndex = 3;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(413, 404);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 31);
            this.textBox2.TabIndex = 4;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(413, 477);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 31);
            this.textBox3.TabIndex = 5;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(413, 550);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 31);
            this.textBox4.TabIndex = 6;
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(413, 623);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 31);
            this.textBox5.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "+";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(596, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "=";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(671, 92);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(43, 24);
            this.ResultLabel.TabIndex = 10;
            this.ResultLabel.Text = "xxx";
            this.ResultLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // ATextBox
            // 
            this.ATextBox.Location = new System.Drawing.Point(215, 89);
            this.ATextBox.Name = "ATextBox";
            this.ATextBox.Size = new System.Drawing.Size(100, 31);
            this.ATextBox.TabIndex = 11;
            // 
            // BTextBox
            // 
            this.BTextBox.Location = new System.Drawing.Point(443, 89);
            this.BTextBox.Name = "BTextBox";
            this.BTextBox.Size = new System.Drawing.Size(100, 31);
            this.BTextBox.TabIndex = 11;
            // 
            // CalculationButton
            // 
            this.CalculationButton.Location = new System.Drawing.Point(503, 158);
            this.CalculationButton.Name = "CalculationButton";
            this.CalculationButton.Size = new System.Drawing.Size(136, 65);
            this.CalculationButton.TabIndex = 12;
            this.CalculationButton.Text = "button2";
            this.CalculationButton.UseVisualStyleBackColor = true;
            this.CalculationButton.Click += new System.EventHandler(this.CalcularionButton_Click);
            // 
            // Form1View
            // 
            this.ClientSize = new System.Drawing.Size(1093, 939);
            this.Controls.Add(this.CalculationButton);
            this.Controls.Add(this.BTextBox);
            this.Controls.Add(this.ATextBox);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1View";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.TextBox ATextBox;
        private System.Windows.Forms.TextBox BTextBox;
        private System.Windows.Forms.Button CalculationButton;
    }
}

