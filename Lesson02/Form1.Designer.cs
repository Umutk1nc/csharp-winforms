namespace Lesson02
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
            male_radiobutton = new RadioButton();
            female_radiobutton = new RadioButton();
            other_radiobutton = new RadioButton();
            technology_checkbox = new CheckBox();
            sports_checkbox = new CheckBox();
            music_checkbox = new CheckBox();
            save_button = new Button();
            SuspendLayout();
            // 
            // male_radiobutton
            // 
            male_radiobutton.AutoSize = true;
            male_radiobutton.Location = new Point(47, 48);
            male_radiobutton.Name = "male_radiobutton";
            male_radiobutton.Size = new Size(63, 24);
            male_radiobutton.TabIndex = 0;
            male_radiobutton.TabStop = true;
            male_radiobutton.Text = "Male";
            male_radiobutton.UseVisualStyleBackColor = true;
            male_radiobutton.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // female_radiobutton
            // 
            female_radiobutton.AutoSize = true;
            female_radiobutton.Location = new Point(47, 78);
            female_radiobutton.Name = "female_radiobutton";
            female_radiobutton.Size = new Size(78, 24);
            female_radiobutton.TabIndex = 1;
            female_radiobutton.TabStop = true;
            female_radiobutton.Text = "Female";
            female_radiobutton.UseVisualStyleBackColor = true;
            female_radiobutton.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // other_radiobutton
            // 
            other_radiobutton.AutoSize = true;
            other_radiobutton.Location = new Point(47, 108);
            other_radiobutton.Name = "other_radiobutton";
            other_radiobutton.Size = new Size(67, 24);
            other_radiobutton.TabIndex = 2;
            other_radiobutton.TabStop = true;
            other_radiobutton.Text = "Other";
            other_radiobutton.UseVisualStyleBackColor = true;
            other_radiobutton.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // technology_checkbox
            // 
            technology_checkbox.AutoSize = true;
            technology_checkbox.Location = new Point(47, 201);
            technology_checkbox.Name = "technology_checkbox";
            technology_checkbox.Size = new Size(107, 24);
            technology_checkbox.TabIndex = 3;
            technology_checkbox.Text = "Technology";
            technology_checkbox.UseVisualStyleBackColor = true;
            // 
            // sports_checkbox
            // 
            sports_checkbox.AutoSize = true;
            sports_checkbox.Location = new Point(261, 201);
            sports_checkbox.Name = "sports_checkbox";
            sports_checkbox.Size = new Size(73, 24);
            sports_checkbox.TabIndex = 4;
            sports_checkbox.Text = "Sports";
            sports_checkbox.UseVisualStyleBackColor = true;
            // 
            // music_checkbox
            // 
            music_checkbox.AutoSize = true;
            music_checkbox.Location = new Point(430, 201);
            music_checkbox.Name = "music_checkbox";
            music_checkbox.Size = new Size(69, 24);
            music_checkbox.TabIndex = 5;
            music_checkbox.Text = "Music";
            music_checkbox.UseVisualStyleBackColor = true;
            music_checkbox.CheckedChanged += music_CheckedChanged;
            // 
            // save_button
            // 
            save_button.BackColor = Color.LightSkyBlue;
            save_button.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            save_button.ForeColor = Color.Black;
            save_button.Location = new Point(47, 323);
            save_button.Name = "save_button";
            save_button.Size = new Size(452, 67);
            save_button.TabIndex = 6;
            save_button.Text = "Save";
            save_button.UseVisualStyleBackColor = false;
            save_button.Click += save_button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(588, 500);
            Controls.Add(save_button);
            Controls.Add(music_checkbox);
            Controls.Add(sports_checkbox);
            Controls.Add(technology_checkbox);
            Controls.Add(other_radiobutton);
            Controls.Add(female_radiobutton);
            Controls.Add(male_radiobutton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton male_radiobutton;
        private RadioButton female_radiobutton;
        private RadioButton other_radiobutton;
        private CheckBox technology_checkbox;
        private CheckBox sports_checkbox;
        private CheckBox music_checkbox;
        private Button save_button;
    }
}
