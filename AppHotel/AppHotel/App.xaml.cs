using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.Generic;

using System.Threading;
using System.Globalization;

using AppHotel.Model;
using AppHotel.View;


namespace AppHotel
{
    public partial class App : Application
    {
        public List<Suite> lista_suites = new List<Suite>
        {
            new Suite()
            {
               Descricao = "Ricos",
               DiariaAdulto = 150.0,
               DiariaCrianca = 75.0
            },
            new Suite()
            {
               Descricao = "Classe Média",
               DiariaAdulto = 130.0,
               DiariaCrianca = 65.0
            },
            new Suite()
            {
               Descricao = "Pobres",
               DiariaAdulto = 70.0,
               DiariaCrianca = 35.0
            }
        };
        public App()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");

            InitializeComponent();
            MainPage = new NavigationPage(new ContratacaoHospedagem());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
