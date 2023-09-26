using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace InglesCriancas
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btCores_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageCores());
        }

        private void btNumeros_Clicked(object sender, EventArgs e)
        {

        }

        private void btFamilia_Clicked(object sender, EventArgs e)
        {

        }

        private void btSair_Clicked(object sender, EventArgs e)
        {

        }
    }
}
