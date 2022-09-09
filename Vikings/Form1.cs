using Vikings.Forms;

namespace Vikings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            RCollect f = new RCollect();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            circularProgressBar1.Hide();
            circularProgressBar2.Hide();
            circularProgressBar3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            pictureBox4.Show();
            label9.Show();
            pictureBox3.Show();
            pictureBox5.Show();
            pictureBox6.Show();
            label10.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            circularProgressBar1.Show();
            circularProgressBar2.Show();
            circularProgressBar3.Show();
            label4.Show();
            label5.Show();
            label6.Show();
            pictureBox4.Hide();
            label9.Hide();
            pictureBox3.Hide();
            pictureBox5.Hide();
            pictureBox6.Hide();
            label10.Hide();
        }
    }
}