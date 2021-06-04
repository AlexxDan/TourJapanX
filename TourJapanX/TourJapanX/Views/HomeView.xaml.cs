using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourJapanX.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TourJapanX.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeView : ContentPage
    {
        public HomeView()
        {
            InitializeComponent();
            ObservableCollection<Foto> carusel = new ObservableCollection<Foto>();

            Foto foto1 = new Foto()
            {
                IdFoto=45,
                NombreFoto= "https://bucket-tourjapan-ans.s3.amazonaws.com/place/Parque_Hitachi_Japon2.jpg",
                idLugar=20
            };

            carusel.Add(foto1);

            Foto foto2 = new Foto()
            {
                IdFoto = 41,
                NombreFoto = "https://bucket-tourjapan-ans.s3.amazonaws.com/place/Oze_Park.jpg",
                idLugar = 19
            };

            carusel.Add(foto2);
            
            Foto foto3 = new Foto()
            {
                IdFoto = 40,
                NombreFoto = "https://bucket-tourjapan-ans.s3.amazonaws.com/place/Castillo_de_Aizuwakamatsu2.jpg",
                idLugar = 18
            };

            carusel.Add(foto3);

            this.caruselhome.ItemsSource = carusel;
        }
    }
}