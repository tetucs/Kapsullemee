namespace Kapsülleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogretmen Ogrt = new Ogretmen();
            Ogrt.adsoyad = textBox1.Text;
            Ogrt.tc = maskedTextBox1.Text;
            Ogrt.unvan = comboBox1.Text;

            label7.Text = Ogrt.adsoyad;
            label6.Text = Ogrt.tc;
            label5.Text = Ogrt.unvan;
        }
    }
}