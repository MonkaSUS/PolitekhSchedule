using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PolitekhSchedule.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PolitekhSchedule
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SchedulePage : NavigationPage
    {
        public SchedulePage()
        {
            InitializeComponent();
            OpenFirstPage();
        }

        private async void OpenFirstPage()
        {
          await Navigation.PushAsync(new MainPage());
        }
    }
}