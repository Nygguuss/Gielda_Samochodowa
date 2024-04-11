using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Controls;
using System.Windows.Media.Imaging;


namespace Gielda_Samochodowa
{
    public class Model
    {
        public string Marka { get; set; }
        public string ModelSamochodu { get; set; }
        public int RokProdukcji { get; set; }
        public string Kolor { get; set; }
        public double PredkoscMaksymalna { get; set; }
        public Image Zdjecie { get; set; }


        public Model(string marka, string modelS, int rokProdukcji, string kolor, double predkosc, string sciezkaDoZdjecia)
        {
            Marka = marka;
            ModelSamochodu = modelS;
            RokProdukcji = rokProdukcji;
            Kolor = kolor;
            PredkoscMaksymalna = predkosc;

            if(!string.IsNullOrEmpty(sciezkaDoZdjecia))
            {
                //TODO
                Zdjecie = new BitmapImage(new Uri(sciezkaDoZdjecia));
            }
            else
            {
                Zdjecie = null; // Jeśli ścieżka jest pusta, ustawiamy obrazek na null
            }
        }

        public string Informacje()
        {
            return $"Marka: {Marka}, Model: {ModelSamochodu}, Rok produkcji: {RokProdukcji}, Kolor: {Kolor}, Prędkość: {PredkoscMaksymalna} km/h";
        }
    }
}
