using PubApp_WPF8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubApp_WPF8.ViewModels
{
    public class HistoryUCViewModel:BaseViewModel
    {
		private Beer beer;

		public Beer Beer
		{
			get { return beer; }
			set { beer = value;OnPropertyChanged(); }
		}
		public HistoryUCViewModel(Beer paramBeer)
		{
			Beer = paramBeer;
		}
	}
}
