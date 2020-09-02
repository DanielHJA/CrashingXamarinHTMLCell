using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DifferentJSONObjects;
using Xamarin.Forms;

namespace HTMLCellProject
{
    public partial class MainPage : ContentPage
    {

        MainPageViewModel Model = new MainPageViewModel();

        public MainPage()
        {
            InitializeComponent();
            BindingContext = Model;
            Model.FetchJSON();
        }
    }
}
