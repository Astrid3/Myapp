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
    public partial class AccueilTabbedPage : TabbedPage
    {
        public AccueilTabbedPage()
        {
            InitializeComponent();
            if (Application.Current.Properties.ContainsKey("MenuName"))
            {
                var menuName = Application.Current.Properties["MenuName"].ToString();
                
                {
                    this.CurrentPage = Children[0];
                }
            }
        }
    }
}