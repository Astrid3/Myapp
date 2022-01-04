using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Myapp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [Obsolete]
    public partial class MainMasterDetailPage : MasterDetailPage
    {
        public MainMasterDetailPage()
        {
            InitializeComponent();
            navigationDrawerList.ItemsSource = GetMasterPageLists();
        }

        private void OnMenuSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (MasterPageList)e.SelectedItem;

            switch (item.Title)
            {
                case "Setting":
                    Detail.Navigation.PushAsync(new SettingPage());
                    IsPresented = false;


                    break;
                case "Envoi de fichiers":
                    Detail = new NavigationPage(new SendPage());
                    IsPresented = false;

                    break;

                case "Reception de fichiers":
                    Detail = new NavigationPage(new ReceivPage());
                    IsPresented = false;

                    break;
                case "Extracteurs de fichiers":
                    Detail = new NavigationPage(new ExtractPage());
                    IsPresented = false;
                    break;
                case "Stockage du téléphone":
                    Detail = new NavigationPage(new ExtractPage());
                    IsPresented = false;
                    break;
                case "Planification de sauvegarde":
                    Detail = new NavigationPage(new SchedulePage());
                    IsPresented = false;
                    break;
                case"A propos":
                     Detail.Navigation.PushAsync(new InfoAppPage());
                    IsPresented = false;
                    break;
                default:

                    Application.Current.Properties["MenuName"] = item.Title;
                    Detail = new NavigationPage(new AccueilTabbedPage());
                    IsPresented = false;
                    break;
            }
            
            /* if (item.Title == "Setting")
            {
                Detail.Navigation.PushAsync(new SettingPage());
                IsPresented = false;
            }*/
            /*else
            {
                Application.Current.Properties["MenuName"] = item.Title;
                Detail = new NavigationPage(new AccueilTabbedPage());
                IsPresented = false;
            }*/
        }
        List<MasterPageList> GetMasterPageLists()
        {
            return new List<MasterPageList>
            {
                new MasterPageList() { Title = "Envoi de fichiers", Icon = "send.png" },
                new MasterPageList() { Title = "Reception de fichiers", Icon = "receive.png" },
                 new MasterPageList() { Title = "Extracteurs de fichiers", Icon = "admin.png" },
                 
                new MasterPageList() { Title = "Setting", Icon = "setting.png" },
                new MasterPageList() { Title = "Stockage du téléphone", Icon = "storage.png" },
                new MasterPageList() { Title = "Planification de sauvegarde", Icon = "clock.png" },
                 new MasterPageList() { Title = "A propos", Icon = "info.png" }

            };
        }
    }

    //This class used for binding ListView. We can move it to other separate files as well   
    public class MasterPageList
    {
        public string Title { get; set; }
        public string Icon { get; set; }
    }
}  
        

    
