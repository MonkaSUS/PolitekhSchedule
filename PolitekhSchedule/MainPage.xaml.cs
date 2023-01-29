using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PolitekhSchedule
{
    public partial class MainPage : ContentPage
    {
        CultureInfo culture = new CultureInfo("ru-RU"); //пока что используется только для работы дат, может пригодится в будущем.
        public MainPage()
        {
            InitializeComponent();
            SetTodayDate();
            
        }

        private void SetTodayDate()
        {
            
            var todayname = culture.DateTimeFormat.GetDayName(DateTime.Today.DayOfWeek); //культурно-ориентированное получение дня недели
            var output = char.ToUpper(todayname[0]) + todayname.Substring(1); // воскресенье -> Воскресенье            
            WeekDay.Text = Convert.ToString(output);
            LabelDate.Text = DateTime.Today.ToString(culture.DateTimeFormat.ShortDatePattern);  
                }

        private void SkipButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}
