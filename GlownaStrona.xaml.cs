using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Gielda_Samochodowa
{
    /// <summary>
    /// Logika interakcji dla klasy GlownaStrona.xaml
    /// </summary>
    /// 
    public partial class GlownaStrona : Window
    {
        public List<Model> ListaSamochodow { get; private set; }
        public GlownaStrona()
        {
            InitializeComponent();
        }

        public void incjujSamochody()
        {
            ListaSamochodow = new List<Model>();

            Model samochod1 = new Model("Opel", "Corsa", 2016, "Szary", 220, );
        }
    }
}
