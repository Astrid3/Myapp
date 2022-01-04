using Myapp.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Myapp
{
    public partial class App : Application
    {
        [Obsolete]
        public App()
        {
            InitializeComponent();

            MainPage = new MainMasterDetailPage();
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
