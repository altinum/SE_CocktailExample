namespace Se9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserControl1 uc1 = new UserControl1();
            panel2.Controls.Clear(); // Clear existing controls before adding a new one
            panel2.Controls.Add(uc1);
            uc1.Dock = DockStyle.Fill; // Make the UserControl fill the panel
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserControl2 uc2 = new UserControl2();
            panel2.Controls.Clear(); // Clear existing controls before adding a new one
            panel2.Controls.Add(uc2);
            uc2.Dock = DockStyle.Fill; // Make the UserControl fill the panel
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserControl3 uc3 = new UserControl3(); panel2.Controls.Clear(); // Clear existing controls before adding a new one
            panel2.Controls.Add(uc3);
            uc3.Dock = DockStyle.Fill; // Make the UserControl fill the panel
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show(
                "Are you sure you want to exit?",
                "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No) 
            {
                e.Cancel = true; // Cancel the closing event
            }
        }
    }
}
