using Etterem;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Etterem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public class Menuk
    {
        public String adag { get; set; }
        public String leves { get; set; }
        public String foetel { get; set; }
        public String desszert { get; set; }
        public String italok { get; set; }
        public Menuk(string adag,string leves,string foetel,string desszert,string italok)
        {
            this.adag = adag;
            this.leves = leves;
            this.foetel = foetel;
            this.desszert = desszert;
            this.italok = italok;
        }
        
    }
    public class Arak
    {
        public String adag { get; set; }
        public String leves { get; set; }
        public String foetel { get; set; }
        public String desszert { get; set; }
        public String italok { get; set; }
        public Arak(string adag, string leves, string foetel, string desszert, string italok)
        {
            this.adag = adag;
            this.leves = leves;
            this.foetel = foetel;
            this.desszert = desszert;
            this.italok = italok;
        }

    }
    public partial class MainWindow : Window
    {
        List<Menuk> menuk = new List<Menuk>();
        List<Arak> arak = new List<Arak>();
        public MainWindow()
        {
            InitializeComponent();
            menuk.Add(new Menuk("kisadag","Babgulyás", "Finomfőzelék", "sajtospogácsa","Pepsi"));
            talca.ItemsSource = menuk;
            arak.Add(new Arak("Kisadag-400ft,Közepesadag-450ft,Nagyadag-550ft", "Levesek-800ft", "Főmenük-1000ft", "Desszertek-600ft", "Italok-300ft"));
            arakft.ItemsSource = arak;
        }
        private void kilepes(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void torles(object sender, RoutedEventArgs e)
        {
            if (talca.SelectedItem != null && talca.SelectedItem is Menuk)
            {
                menuk.Remove((Menuk)talca.SelectedItem);
                talca.Items.Refresh();
            }
        }
        private void hozzadas(object sender, RoutedEventArgs e)
        {
            if (comboadag.Text == "" && comboItalok.Text != "")
            {
                menuk.Add(new Menuk(comboadag.Text, comboSoups.Text, comboMainMenus.Text, comboDeserts.Text, comboItalok.Text));
                talca.Items.Refresh();
            }
            else if (comboadag.Text == "" && comboItalok.Text == "")
            {
                talca.Items.Refresh();
            }
            else
            {
                menuk.Add(new Menuk(comboadag.Text, comboSoups.Text, comboMainMenus.Text, comboDeserts.Text, comboItalok.Text));
                talca.Items.Refresh();
            }
        }
    }
}