namespace Hafta8_Odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Kitap> kitaplar = new List<Kitap>();
        List<yayýnevi> yayýnevleri = new List<yayýnevi>();
        List<Editor> editorler = new List<Editor>();
        private void Form1_Load(object sender, EventArgs e)
        {
            label6.Text = "Yayýnevleri Ve Kitaplar: ";
            label8.Text = "Yayýnevleri Ve Editörler";
        }
        private void butyEviEkle_Click(object sender, EventArgs e)
        {
            if (yayýnEviMevcutMu())
            {
                yayýnevi yE = new yayýnevi(textBox1.Text);
                //listeolustur();
                yayýnevleri.Add(yE);
                comboBox1.Items.Add(textBox1.Text);
                comboBox1.Text = "Yayýnevi Listesi";
                label5.Text = "";
            }
            else
            {
                label5.Text = "Yayýnevi mevcut";
            }
        }
   
        private void butKitapEkle_Click(object sender, EventArgs e)
        {
            if (yayýnEviMevcutMu())    //yayýnevi yok;
               label5.Text = "Önce yayýnevi ekleyiniz";            
            else
            {
                if (kitapMevcutMu())
                {
                    yayýnevi yE = new yayýnevi(textBox1.Text);
                    Kitap k = new Kitap(textBox2.Text);
                    kitaplar.Add(k);
                    label5.Text = "";
                    listBox1.Items.Add(textBox1.Text + " > " + textBox2.Text);
                }                
            }                      
        }
        private void butKitapSil_Click(object sender, EventArgs e)
        {
            Kitap k1=new Kitap(textBox2.Text);
            for(int i = 0; i < listBox1.Items.Count; i++)    //listbox 1,den çýkarma
            {
                string satýr =(string)listBox1.Items[i];
                if (satýr.Contains(textBox2.Text))
                {
                    listBox1.Items.Remove(satýr);
                    kitaplar.Remove(k1);
                    listBox2.Items.Remove(textBox2.Text);
                }
            }
            for (int i = 0; i < listBox2.Items.Count; i++) // eðer yazýldýysa listbox 2,den çýkarma
            {
                string satýr = (string)listBox2.Items[i];
                if (satýr.Contains(textBox2.Text))
                {
                    listBox2.Items.Remove(satýr);
                    kitaplar.Remove(k1);
                    listBox2.Items.Remove(textBox2.Text);
                }
            }                                         
        }
        private void butEditorEkle_Click(object sender, EventArgs e)
        {
            if (yayýnEviMevcutMu())    //textboxtaki yayýnevi yok
                label5.Text = "Önce yayýnevi ekleyiniz";

            else
            {
                if (editorMevcutMu())
                {
                    yayýnevi yE = new yayýnevi(textBox1.Text);
                    Editor e1 = new Editor(textBox3.Text, textBox1.Text);
                    editorler.Add(e1);
                    label5.Text = "";
                    listBox4.Items.Add(textBox1.Text + " > " + textBox3.Text);
                }                              
            }                       
        }
        private void butYeviEditorler_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            label7.Text = comboBox1.Text + "yayýnevindeki editörler";
            if (comboBox1.SelectedIndex >= 0)
            {
                label7.Text = comboBox1.Text + " yayýnevi editörleri: ";

            }
            for (int i = 0; i < listBox4.Items.Count; i++)
            {
                string s = (string)listBox4.Items[i];     // s = yayýnevi ve editörün adý
                int p = s.IndexOf(' ');
                var ilkKelime = s.Substring(0, p > -1 ? p : s.Length);

                if (ilkKelime == comboBox1.Text)
                {
                    string editor = s.Split('>')[1];
                    listBox3.Items.Add(editor);
                }
            }
        }
        private void butYEviKitaplar_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            label4.Text = comboBox1.Text + "yayýnevindeki kitaplar";
            if (comboBox1.SelectedIndex >= 0)
            {
                label4.Text = comboBox1.Text+" yayýnevi kitaplarý: ";
                
            }
            for(int i=0;i< listBox1.Items.Count; i++)
            {
                string s = (string)listBox1.Items[i];     // s = yayýnevi ve kitabýn adý
                int p = s.IndexOf(' ');
                var ilkKelime = s.Substring(0, p > -1 ? p : s.Length);

                if (ilkKelime == comboBox1.Text)
                {
                    string kitap = s.Split('>')[1];
                    listBox2.Items.Add(kitap);
                }
            }
        } 
        private bool yayýnEviMevcutMu()
        {
            Boolean b = true;  //yayýnevi mevcut deðil   
            for (int i = 0; i < yayýnevleri.Count; i++)
            {
                if (yayýnevleri[i].ad == textBox1.Text)
                    b = false;
            }
            return b;
        }
        private bool kitapMevcutMu()
        {
            Boolean b = true;  //kitap mevcut deðil   
            for (int i = 0; i < kitaplar.Count; i++)
            {
                if (kitaplar[i].ad == textBox2.Text)
                    b = false;
            }
            return b;
        }
        private bool editorMevcutMu()
        {
            Boolean b = true;  //editörler mevcut deðil   
            for (int i = 0; i < editorler.Count; i++)
            {
                if (editorler[i].AdSoyad == textBox3.Text)
                    b = false;
            }
            return b;
        }
    }
}