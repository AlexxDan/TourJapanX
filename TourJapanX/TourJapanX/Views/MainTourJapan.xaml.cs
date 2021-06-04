using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourJapanX.Code;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TourJapanX.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainTourJapan : MasterDetailPage
    {
        public MainTourJapan()
        {
            InitializeComponent();
            ObservableCollection<MasterPageItem> menu = new ObservableCollection<MasterPageItem>();


            MasterPageItem lugarscroll = new MasterPageItem
            {
                Titulo = "Lista lugares",
                Tipo = typeof(LugarScroll),
                Icono = "lista.png"
            };
            menu.Add(lugarscroll);

            MasterPageItem perfecturas = new MasterPageItem
            {
                Titulo = "Buscar por Perfecturas",
                Tipo = typeof(PerfecturaLugarView),
                Icono = "perfectura2.png"
            };
            menu.Add(perfecturas);
            MasterPageItem perfil = new MasterPageItem
            {
                Titulo = "Mi Perfil",
                Tipo = typeof(PerfilView),
                Icono = "user.png"
            };
            menu.Add(perfil);
            this.listviewMenu.ItemsSource = menu;
            Detail = new NavigationPage((Page)
    Activator.CreateInstance(typeof(HomeView)));
            this.listviewMenu.ItemSelected += ListviewMenu_ItemSelected;
        }

        private async void ListviewMenu_ItemSelected(object sender
            , SelectedItemChangedEventArgs e)
        {
            var item = (MasterPageItem)e.SelectedItem;
            var tipo = item.Tipo;
            if (App.ServiceLocator.SessionService.UserSession.IdUser == 0 && tipo == typeof(PerfilView))
            {
                await Navigation.PushModalAsync(new LoginView());
               
            }

            Detail = new NavigationPage((Page)Activator.CreateInstance(tipo));
            IsPresented = false;



        }
    }
}