using ejercicio22_2p.Model;
using ejercicio22_2p.Controller;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace ejercicio22_2p
{
    public partial class App : Application
    {
        static Database database;

        public static Database BaseDatos
        {
            get
            {
                if (database == null)
                {
                    database = new Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "PM02SignatureApp.db3"));
                }

                return database;
            }


        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
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
