namespace Lesson03
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            numbersGroupBox = new GroupBox();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox1 = new MaskedTextBox();
            calculateGroupBox2 = new GroupBox();
            comboBox1 = new ComboBox();
            resultsButton = new Button();
            resultGroupBox = new GroupBox();
            listBox1 = new ListBox();
            numbersGroupBox.SuspendLayout();
            calculateGroupBox2.SuspendLayout();
            resultGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // numbersGroupBox
            // 
            numbersGroupBox.Controls.Add(maskedTextBox2);
            numbersGroupBox.Controls.Add(maskedTextBox1);
            numbersGroupBox.Location = new Point(12, 12);
            numbersGroupBox.Name = "numbersGroupBox";
            numbersGroupBox.Size = new Size(505, 102);
            numbersGroupBox.TabIndex = 0;
            numbersGroupBox.TabStop = false;
            numbersGroupBox.Text = "Numbers";
            numbersGroupBox.Enter += groupBox1_Enter;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(6, 59);
            maskedTextBox2.Mask = "9999";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(493, 27);
            maskedTextBox2.TabIndex = 1;
            maskedTextBox2.ValidatingType = typeof(int);
            maskedTextBox2.MaskInputRejected += maskedTextBox2_MaskInputRejected;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(6, 26);
            maskedTextBox1.Mask = "9999";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(493, 27);
            maskedTextBox1.TabIndex = 0;
            maskedTextBox1.ValidatingType = typeof(int);
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // calculateGroupBox2
            // 
            calculateGroupBox2.Controls.Add(comboBox1);
            calculateGroupBox2.Location = new Point(12, 132);
            calculateGroupBox2.Name = "calculateGroupBox2";
            calculateGroupBox2.Size = new Size(505, 75);
            calculateGroupBox2.TabIndex = 1;
            calculateGroupBox2.TabStop = false;
            calculateGroupBox2.Text = "Calculate";
            calculateGroupBox2.Enter += groupBox2_Enter;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "+", "-", "/", "*" });
            comboBox1.Location = new Point(6, 32);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(493, 28);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // resultsButton
            // 
            resultsButton.BackColor = Color.SpringGreen;
            resultsButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            resultsButton.Location = new Point(16, 213);
            resultsButton.Name = "resultsButton";
            resultsButton.Size = new Size(501, 36);
            resultsButton.TabIndex = 3;
            resultsButton.Text = "Start Process";
            resultsButton.UseVisualStyleBackColor = false;
            resultsButton.Click += resultsButton_Click;
            // 
            // resultGroupBox
            // 
            resultGroupBox.Controls.Add(listBox1);
            resultGroupBox.Location = new Point(12, 267);
            resultGroupBox.Name = "resultGroupBox";
            resultGroupBox.Size = new Size(505, 170);
            resultGroupBox.TabIndex = 5;
            resultGroupBox.TabStop = false;
            resultGroupBox.Text = "Result";
            resultGroupBox.Enter += resultGroupBox_Enter;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(14, 27);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(485, 124);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 463);
            Controls.Add(resultGroupBox);
            Controls.Add(resultsButton);
            Controls.Add(calculateGroupBox2);
            Controls.Add(numbersGroupBox);
            Name = "Form1";
            Text = " ";
            numbersGroupBox.ResumeLayout(false);
            numbersGroupBox.PerformLayout();
            calculateGroupBox2.ResumeLayout(false);
            resultGroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox numbersGroupBox;
        private MaskedTextBox maskedTextBox1;
        private GroupBox calculateGroupBox2;
        private ComboBox comboBox1;
        private Button resultsButton;
        private MaskedTextBox maskedTextBox2;
        private GroupBox resultGroupBox;
        private ListBox listBox1;
    }
}
