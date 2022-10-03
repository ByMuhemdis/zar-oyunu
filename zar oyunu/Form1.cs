namespace zar_oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = textBox1.Text;
            label4.Text = textBox2.Text;
            button2.Enabled = true;
            button3.Enabled = false;
            button1.Enabled = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = false;
            richTextBox1.Enabled = false;
        }
        int toplam=0,toplam2=0;

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = true;
            Random rastgele = new Random();
            int sayi= rastgele.Next(1,7);
            toplam = toplam + sayi;
            

            if (sayi == 1)
            {
                pictureBox1.ImageLocation = "C:\\Users\\yavru\\Desktop\\Github a yüklenmiþ projeler\\zar oyunu\\indir (1).png";
                label9.Text = sayi.ToString();
                label7.Text=toplam.ToString();
            }
            if (sayi == 2)
            {
                pictureBox1.ImageLocation = "C:\\Users\\yavru\\Desktop\\Github a yüklenmiþ projeler\\zar oyunu\\indir.jfif";
                label9.Text = sayi.ToString();
                label7.Text = toplam.ToString();
            }
            if (sayi == 3)
            {
                pictureBox1.ImageLocation = "C:\\Users\\yavru\\Desktop\\Github a yüklenmiþ projeler\\zar oyunu\\indir (1).jfif";
                label9.Text = sayi.ToString();
                label7.Text = toplam.ToString();
            }
            if (sayi == 4)
            {
                pictureBox1.ImageLocation = "C:\\Users\\yavru\\Desktop\\Github a yüklenmiþ projeler\\zar oyunu\\indir.png";
                label9.Text = sayi.ToString();
                label7.Text = toplam.ToString();
            }
            if (sayi == 5)
            {
                pictureBox1.ImageLocation = "C:\\Users\\yavru\\Desktop\\Github a yüklenmiþ projeler\\zar oyunu\\images.jfif";
                label9.Text = sayi.ToString();
                label7.Text = toplam.ToString();
            }
            if (sayi == 6)
            {
                pictureBox1.ImageLocation = "C:\\Users\\yavru\\Desktop\\Github a yüklenmiþ projeler\\zar oyunu\\indir (2).jfif";
                label9.Text = sayi.ToString();
                label7.Text = toplam.ToString();
            }
            if(toplam>=100)
            {
                richTextBox1.Text = "tebriker " + textBox1.Text + " sen kazandýn";
                button2.Enabled = false;
                button3.Enabled = false;
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button3.Enabled = false;
            Random rastgele = new Random();
            int sayi = rastgele.Next(1, 7);
            toplam2 = toplam2 + sayi;
          
            if (sayi == 1)
            {
                pictureBox2.ImageLocation = "C:\\Users\\yavru\\Desktop\\Github a yüklenmiþ projeler\\zar oyunu\\indir (1).png";
                label10.Text = sayi.ToString();
                label8.Text = toplam2.ToString();


            }
            if (sayi == 2)
            {
                pictureBox2.ImageLocation = "C:\\Users\\yavru\\Desktop\\Github a yüklenmiþ projeler\\zar oyunu\\indir.jfif";
                label10.Text = sayi.ToString();
                label8.Text = toplam2.ToString();
            }
            if (sayi == 3)
            {
                pictureBox2.ImageLocation = "C:\\Users\\yavru\\Desktop\\Github a yüklenmiþ projeler\\zar oyunu\\indir (1).jfif";
                label10.Text = sayi.ToString();
                label8.Text = toplam2.ToString();
            }
            if (sayi == 4)
            {
                pictureBox2.ImageLocation = "C:\\Users\\yavru\\Desktop\\Github a yüklenmiþ projeler\\zar oyunu\\indir.png";
                label10.Text = sayi.ToString();
                label8.Text = toplam2.ToString();
            }
            if (sayi == 5)
            {
                pictureBox2.ImageLocation = "C:\\Users\\yavru\\Desktop\\Github a yüklenmiþ projeler\\zar oyunu\\images.jfif";
                label10.Text = sayi.ToString();
                label8.Text = toplam2.ToString();
            }
            if (sayi == 6)
            {
                pictureBox2.ImageLocation = "C:\\Users\\yavru\\Desktop\\Github a yüklenmiþ projeler\\zar oyunu\\indir (2).jfif";
                label10.Text = sayi.ToString();
                label8.Text = toplam2.ToString();
            }
            if(toplam2 >= 100)
            {
                richTextBox1.Text = "tebriker "+textBox2.Text+ " sen kazandýn";
                button2.Enabled = false;
                button3.Enabled = false;
            }
        }
    }
}