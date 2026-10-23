namespace Lesson04
{
    public partial class Cafe : Form
    {
        int budget = 1000;
        int totalPrice = 0;

        //Prices off the menu
        int cheese = 50;
        int cupcake = 30;
        int hotdog = 50;
        int pancake = 60;
        int hamburger = 70;
        int pizza = 80;

        public Cafe()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateLabels();
        }

        //Adds an item to the order, so each picture click only needs one line
        private void AddToOrder(string name, int price)
        {
            totalPrice += price;
            listBox1.Items.Add(name);
            UpdateLabels();
        }

        private void UpdateLabels()
        {
            label1.Text = "Total Price: " + totalPrice;
            label2.Text = "Budget: " + budget;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AddToOrder("Cheese", cheese);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AddToOrder("Cupcake", cupcake);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AddToOrder("Hamburger", hamburger);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            AddToOrder("Hotdog", hotdog);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            AddToOrder("Pancake", pancake);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            AddToOrder("Pizza", pizza);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            //Logo: intentionally does nothing
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (totalPrice <= budget)
            {
                MessageBox.Show("Total Price: " + totalPrice + "\nThe payment is successful.");
                budget -= totalPrice;
                totalPrice = 0;
                listBox1.Items.Clear();
                UpdateLabels();
            }
            else
            {
                MessageBox.Show("Total Price: " + totalPrice + " (Maximum limit reached)");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}