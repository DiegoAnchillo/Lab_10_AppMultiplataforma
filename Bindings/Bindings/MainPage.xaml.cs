using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Bindings
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            ViewToViewDemo.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ViewToViewDemo());
            };
            BindingModeDemo.Clicked += async (sender, e) => {
                await Navigation.PushAsync(new BindingModeDemo());
            };
            ListViewDemo.Clicked += async (sender, e) => {
                await Navigation.PushAsync(new ListViewDemo());
            };
            PickerDemo.Clicked += async (sender, e) => {
                await Navigation.PushAsync(new PickerDemo());
            };
        }
    }
}
