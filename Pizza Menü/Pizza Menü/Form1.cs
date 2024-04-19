namespace Pizza_Menü
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Kucuk = 11;
            int Orta = 16;
            int Buyuk = 30;
            int Sebzeli = 2;
            int BolKekik = 2;
            int Sos = 3;
            int Mısır = 2;
            int ToplamFiyat = 0;
    

            if (radiobtnKucuk.Checked && !radiobtnBuyuk.Checked && !radiobtnOrta.Checked)
            {
                textBox1.Text = Kucuk.ToString()+"TL";
            }

            else if (radiobtnOrta.Checked && !radiobtnKucuk.Checked && !radiobtnBuyuk.Checked)
            {
                textBox1.Text = Orta.ToString()+"TL";
            }

            else if (radiobtnBuyuk.Checked && !radiobtnKucuk.Checked && !radiobtnOrta.Checked)
            {
                textBox1.Text = Buyuk.ToString()+"TL";
            }



            if (radiobtnKucuk.Checked && radiobtnSebzeli.Checked)
            {
                ToplamFiyat = Kucuk + Sebzeli;
                textBox1.Text = ToplamFiyat.ToString() + "TL";
            }

            else if (radiobtnOrta.Checked && radiobtnSebzeli.Checked)
            {
                ToplamFiyat = Orta + Sebzeli;
                textBox1.Text = ToplamFiyat.ToString() + "TL";
            }

            else if (radiobtnBuyuk.Checked && radiobtnSebzeli.Checked)
            {
                ToplamFiyat = Buyuk + Sebzeli;
                textBox1.Text = ToplamFiyat.ToString()+"TL"; ;
            }



            if (radiobtnKucuk.Checked && radiobtnSebzeli.Checked && radiobtnKekik.Checked)
            {
                ToplamFiyat = Kucuk + Sebzeli + BolKekik;
                textBox1.Text = ToplamFiyat.ToString()+"TL";
            }

            else if (radiobtnKucuk.Checked && radiobtnSebzeli.Checked && radiobtnSos.Checked)
            {
                ToplamFiyat = Kucuk + Sebzeli + Sos;
                textBox1.Text = ToplamFiyat.ToString() + "TL";
            }

            else if (radiobtnKucuk.Checked && radiobtnSebzeli.Checked && radiobtnMısır.Checked)
            {
                ToplamFiyat = Kucuk + Sebzeli + Mısır;
                textBox1.Text = ToplamFiyat.ToString() + "TL";
            }

            else if (radiobtnOrta.Checked && radiobtnSebzeli.Checked && radiobtnKekik.Checked)
            {
                ToplamFiyat = Orta +  Sebzeli + BolKekik;
                textBox1.Text = ToplamFiyat.ToString() + "TL";
            }

            else if (radiobtnOrta.Checked && radiobtnSebzeli.Checked && radiobtnSos.Checked)
            {
                ToplamFiyat = Orta + Sebzeli + Sos;
                textBox1.Text = ToplamFiyat.ToString() + "TL";
            }

            else if (radiobtnOrta.Checked && radiobtnSebzeli.Checked && radiobtnMısır.Checked)
            {
                ToplamFiyat = Orta + Sebzeli + Mısır;
                textBox1.Text = ToplamFiyat.ToString() + "TL";
            }

            else if (radiobtnBuyuk.Checked && radiobtnSebzeli.Checked && radiobtnKekik.Checked)
            {
                ToplamFiyat = Buyuk + Sebzeli + BolKekik;
                textBox1.Text = ToplamFiyat.ToString() + "TL";
            }

            else if (radiobtnBuyuk.Checked && radiobtnSebzeli.Checked && radiobtnSos.Checked)
            {
                ToplamFiyat = Buyuk + Sebzeli + Sos;
                textBox1.Text = ToplamFiyat.ToString() + "TL";
            }

            else if (radiobtnBuyuk.Checked && radiobtnSebzeli.Checked && radiobtnMısır.Checked)
            {
                ToplamFiyat = Buyuk + Sebzeli + Mısır;
                textBox1.Text = ToplamFiyat.ToString() + "TL";
            }



            else if (radiobtnKucuk.Checked && radiobtnKekik.Checked)
            {
                ToplamFiyat = Kucuk + BolKekik;
                textBox1.Text = ToplamFiyat.ToString() + "TL";
            }

            else if (radiobtnKucuk.Checked && radiobtnSos.Checked)
            {
                ToplamFiyat = Kucuk + Sos;
                textBox1.Text = ToplamFiyat.ToString() + "TL";
            }

            else if (radiobtnKucuk.Checked && radiobtnMısır.Checked)
            {
                ToplamFiyat = Kucuk + Mısır;
                textBox1.Text = ToplamFiyat.ToString() + "TL";
            }

            else if (radiobtnOrta.Checked && radiobtnKekik.Checked)
            {
                ToplamFiyat = Orta + BolKekik;
                textBox1.Text = ToplamFiyat.ToString() + "TL";
            }

            else if (radiobtnOrta.Checked && radiobtnSos.Checked)
            {
                ToplamFiyat = Orta + Sos;
                textBox1.Text = ToplamFiyat.ToString() + "TL";
            }

            else if (radiobtnOrta.Checked && radiobtnMısır.Checked)
            {
                ToplamFiyat = Orta + Mısır;
                textBox1.Text = ToplamFiyat.ToString() + "TL";
            }

            else if (radiobtnBuyuk.Checked && radiobtnKekik.Checked)
            {
                ToplamFiyat = Buyuk + BolKekik;
                textBox1.Text = ToplamFiyat.ToString() + "TL";
            }

            else if (radiobtnBuyuk.Checked && radiobtnSos.Checked)
            {
                ToplamFiyat = Buyuk + Sos;
                textBox1.Text = ToplamFiyat.ToString() + "TL";
            }

            else if (radiobtnBuyuk.Checked && radiobtnMısır.Checked)
            {
                ToplamFiyat = Buyuk + Mısır;
                textBox1.Text = ToplamFiyat.ToString() + "TL";
            }


        }
    }
  
}