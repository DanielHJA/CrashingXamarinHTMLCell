using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using DifferentJSONObjects.Objects;
using Xamarin.Forms;

namespace DifferentJSONObjects
{
    public class MainPageViewModel: BindableObject, INotifyPropertyChanged
    {

        public ObservableCollection<HTMLObject> Objects { get; private set; } = new ObservableCollection<HTMLObject>();

        public MainPageViewModel()
        {
            FetchJSON();
        }

        public void FetchJSON()
        {

            for (int ndx = 0; ndx < 10; ndx++)
            {
                HTMLObject obj = new HTMLObject("<p style='color:#B22222'>Color text and <span style='color:limegreen;'>another color</span>, and now back to the same. Oh, and here's a <span style='background-color:PaleGreen;'>different background color</span> just in case you need it!</p>");
                Objects.Add(obj);
            }

            OnPropertyChanged("Objects");
        }
    }
}