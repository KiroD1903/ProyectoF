using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ProyectoFinal.Models;
using ProyectoFinal.views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoFinal
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginIU : ContentPage
    {
        private HttpClient Client = new HttpClient();
        public LoginIU()
        {
            InitializeComponent();
        }

        private async void Login_Clicked(object sender, EventArgs e)
        {
            Login login = new Login
            {
                username = txt_user.Text,
                password = txt_pass.Text
            };
            Uri requestUri = new Uri(App.GlobalUrl+"/login/");

            string jsonSerilizer = JsonConvert.SerializeObject(login);
            
            var contentJson = new StringContent(jsonSerilizer, Encoding.UTF8, "application/json");

            var response = await Client.PostAsync(requestUri, contentJson);

            var result = await response.Content.ReadAsStringAsync();

            IndivResult res = new IndivResult();

            res = JsonConvert.DeserializeObject<IndivResult>(result);

           
            
            if (res.result == "access")
            {
                await DisplayAlert("Acceso Concedido", res.result, "OK!");
                await Navigation.PushModalAsync(new MainPage());
            }
            else
            {
                await DisplayAlert("Acceso Denegado", "Usuario o Contraseña Erroneos", "OK!");
                txt_pass.Text = "";
                txt_user.Text = "";
            }
            
        }

        private async void Register_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegisterIU());
        }

        private void LoginG_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Iniciar con Google", "Iniciando sesion con Google...", "OK!");
        }

        private void LoginT_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Iniciar con Twitter", "Iniciando sesion con Twitter...", "OK!");
        }

        private void LoginF_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Iniciar con Facebook", "Iniciando sesion con Facebook...", "OK!");
        }
    }
}
