using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ProyectoFinal.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoFinal.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchIU : ContentPage
    {
        private string url = App.GlobalUrl + "/products-list/";

        private HttpClient Client = new HttpClient();


        public SearchIU()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            string contenido = await Client.GetStringAsync(url);

            IEnumerable<Product> searchList = JsonConvert.DeserializeObject<IEnumerable<Product>>(contenido);
            LVproducts.ItemsSource = new ObservableCollection<Product>(searchList);

            base.OnAppearing();
        }

        private async void InputView_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            string content = await Client.GetStringAsync(url);
            IEnumerable<Product> listProducts=JsonConvert.DeserializeObject<IEnumerable<Product>>(content);
            LVproducts.ItemsSource = listProducts.Where(s => s.name.StartsWith(e.NewTextValue.ToUpper()));
        }
       
        
    }
}