namespace Hafta8_Odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Kitap> kitaplar = new List<Kitap>();
        List<yay�nevi> yay�nevleri = new List<yay�nevi>();
        List<Editor> editorler = new List<Editor>();
        private void Form1_Load(object sender, EventArgs e)
        {
            label6.Text = "Yay�nevleri Ve Kitaplar: ";
            label8.Text = "Yay�nevleri Ve Edit�rler";
        }
        private void butyEviEkle_Click(object sender, EventArgs e)
        {
            if (yay�nEviMevcutMu())
            {
                yay�nevi yE = new yay�nevi(textBox1.Text);
                //listeolustur();
                yay�nevleri.Add(yE);
                comboBox1.Items.Add(textBox1.Text);
                comboBox1.Text = "Yay�nevi Listesi";
                label5.Text = "";
            }
            else
            {
                label5.Text = "Yay�nevi mevcut";
            }
        }
   
        private void butKitapEkle_Click(object sender, EventArgs e)
        {
            if (yay�nEviMevcutMu())    //yay�nevi yok;
               label5.Text = "�nce yay�nevi ekleyiniz";            
            else
            {
                if (kitapMevcutMu())
                {
                    yay�nevi yE = new yay�nevi(textBox1.Text);
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
            for(int i = 0; i < listBox1.Items.Count; i++)    //listbox 1,den ��karma
            {
                string sat�r =(string)listBox1.Items[i];
                if (sat�r.Contains(textBox2.Text))
                {
                    listBox1.Items.Remove(sat�r);
                    kitaplar.Remove(k1);
                    listBox2.Items.Remove(textBox2.Text);
                }
            }
            for (int i = 0; i < listBox2.Items.Count; i++) // e�er yaz�ld�ysa listbox 2,den ��karma
            {
                string sat�r = (string)listBox2.Items[i];
                if (sat�r.Contains(textBox2.Text))
                {
                    listBox2.Items.Remove(sat�r);
                    kitaplar.Remove(k1);
                    listBox2.Items.Remove(textBox2.Text);
                }
            }                                         
        }
        private void butEditorEkle_Click(object sender, EventArgs e)
        {
            if (yay�nEviMevcutMu())    //textboxtaki yay�nevi yok
                label5.Text = "�nce yay�nevi ekleyiniz";

            else
            {
                if (editorMevcutMu())
                {
                    yay�nevi yE = new yay�nevi(textBox1.Text);
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
            label7.Text = comboBox1.Text + "yay�nevindeki edit�rler";
            if (comboBox1.SelectedIndex >= 0)
            {
                label7.Text = comboBox1.Text + " yay�nevi edit�rleri: ";

            }
            for (int i = 0; i < listBox4.Items.Count; i++)
            {
                string s = (string)listBox4.Items[i];     // s = yay�nevi ve edit�r�n ad�
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
            label4.Text = comboBox1.Text + "yay�nevindeki kitaplar";
            if (comboBox1.SelectedIndex >= 0)
            {
                label4.Text = comboBox1.Text+" yay�nevi kitaplar�: ";
                
            }
            for(int i=0;i< listBox1.Items.Count; i++)
            {
                string s = (string)listBox1.Items[i];     // s = yay�nevi ve kitab�n ad�
                int p = s.IndexOf(' ');
                var ilkKelime = s.Substring(0, p > -1 ? p : s.Length);

                if (ilkKelime == comboBox1.Text)
                {
                    string kitap = s.Split('>')[1];
                    listBox2.Items.Add(kitap);
                }
            }
        } 
        private bool yay�nEviMevcutMu()
        {
            Boolean b = true;  //yay�nevi mevcut de�il   
            for (int i = 0; i < yay�nevleri.Count; i++)
            {
                if (yay�nevleri[i].ad == textBox1.Text)
                    b = false;
            }
            return b;
        }
        private bool kitapMevcutMu()
        {
            Boolean b = true;  //kitap mevcut de�il   
            for (int i = 0; i < kitaplar.Count; i++)
            {
                if (kitaplar[i].ad == textBox2.Text)
                    b = false;
            }
            return b;
        }
        private bool editorMevcutMu()
        {
            Boolean b = true;  //edit�rler mevcut de�il   
            for (int i = 0; i < editorler.Count; i++)
            {
                if (editorler[i].AdSoyad == textBox3.Text)
                    b = false;
            }
            return b;
        }
    }
}