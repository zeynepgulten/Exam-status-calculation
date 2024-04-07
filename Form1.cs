namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sinav,sinav2,proje,ortalama;

            sinav=Convert.ToDouble(textBox1.Text);
            sinav2 = Convert.ToDouble(textBox2.Text);
            proje = Convert.ToDouble(textBox3.Text);

            ortalama=(sinav*30/100)+(sinav2*30/100)+(proje*40/100);

            if(ortalama>=50)
            {
                label4.Text = ortalama+"-geçtiniz!";
            }

            else
            {
                label4.Text = ortalama.ToString("0.00")+"-kaldýnýz!";
            }
        }
    }
}
