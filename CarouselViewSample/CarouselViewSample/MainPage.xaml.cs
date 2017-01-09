using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CarouselViewSample
{
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        public MainPage()
        {
            InitializeComponent();

            // An Example DataSource
            MyDataSource = new List<CarouselData>()
            {
                new CarouselData() {Name = "Title1"},
                new CarouselData() {Name = "Title2"},
                new CarouselData() {Name = "Title3"},
                new CarouselData() {Name = "Title4"}
            };

            BindingContext = this;
        }


        public List<CarouselData> MyDataSource { get; set; } // Must have default value or be set before the BindingContext is set.
    }
}