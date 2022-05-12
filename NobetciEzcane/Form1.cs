using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;


namespace NobetciEzcane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Data
        {
            public string EczaneAdi { get; set; }
            public string Adresi { get; set; }
            public string Semt { get; set; }
            public string YolTarifi { get; set; }
            public string Telefon { get; set; }
            public string Telefon2 { get; set; }
            public string Sehir { get; set; }
            public string ilce { get; set; }
            public double latitude { get; set; }
            public double longitude { get; set; }
        }

        public class Root
        {
            public string status { get; set; }
            public string message { get; set; }
            public int rowCount { get; set; }
            public List<Data> data { get; set; }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Bursa"); //Index 0
            comboBox1.Items.Add("Adana"); //Index 1
            comboBox1.Items.Add("Sakarya"); //Index 2
            comboBox1.Items.Add("İstanbul"); //Index 3
            comboBox1.Items.Add("Ankara"); //Index 4
            comboBox1.Items.Add("İzmir"); //Index 5
            comboBox1.Items.Add("Konya"); //Index 6
            comboBox1.Items.Add("Antalya"); //Index 7
            comboBox1.Items.Add("Samsun"); //Index 8
            comboBox1.Items.Add("Eskisehir"); //Index 9
            timer1.Start();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            eczaneAdi.Items.Clear();
            eczaneAdres.Items.Clear();
            eczaneTelefon.Items.Clear();


            //Bursa
            if (comboBox1.SelectedIndex == 0)
            {
                comboBox2.Text = ""; //ComboBox2 içini sifirliyor
                comboBox2.Items.Add("Buyukorhan");
                comboBox2.Items.Add("Gemlik");
                comboBox2.Items.Add("Gursu");
                comboBox2.Items.Add("Harmancik");
                comboBox2.Items.Add("İnegol");
                comboBox2.Items.Add("İznik");
                comboBox2.Items.Add("Karacabey");
                comboBox2.Items.Add("Keles");
                comboBox2.Items.Add("Kestel");
                comboBox2.Items.Add("Mudanya");
                comboBox2.Items.Add("Mustafakemalpasa");
                comboBox2.Items.Add("Nilufer");
                comboBox2.Items.Add("Orhaneli");
                comboBox2.Items.Add("Orhangazi");
                comboBox2.Items.Add("Osmangazi");
                comboBox2.Items.Add("Yenisehir");
                comboBox2.Items.Add("Yildirim");
            }
            //Adana
            if (comboBox1.SelectedIndex == 1)
            {
                comboBox2.Text = ""; //ComboBox2 içini sifirliyor
                comboBox2.Items.Add("Aladag");
                comboBox2.Items.Add("Ceyhan");
                comboBox2.Items.Add("Cukurova");
                comboBox2.Items.Add("Feke");
                comboBox2.Items.Add("Karaisali");
                comboBox2.Items.Add("Karatas");
                comboBox2.Items.Add("Kozan");
                comboBox2.Items.Add("Pozanti");
                comboBox2.Items.Add("Saimbeyli");
                comboBox2.Items.Add("Saricam");
                comboBox2.Items.Add("Seyhan");
                comboBox2.Items.Add("Tufanbeyli");
                comboBox2.Items.Add("Yumurtalik");
                comboBox2.Items.Add("Yuregir");
            }
            //Sakarya
            if (comboBox1.SelectedIndex == 2)
            {
                comboBox2.Text = ""; //ComboBox2 içini sifirliyor
                comboBox2.Items.Add("Adapazari");
                comboBox2.Items.Add("Akyazi");
                comboBox2.Items.Add("Arifiye");
                comboBox2.Items.Add("Erenler");
                comboBox2.Items.Add("Ferizli");
                comboBox2.Items.Add("Gevye");
                comboBox2.Items.Add("Hendek");
                comboBox2.Items.Add("Karapurcek");
                comboBox2.Items.Add("Karasu");
                comboBox2.Items.Add("Kaynarca");
                comboBox2.Items.Add("Kocaali");
                comboBox2.Items.Add("Pamukova");
                comboBox2.Items.Add("Sapanca");
                comboBox2.Items.Add("Serdivan");
                comboBox2.Items.Add("Sogutlu");
                comboBox2.Items.Add("Tarakli");
            }
            //İstanbul
            if (comboBox1.SelectedIndex == 3)
            {
                comboBox2.Text = ""; //ComboBox2 içini sifirliyor
                comboBox2.Items.Add("Adalar");
                comboBox2.Items.Add("Arnavutkoy");
                comboBox2.Items.Add("Atasehir");
                comboBox2.Items.Add("Avcilar");
                comboBox2.Items.Add("Bagcilar");
                comboBox2.Items.Add("Bahcelievler");
                comboBox2.Items.Add("Bakirkoy");
                comboBox2.Items.Add("Basaksehir");
                comboBox2.Items.Add("Bayrampasa");
                comboBox2.Items.Add("Besiktas");
                comboBox2.Items.Add("Beykoz");
                comboBox2.Items.Add("Beylikduzu");
                comboBox2.Items.Add("Beyoglu");
                comboBox2.Items.Add("Buyukcekmece");
                comboBox2.Items.Add("Catalca");
                comboBox2.Items.Add("Cekmekoy");
                comboBox2.Items.Add("Esenler");
                comboBox2.Items.Add("Esenyurt");
                comboBox2.Items.Add("Eyup");
                comboBox2.Items.Add("Fatih");
                comboBox2.Items.Add("Gaziosmanpasa");
                comboBox2.Items.Add("Gungoren");
                comboBox2.Items.Add("Kadikoy");
                comboBox2.Items.Add("Kagithane");
                comboBox2.Items.Add("Kartal");
                comboBox2.Items.Add("Kucukcekmece");
                comboBox2.Items.Add("Maltepe");
                comboBox2.Items.Add("Pendik");
                comboBox2.Items.Add("Sancaktepe");
                comboBox2.Items.Add("Sariyer");
                comboBox2.Items.Add("Silivri");
                comboBox2.Items.Add("Sultanbeyli");
                comboBox2.Items.Add("Sultangazi");
                comboBox2.Items.Add("Sile");
                comboBox2.Items.Add("Sisli");
                comboBox2.Items.Add("Tuzla");
                comboBox2.Items.Add("Umraniye");
                comboBox2.Items.Add("Uskudar");
                comboBox2.Items.Add("Zeytinburnu");
            }
            //Ankara
            if (comboBox1.SelectedIndex == 4)
            {
                comboBox2.Text = ""; //ComboBox2 içini sifirliyor
                comboBox2.Items.Add("Akyurt");
                comboBox2.Items.Add("Altindag");
                comboBox2.Items.Add("Ayas");
                comboBox2.Items.Add("Bala");
                comboBox2.Items.Add("Beypazari");
                comboBox2.Items.Add("Camlidere");
                comboBox2.Items.Add("Cankaya");
                comboBox2.Items.Add("Cubuk");
                comboBox2.Items.Add("Elmadag");
                comboBox2.Items.Add("Etimesgut");
                comboBox2.Items.Add("Evren");
                comboBox2.Items.Add("Golbasi");
                comboBox2.Items.Add("Gudul");
                comboBox2.Items.Add("Haymana");
                comboBox2.Items.Add("Kahramankazan");
                comboBox2.Items.Add("Kalecik");
                comboBox2.Items.Add("Kecioren");
                comboBox2.Items.Add("Kizilcahamam");
                comboBox2.Items.Add("Mamak");
                comboBox2.Items.Add("Nallihan");
                comboBox2.Items.Add("Polatli");
                comboBox2.Items.Add("Pursaklar");
                comboBox2.Items.Add("Sincan");
                comboBox2.Items.Add("Sereflikochisar");
                comboBox2.Items.Add("Yenimahalle");
            }
            //İzmir
            if (comboBox1.SelectedIndex == 5)
            {
                comboBox2.Text = ""; //ComboBox2 içini sifirliyor
                comboBox2.Items.Add("Aliaga");
                comboBox2.Items.Add("Balcova");
                comboBox2.Items.Add("Bayindir");
                comboBox2.Items.Add("Bayrakli");
                comboBox2.Items.Add("Bergama");
                comboBox2.Items.Add("Beydag");
                comboBox2.Items.Add("Bornova");
                comboBox2.Items.Add("Buca");
                comboBox2.Items.Add("Cesme");
                comboBox2.Items.Add("Cigli");
                comboBox2.Items.Add("Dikili");
                comboBox2.Items.Add("Foca");
                comboBox2.Items.Add("Gaziemir");
                comboBox2.Items.Add("Guzelbahce");
                comboBox2.Items.Add("Karabaglar");
                comboBox2.Items.Add("Karaburun");
                comboBox2.Items.Add("Karsiyaka");
                comboBox2.Items.Add("Kemalpasa");
                comboBox2.Items.Add("Kinik");
                comboBox2.Items.Add("Kiraz");
                comboBox2.Items.Add("Konak");
                comboBox2.Items.Add("Menderes");
                comboBox2.Items.Add("Menemen");
                comboBox2.Items.Add("Narlidere");
                comboBox2.Items.Add("Odemis");
                comboBox2.Items.Add("Seferihisar");
                comboBox2.Items.Add("Selcuk");
                comboBox2.Items.Add("Tire");
                comboBox2.Items.Add("Torbali");
                comboBox2.Items.Add("Urla");
            }
            //Konya
            if (comboBox1.SelectedIndex == 6)
            {
                comboBox2.Text = ""; //ComboBox2 içini sifirliyor
                comboBox2.Items.Add("Ahirli");
                comboBox2.Items.Add("Akoren");
                comboBox2.Items.Add("Aksehir");
                comboBox2.Items.Add("Altinekin");
                comboBox2.Items.Add("Beysehir");
                comboBox2.Items.Add("Bozkir");
                comboBox2.Items.Add("Cihanbeyli");
                comboBox2.Items.Add("Celtik");
                comboBox2.Items.Add("Cumra");
                comboBox2.Items.Add("Derbent");
                comboBox2.Items.Add("Derebucak");
                comboBox2.Items.Add("Doganhisar");
                comboBox2.Items.Add("Emirgazi");
                comboBox2.Items.Add("Eregli");
                comboBox2.Items.Add("Guneysinir");
                comboBox2.Items.Add("Hadim");
                comboBox2.Items.Add("Halkapinar");
                comboBox2.Items.Add("Huyuk");
                comboBox2.Items.Add("Ilgin");
                comboBox2.Items.Add("Kadinhani");
                comboBox2.Items.Add("Karapinar");
                comboBox2.Items.Add("Karatay");
                comboBox2.Items.Add("Kulu");
                comboBox2.Items.Add("Meram");
                comboBox2.Items.Add("Sarayonu");
                comboBox2.Items.Add("Selcuklu");
                comboBox2.Items.Add("Seydisehir");
                comboBox2.Items.Add("Taskent");
                comboBox2.Items.Add("Tuzlukcu");
                comboBox2.Items.Add("Yalihuyuk");
                comboBox2.Items.Add("Yunak");
            }
            //Antalya
            if (comboBox1.SelectedIndex == 7)
            {
                comboBox2.Text = ""; //ComboBox2 içini sifirliyor
                comboBox2.Items.Add("Akseki");
                comboBox2.Items.Add("Aksu");
                comboBox2.Items.Add("Alanya");
                comboBox2.Items.Add("Demre");
                comboBox2.Items.Add("Dosemealti");
                comboBox2.Items.Add("Elmali");
                comboBox2.Items.Add("Finike");
                comboBox2.Items.Add("Gazipasa");
                comboBox2.Items.Add("Gündogmus");
                comboBox2.Items.Add("İbradi");
                comboBox2.Items.Add("Kas");
                comboBox2.Items.Add("Kemer");
                comboBox2.Items.Add("Kepez");
                comboBox2.Items.Add("Konyaalti");
                comboBox2.Items.Add("Korkuteli");
                comboBox2.Items.Add("Kumluca");
                comboBox2.Items.Add("Manavgat");
                comboBox2.Items.Add("Muratpasa");
                comboBox2.Items.Add("Serik");
            }
            //Samsun
            if (comboBox1.SelectedIndex == 8)
            {
                comboBox2.Text = ""; //ComboBox2 içini sifirliyor
                comboBox2.Items.Add("Alacam");
                comboBox2.Items.Add("Asarcik");
                comboBox2.Items.Add("Atakum");
                comboBox2.Items.Add("Ayvacik");
                comboBox2.Items.Add("Bafra");
                comboBox2.Items.Add("Canik");
                comboBox2.Items.Add("Carsamba");
                comboBox2.Items.Add("Havza");
                comboBox2.Items.Add("İlkadim");
                comboBox2.Items.Add("Kavak");
                comboBox2.Items.Add("Ladik");
                comboBox2.Items.Add("Salipazari");
                comboBox2.Items.Add("Tekkekoy");
                comboBox2.Items.Add("Terme");
                comboBox2.Items.Add("Vezirkopru");
                comboBox2.Items.Add("Yakakent");
            }
            //Eskişehir
            if (comboBox1.SelectedIndex == 9)
            {
                comboBox2.Text = ""; //ComboBox2 içini sifirliyor
                comboBox2.Items.Add("Alpu");
                comboBox2.Items.Add("Beylikova");
                comboBox2.Items.Add("Cifteler");
                comboBox2.Items.Add("Gunyuzu");
                comboBox2.Items.Add("Han");
                comboBox2.Items.Add("İnonu");
                comboBox2.Items.Add("Mahmudiye");
                comboBox2.Items.Add("Mihalgazi");
                comboBox2.Items.Add("Mihalccik");
                comboBox2.Items.Add("Odunpazari");
                comboBox2.Items.Add("Saricakaya");
                comboBox2.Items.Add("Seyitgazi");
                comboBox2.Items.Add("Sivrihisar");
                comboBox2.Items.Add("Tepebasi");
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //İlçe Verisi Değişince Listboxlari temizleme
            EczaneAdi.Items.Clear();
            EczaneAdres.Items.Clear();
            EczaneTelefon.Items.Clear();
            EczaneAdi.Visible = false;
            EczaneAdres.Visible = false;
            EczaneTelefon.Visible = false;
        }

        //Tarih ve Saat Kodlari
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            tarih.Text = DateTime.Now.ToShortDateString();//Tarih
            saat.Text = DateTime.Now.ToLongTimeString();//Saat
        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Birol TOPAL" + "\n" + "github.com/biroll" + "\n" + "instagram.com/birolltopall", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                //Ayni il ve ilçeyi seçilirse lisboxlarda temiz görünüm için eski bilgileri temizleme
                EczaneAdi.Items.Clear();
                EczaneAdres.Items.Clear();
                EczaneTelefon.Items.Clear();
                //Kullanýcýdan Alinan İl Ýlceyi String Deðere Atama
                string sehir = SehirComboBox.SelectedItem.ToString();
                string ilce = IlceComboBox.SelectedItem.ToString();
                string link = "&county=";
                var url = "https://www.nosyapi.com/apiv2/pharmacy?city=" + sehir + link + ilce;

                //API SORGU
                var httpRequest = (HttpWebRequest)WebRequest.Create(url);
                httpRequest.Headers["Authorization"] = "API_KEY";
                httpRequest.Headers["content-type"] = "application/json";
                var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {

                    string sonuc = streamReader.ReadToEnd();
                    Data JsonResponse = JsonConvert.DeserializeObject<Data>(sonuc);
                    JObject Parser = JObject.Parse(sonuc);
                    var s1 = Parser.Value<JArray>("data").Values<string>("EczaneAdi").ToArray();
                    var s2 = Parser.Value<JArray>("data").Values<string>("Adresi").ToArray();
                    var s3 = Parser.Value<JArray>("data").Values<string>("Telefon").ToArray();
                    foreach (var item in s1)
                    {
                        EczaneAdi.Items.Add(item);
                    }
                    foreach (var item2 in s2)
                    {
                        EczaneAdres.Items.Add(item2);

                    }
                    foreach (var item3 in s3)
                    {
                        EczaneTelefon.Items.Add(item3);
                    }
                    if (EczaneAdi.Items.Count >= 1)
                    {
                        EczaneAdi.Visible = true;
                        EczaneAdres.Visible = true;
                        EczaneTelefon.Visible = true;

                    }
                    if (EczaneAdi.Items.Count == 0)
                    {
                        EczaneAdi.Visible = false;
                        EczaneAdres.Visible = false;
                        EczaneTelefon.Visible = false;
                        MessageBox.Show("Seçilen İl ve İlçeye Göre Nöbetçi Eczane Bulunamadı", "Bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Bir Hata İle Karşılaşıldı Lütfen Tekrar Deneyiniz", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
