namespace Lesson04
{
    partial class Cafe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cafe));
            pictureBoxCheese = new PictureBox();
            pictureBoxCupcake = new PictureBox();
            pictureBoxHamburger = new PictureBox();
            pictureBoxHotdog = new PictureBox();
            pictureBoxPancake = new PictureBox();
            pictureBoxPizza = new PictureBox();
            pictureBox7 = new PictureBox();
            groupBox = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            listBox1 = new ListBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCheese).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCupcake).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHamburger).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHotdog).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPancake).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPizza).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            groupBox.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxCheese
            // 
            pictureBoxCheese.Image = Properties.Resources.cheese;
            pictureBoxCheese.Location = new Point(11, 39);
            pictureBoxCheese.Name = "pictureBoxCheese";
            pictureBoxCheese.Size = new Size(80, 80);
            pictureBoxCheese.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxCheese.TabIndex = 0;
            pictureBoxCheese.TabStop = false;
            pictureBoxCheese.Click += pictureBox1_Click;
            // 
            // pictureBoxCupcake
            // 
            pictureBoxCupcake.Image = Properties.Resources.cupcake;
            pictureBoxCupcake.Location = new Point(119, 39);
            pictureBoxCupcake.Name = "pictureBoxCupcake";
            pictureBoxCupcake.Size = new Size(80, 80);
            pictureBoxCupcake.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxCupcake.TabIndex = 1;
            pictureBoxCupcake.TabStop = false;
            pictureBoxCupcake.Click += pictureBox2_Click;
            // 
            // pictureBoxHamburger
            // 
            pictureBoxHamburger.Image = Properties.Resources.hamburger;
            pictureBoxHamburger.Location = new Point(119, 162);
            pictureBoxHamburger.Name = "pictureBoxHamburger";
            pictureBoxHamburger.Size = new Size(80, 80);
            pictureBoxHamburger.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxHamburger.TabIndex = 2;
            pictureBoxHamburger.TabStop = false;
            pictureBoxHamburger.Click += pictureBox3_Click;
            // 
            // pictureBoxHotdog
            // 
            pictureBoxHotdog.Image = Properties.Resources.hotdog;
            pictureBoxHotdog.Location = new Point(223, 39);
            pictureBoxHotdog.Name = "pictureBoxHotdog";
            pictureBoxHotdog.Size = new Size(80, 80);
            pictureBoxHotdog.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxHotdog.TabIndex = 3;
            pictureBoxHotdog.TabStop = false;
            pictureBoxHotdog.Click += pictureBox4_Click;
            // 
            // pictureBoxPancake
            // 
            pictureBoxPancake.Image = Properties.Resources.pancake;
            pictureBoxPancake.Location = new Point(11, 162);
            pictureBoxPancake.Name = "pictureBoxPancake";
            pictureBoxPancake.Size = new Size(80, 80);
            pictureBoxPancake.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPancake.TabIndex = 4;
            pictureBoxPancake.TabStop = false;
            pictureBoxPancake.Click += pictureBox5_Click;
            // 
            // pictureBoxPizza
            // 
            pictureBoxPizza.Image = Properties.Resources.pizza;
            pictureBoxPizza.Location = new Point(223, 162);
            pictureBoxPizza.Name = "pictureBoxPizza";
            pictureBoxPizza.Size = new Size(80, 80);
            pictureBoxPizza.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPizza.TabIndex = 5;
            pictureBoxPizza.TabStop = false;
            pictureBoxPizza.Click += pictureBox6_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(12, 26);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(99, 42);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 6;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // groupBox
            // 
            groupBox.BackColor = Color.LightGray;
            groupBox.Controls.Add(label2);
            groupBox.Controls.Add(label1);
            groupBox.Controls.Add(pictureBox7);
            groupBox.Cursor = Cursors.Cross;
            groupBox.Dock = DockStyle.Left;
            groupBox.Location = new Point(0, 0);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(163, 278);
            groupBox.TabIndex = 7;
            groupBox.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 243);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 8;
            label2.Text = "label2";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(26, 71);
            label1.Name = "label1";
            label1.Size = new Size(71, 24);
            label1.TabIndex = 7;
            label1.Text = "C# Cafe";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightGray;
            groupBox1.Controls.Add(pictureBoxHotdog);
            groupBox1.Controls.Add(pictureBoxHamburger);
            groupBox1.Controls.Add(pictureBoxPizza);
            groupBox1.Controls.Add(pictureBoxPancake);
            groupBox1.Controls.Add(pictureBoxCupcake);
            groupBox1.Controls.Add(pictureBoxCheese);
            groupBox1.Cursor = Cursors.Cross;
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(163, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(348, 278);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.LightGray;
            listBox1.Cursor = Cursors.Cross;
            listBox1.Dock = DockStyle.Fill;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(511, 0);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(121, 278);
            listBox1.TabIndex = 10;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.YellowGreen;
            button1.Dock = DockStyle.Bottom;
            button1.Location = new Point(511, 228);
            button1.Name = "button1";
            button1.Size = new Size(121, 50);
            button1.TabIndex = 11;
            button1.Text = "Pay";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // Cafe
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(632, 278);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(groupBox1);
            Controls.Add(groupBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Cafe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cafe";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxCheese).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCupcake).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHamburger).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHotdog).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPancake).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPizza).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxCheese;
        private PictureBox pictureBoxCupcake;
        private PictureBox pictureBoxHamburger;
        private PictureBox pictureBoxHotdog;
        private PictureBox pictureBoxPancake;
        private PictureBox pictureBoxPizza;
        private PictureBox pictureBox7;
        private GroupBox groupBox;
        private GroupBox groupBox1;
        private Label label1;
        private ListBox listBox1;
        private Button button1;
        private Label label2;
    }
}
