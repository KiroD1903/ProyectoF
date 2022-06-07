using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ProyectoFinal.Models;
using ProyectoFinal.views;
using Xamarin.Forms;

namespace ProyectoFinal
{
    public partial class MainPage : FlyoutPage
    {
       
        public MainPage()
        {
            InitializeComponent();
            Flyout = new LateralMenu();
            Detail = new NavigationPage(new HomeIU());
        }


    }
}