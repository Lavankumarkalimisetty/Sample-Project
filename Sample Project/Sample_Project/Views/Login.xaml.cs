using Sample_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sample_Project.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        CommonClass _commonClass = new CommonClass();
        public Login()
        {
            InitializeComponent();
            
            TbName.Text = "Lavan";
            TbPassword.Text = "Lavan@123";

        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            BtnSubmit.Clicked += BtnSubmit_Clicked;
        }

        private void BtnSubmit_Clicked(object sender, EventArgs e)
        {
            if (_commonClass.NetworkConnection()==true)
            {
                if(TbName.Text!="Lavan"&&TbPassword.Text!="Lavan@123")
                {
                    DisplayAlert("Error", "Please Enter valid Details", "Ok");
                }
                else
                {
                    Navigation.PushAsync(new ItemsPage(),false);
                }
            }
            else
            {
                DisplayAlert("","Please Check Ur Network","Ok");
            }
            
        }
    }
}
