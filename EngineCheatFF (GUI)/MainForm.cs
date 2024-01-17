using System.Security.Cryptography.X509Certificates;

namespace Main
{
    public partial class MainForm : Form
    {
        public MainForm() // load form
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Application.Exit();
            // close form if user press "X" button
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // nothing
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text; // get username that user have entered
            string password = textBox2.Text; // get password that user have entered
            if (username == "admin" & password == "admin")
            // check if username and password are correct
            {
                login.Text = "ok"; // change login button text
                this.Controls.Clear(); // clear form
                AfterLogin(); // change form ( see this program in "MainForm.Designer.cs" line 158)
            }
            else
            {
                login.Text = "Invalid"; // change login button text
                Application.Exit(); // close form
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.SetSuspendState(PowerState.Hibernate, true, true); // turn device into sleep mode
            label7.Text = "Actived"; // change label text
            label7.ForeColor = Color.Green; // change label color
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Application.SetSuspendState(PowerState.Hibernate, true, true);
            label8.Text = "Actived"; // change label text
            label8.ForeColor = Color.Green; // change label color
        }
    }
}
