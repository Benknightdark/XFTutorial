using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
              Navigation.PushModalAsync(new MyPage1());
            // Navigation.PushAsync(new MyPag2("NewPage2Title"));
            //var myPage2 = new MyPag2();
            //myPage2.BindingContext = "NewPage2Title";
            //Navigation.PushAsync(myPage2);
        }
    }
}
