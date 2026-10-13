namespace Lesson02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void music_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void save_button_Click(object sender, EventArgs e)
        {
            string totalString = "";
            if (male_radiobutton.Checked)
            {
                totalString += "Gender: Male\n";
            }
            else if (female_radiobutton.Checked)
            {
                totalString += "Gender: Female\n";
            }
            else if (other_radiobutton.Checked)
            {
                totalString += "Gender: Other\n";
            }
            totalString += "Technology: " + YesNo(technology_checkbox.Checked) + "\n";
            totalString += "Sports: " + YesNo(sports_checkbox.Checked) + "\n";
            totalString += "Music: " + YesNo(music_checkbox.Checked) + "\n";


            MessageBox.Show(totalString, "User Information");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private string YesNo(bool value)
        { 
            if(value)
            {
                return "Yes";
            }
            else
            {
                return "No";
            }
        }
    }
}
