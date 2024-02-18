using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PubApp_WPF8.Models
{
    public class Beer:Entity,INotifyPropertyChanged
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double Volume { get; set; }
        public string Image { get; set; }
        private int count;

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
        public int Count
        {
            get { return count; }
            set { count = value; OnPropertyChanged(); }
        }

    }
}
