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
    public partial class ProductosIU : ContentPage
    {
        private string url = App.GlobalUrl + "/products-list/";

        private HttpClient Client = new HttpClient();
        public ProductosIU()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            string content = await Client.GetStringAsync(url);
            string categoryContent = await Client.GetStringAsync(App.GlobalUrl + "/categories/");

            IEnumerable<Category> categories = JsonConvert.DeserializeObject<IEnumerable<Category>>(categoryContent);
            CollectionViewCategory.ItemsSource = new ObservableCollection<Category>(categories);

            IEnumerable<Product> productList = JsonConvert.DeserializeObject<IEnumerable<Product>>(content);
            LVproducts.ItemsSource = new ObservableCollection<Product>(productList);

            base.OnAppearing();
        }
    }
}