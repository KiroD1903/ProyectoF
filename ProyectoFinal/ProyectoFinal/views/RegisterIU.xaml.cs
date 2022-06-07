using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoFinal
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterIU : ContentPage
    {
        public RegisterIU()
        {
            InitializeComponent();
        }

        private async void Btn_register_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}