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
            SehirComboBox.Items.Add("Bursa"); //Index 0
            SehirComboBox.Items.Add("Adana"); //Index 1
            SehirComboBox.Items.Add("Sakarya"); //Index 2
            SehirComboBox.Items.Add("Ýstanbul"); //Index 3
            SehirComboBox.Items.Add("Ankara"); //Index 4
            SehirComboBox.Items.Add("Ýzmir"); //Index 5
            SehirComboBox.Items.Add("Konya"); //Index 6
            SehirComboBox.Items.Add("Antalya"); //Index 7
            SehirComboBox.Items.Add("Samsun"); //Index 8
            SehirComboBox.Items.Add("Eskisehir"); //Index 9
            timer1.Start();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Ýl Verisi Deðiþince Listboxlarda ki verileri temizleme
            EczaneAdi.Items.Clear();
            EczaneAdres.Items.Clear();
            EczaneTelefon.Items.Clear();
            IlceComboBox.Items.Clear();
            EczaneAdi.Visible = false;
            EczaneAdres.Visible = false;
            EczaneTelefon.Visible = false;

            //Bursa
            if (SehirComboBox.SelectedIndex == 0)
            {
                IlceComboBox.Text = ""; //ComboBox2 içini sýfýrlýyor
                IlceComboBox.Items.Add("Buyukorhan");
                IlceComboBox.Items.Add("Gemlik");
                IlceComboBox.Items.Add("Gursu");
                IlceComboBox.Items.Add("Harmancik");
                IlceComboBox.Items.Add("Ýnegol");
                IlceComboBox.Items.Add("Ýznik");
                IlceComboBox.Items.Add("Karacabey");
                IlceComboBox.Items.Add("Keles");
                IlceComboBox.Items.Add("Kestel");
                IlceComboBox.Items.Add("Mudanya");
                IlceComboBox.Items.Add("Mustafakemalpasa");
                IlceComboBox.Items.Add("Nilufer");
                IlceComboBox.Items.Add("Orhaneli");
                IlceComboBox.Items.Add("Orhangazi");
                IlceComboBox.Items.Add("Osmangazi");
                IlceComboBox.Items.Add("Yenisehir");
                IlceComboBox.Items.Add("Yildirim");
            }
            //Adana
            if (SehirComboBox.SelectedIndex == 1)
            {
                IlceComboBox.Text = ""; //ComboBox2 içini sýfýrlýyor
                IlceComboBox.Items.Add("Aladag");
                IlceComboBox.Items.Add("Ceyhan");
                IlceComboBox.Items.Add("Cukurova");
                IlceComboBox.Items.Add("Feke");
                IlceComboBox.Items.Add("Karaisali");
                IlceComboBox.Items.Add("Karatas");
                IlceComboBox.Items.Add("Kozan");
                IlceComboBox.Items.Add("Pozantý");
                IlceComboBox.Items.Add("Saimbeyli");
                IlceComboBox.Items.Add("Saricam");
                IlceComboBox.Items.Add("Seyhan");
                IlceComboBox.Items.Add("Tufanbeyli");
                IlceComboBox.Items.Add("Yumurtalik");
                IlceComboBox.Items.Add("Yuregir");
            }
            //Sakarya
            if (SehirComboBox.SelectedIndex == 2)
            {
                IlceComboBox.Text = ""; //ComboBox2 içini sýfýrlýyor
                IlceComboBox.Items.Add("Adapazari");
                IlceComboBox.Items.Add("Akyazi");
                IlceComboBox.Items.Add("Arifiye");
                IlceComboBox.Items.Add("Erenler");
                IlceComboBox.Items.Add("Ferizli");
                IlceComboBox.Items.Add("Gevye");
                IlceComboBox.Items.Add("Hendek");
                IlceComboBox.Items.Add("Karapurcek");
                IlceComboBox.Items.Add("Karasu");
                IlceComboBox.Items.Add("Kaynarca");
                IlceComboBox.Items.Add("Kocaali");
                IlceComboBox.Items.Add("Pamukova");
                IlceComboBox.Items.Add("Sapanca");
                IlceComboBox.Items.Add("Serdivan");
                IlceComboBox.Items.Add("Sogutlu");
                IlceComboBox.Items.Add("Tarakli");
            }
            //Ýstanbul
            if (SehirComboBox.SelectedIndex == 3)
            {
                IlceComboBox.Text = ""; //ComboBox2 içini sýfýrlýyor
                IlceComboBox.Items.Add("Adalar");
                IlceComboBox.Items.Add("Arnavutkoy");
                IlceComboBox.Items.Add("Atasehir");
                IlceComboBox.Items.Add("Avcilar");
                IlceComboBox.Items.Add("Bagcilar");
                IlceComboBox.Items.Add("Bahcelievler");
                IlceComboBox.Items.Add("Bakirkoy");
                IlceComboBox.Items.Add("Basaksehir");
                IlceComboBox.Items.Add("Bayrampasa");
                IlceComboBox.Items.Add("Besiktas");
                IlceComboBox.Items.Add("Beykoz");
                IlceComboBox.Items.Add("Beylikduzu");
                IlceComboBox.Items.Add("Beyoglu");
                IlceComboBox.Items.Add("Buyukcekmece");
                IlceComboBox.Items.Add("Catalca");
                IlceComboBox.Items.Add("Cekmekoy");
                IlceComboBox.Items.Add("Esenler");
                IlceComboBox.Items.Add("Esenyurt");
                IlceComboBox.Items.Add("Eyup");
                IlceComboBox.Items.Add("Fatih");
                IlceComboBox.Items.Add("Gaziosmanpasa");
                IlceComboBox.Items.Add("Gungoren");
                IlceComboBox.Items.Add("Kadikoy");
                IlceComboBox.Items.Add("Kagithane");
                IlceComboBox.Items.Add("Kartal");
                IlceComboBox.Items.Add("Kucukcekmece");
                IlceComboBox.Items.Add("Maltepe");
                IlceComboBox.Items.Add("Pendik");
                IlceComboBox.Items.Add("Sancaktepe");
                IlceComboBox.Items.Add("Sariyer");
                IlceComboBox.Items.Add("Silivri");
                IlceComboBox.Items.Add("Sultanbeyli");
                IlceComboBox.Items.Add("Sultangazi");
                IlceComboBox.Items.Add("Sile");
                IlceComboBox.Items.Add("Sisli");
                IlceComboBox.Items.Add("Tuzla");
                IlceComboBox.Items.Add("Umraniye");
                IlceComboBox.Items.Add("Uskudar");
                IlceComboBox.Items.Add("Zeytinburnu");
            }
            //Ankara
            if (SehirComboBox.SelectedIndex == 4)
            {
                IlceComboBox.Text = ""; //ComboBox2 içini sýfýrlýyor
                IlceComboBox.Items.Add("Akyurt");
                IlceComboBox.Items.Add("Altindag");
                IlceComboBox.Items.Add("Ayas");
                IlceComboBox.Items.Add("Bala");
                IlceComboBox.Items.Add("Beypazari");
                IlceComboBox.Items.Add("Camlidere");
                IlceComboBox.Items.Add("Cankaya");
                IlceComboBox.Items.Add("Cubuk");
                IlceComboBox.Items.Add("Elmadag");
                IlceComboBox.Items.Add("Etimesgut");
                IlceComboBox.Items.Add("Evren");
                IlceComboBox.Items.Add("Golbasi");
                IlceComboBox.Items.Add("Gudul");
                IlceComboBox.Items.Add("Haymana");
                IlceComboBox.Items.Add("Kahramankazan");
                IlceComboBox.Items.Add("Kalecik");
                IlceComboBox.Items.Add("Kecioren");
                IlceComboBox.Items.Add("Kizilcahamam");
                IlceComboBox.Items.Add("Mamak");
                IlceComboBox.Items.Add("Nallihan");
                IlceComboBox.Items.Add("Polatli");
                IlceComboBox.Items.Add("Pursaklar");
                IlceComboBox.Items.Add("Sincan");
                IlceComboBox.Items.Add("Sereflikochisar");
                IlceComboBox.Items.Add("Yenimahalle");
            }
            //Ýzmir
            if (SehirComboBox.SelectedIndex == 5)
            {
                IlceComboBox.Text = ""; //ComboBox2 içini sýfýrlýyor
                IlceComboBox.Items.Add("Aliaga");
                IlceComboBox.Items.Add("Balcova");
                IlceComboBox.Items.Add("Bayindir");
                IlceComboBox.Items.Add("Bayrakli");
                IlceComboBox.Items.Add("Bergama");
                IlceComboBox.Items.Add("Beydag");
                IlceComboBox.Items.Add("Bornova");
                IlceComboBox.Items.Add("Buca");
                IlceComboBox.Items.Add("Cesme");
                IlceComboBox.Items.Add("Cigli");
                IlceComboBox.Items.Add("Dikili");
                IlceComboBox.Items.Add("Foca");
                IlceComboBox.Items.Add("Gaziemir");
                IlceComboBox.Items.Add("Guzelbahce");
                IlceComboBox.Items.Add("Karabaglar");
                IlceComboBox.Items.Add("Karaburun");
                IlceComboBox.Items.Add("Karsiyaka");
                IlceComboBox.Items.Add("Kemalpasa");
                IlceComboBox.Items.Add("Kinik");
                IlceComboBox.Items.Add("Kiraz");
                IlceComboBox.Items.Add("Konak");
                IlceComboBox.Items.Add("Menderes");
                IlceComboBox.Items.Add("Menemen");
                IlceComboBox.Items.Add("Narlidere");
                IlceComboBox.Items.Add("Odemis");
                IlceComboBox.Items.Add("Seferihisar");
                IlceComboBox.Items.Add("Selcuk");
                IlceComboBox.Items.Add("Tire");
                IlceComboBox.Items.Add("Torbali");
                IlceComboBox.Items.Add("Urla");
            }
            //Konya
            if (SehirComboBox.SelectedIndex == 6)
            {
                IlceComboBox.Text = ""; //ComboBox2 içini sýfýrlýyor
                IlceComboBox.Items.Add("Ahirli");
                IlceComboBox.Items.Add("Akoren");
                IlceComboBox.Items.Add("Aksehir");
                IlceComboBox.Items.Add("Altinekin");
                IlceComboBox.Items.Add("Beysehir");
                IlceComboBox.Items.Add("Bozkir");
                IlceComboBox.Items.Add("Cihanbeyli");
                IlceComboBox.Items.Add("Celtik");
                IlceComboBox.Items.Add("Cumra");
                IlceComboBox.Items.Add("Derbent");
                IlceComboBox.Items.Add("Derebucak");
                IlceComboBox.Items.Add("Doganhisar");
                IlceComboBox.Items.Add("Emirgazi");
                IlceComboBox.Items.Add("Eregli");
                IlceComboBox.Items.Add("Guneysinir");
                IlceComboBox.Items.Add("Hadim");
                IlceComboBox.Items.Add("Halkapinar");
                IlceComboBox.Items.Add("Huyuk");
                IlceComboBox.Items.Add("Ilgin");
                IlceComboBox.Items.Add("Kadinhani");
                IlceComboBox.Items.Add("Karapinar");
                IlceComboBox.Items.Add("Karatay");
                IlceComboBox.Items.Add("Kulu");
                IlceComboBox.Items.Add("Meram");
                IlceComboBox.Items.Add("Sarayonu");
                IlceComboBox.Items.Add("Selcuklu");
                IlceComboBox.Items.Add("Seydisehir");
                IlceComboBox.Items.Add("Taskent");
                IlceComboBox.Items.Add("Tuzlukcu");
                IlceComboBox.Items.Add("Yalihuyuk");
                IlceComboBox.Items.Add("Yunak");
            }
            //Antalya
            if (SehirComboBox.SelectedIndex == 7)
            {
                IlceComboBox.Text = ""; //ComboBox2 içini sýfýrlýyor
                IlceComboBox.Items.Add("Akseki");
                IlceComboBox.Items.Add("Aksu");
                IlceComboBox.Items.Add("Alanya");
                IlceComboBox.Items.Add("Demre");
                IlceComboBox.Items.Add("Dosemealti");
                IlceComboBox.Items.Add("Elmali");
                IlceComboBox.Items.Add("Finike");
                IlceComboBox.Items.Add("Gazipasa");
                IlceComboBox.Items.Add("Gündogmus");
                IlceComboBox.Items.Add("Ýbradi");
                IlceComboBox.Items.Add("Kas");
                IlceComboBox.Items.Add("Kemer");
                IlceComboBox.Items.Add("Kepez");
                IlceComboBox.Items.Add("Konyaalti");
                IlceComboBox.Items.Add("Korkuteli");
                IlceComboBox.Items.Add("Kumluca");
                IlceComboBox.Items.Add("Manavgat");
                IlceComboBox.Items.Add("Muratpasa");
                IlceComboBox.Items.Add("Serik");
            }
            //Samsun
            if (SehirComboBox.SelectedIndex == 8)
            {
                IlceComboBox.Text = ""; //ComboBox2 içini sýfýrlýyor
                IlceComboBox.Items.Add("Alacam");
                IlceComboBox.Items.Add("Asarcik");
                IlceComboBox.Items.Add("Atakum");
                IlceComboBox.Items.Add("Ayvacik");
                IlceComboBox.Items.Add("Bafra");
                IlceComboBox.Items.Add("Canik");
                IlceComboBox.Items.Add("Carsamba");
                IlceComboBox.Items.Add("Havza");
                IlceComboBox.Items.Add("Ýlkadim");
                IlceComboBox.Items.Add("Kavak");
                IlceComboBox.Items.Add("Ladik");
                IlceComboBox.Items.Add("Salipazari");
                IlceComboBox.Items.Add("Tekkekoy");
                IlceComboBox.Items.Add("Terme");
                IlceComboBox.Items.Add("Vezirkopru");
                IlceComboBox.Items.Add("Yakakent");
            }
            //Eskiþehir
            if (SehirComboBox.SelectedIndex == 9)
            {
                IlceComboBox.Text = ""; //ComboBox2 içini sýfýrlýyor
                IlceComboBox.Items.Add("Alpu");
                IlceComboBox.Items.Add("Beylikova");
                IlceComboBox.Items.Add("Cifteler");
                IlceComboBox.Items.Add("Gunyuzu");
                IlceComboBox.Items.Add("Han");
                IlceComboBox.Items.Add("Ýnonu");
                IlceComboBox.Items.Add("Mahmudiye");
                IlceComboBox.Items.Add("Mihalgazi");
                IlceComboBox.Items.Add("Mihalccik");
                IlceComboBox.Items.Add("Odunpazari");
                IlceComboBox.Items.Add("Saricakaya");
                IlceComboBox.Items.Add("Seyitgazi");
                IlceComboBox.Items.Add("Sivrihisar");
                IlceComboBox.Items.Add("Tepebasi");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Ýlçe Verisi Deðiþince Listboxlarý temizleme
            EczaneAdi.Items.Clear();
            EczaneAdres.Items.Clear();
            EczaneTelefon.Items.Clear();
            EczaneAdi.Visible = false;
            EczaneAdres.Visible = false;
            EczaneTelefon.Visible = false;
        }

        //Tarih ve Saat Kodlarý
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            tarih.Text = DateTime.Now.ToShortDateString();//Tarih
            saat.Text = DateTime.Now.ToLongTimeString();//Saat
        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Birol TOPAL G212102048" + "\n" + "github.com/biroll" + "\n" + "instagram.com/birolltopall", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                //Ayný il ve ilçeyi seçilirse lisboxlarda temiz görünüm için eski bilgileri temizleme
                EczaneAdi.Items.Clear();
                EczaneAdres.Items.Clear();
                EczaneTelefon.Items.Clear();
                //Kullanýcýdan Alýnan Ýl Ýlceyi String Deðere Atama
                string sehir = SehirComboBox.SelectedItem.ToString();
                string ilce = IlceComboBox.SelectedItem.ToString();
                string link = "&county=";
                var url = "https://www.nosyapi.com/apiv2/pharmacy?city=" + sehir + link + ilce;

                //API SORGU
                var httpRequest = (HttpWebRequest)WebRequest.Create(url);
                httpRequest.Headers["Authorization"] = "UlHmiJGAxGw7FGXGHHWkUfLK5WCmJSwq3bf8QiGqONS6q5OnbgSbWmtWfgE0";
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
                        MessageBox.Show("Seçilen Ýl ve Ýlçeye Göre Nöbetçi Eczane Bulunamadý", "Bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Bir Hata Ýle Karþýlaþýldý Lütfen Tekrar Deneyiniz", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}