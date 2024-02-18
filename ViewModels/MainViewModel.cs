using Microsoft.Expression.Interactivity.Media;
using PubApp_WPF8.Commands;
using PubApp_WPF8.FakeRepositories;
using PubApp_WPF8.Models;
using PubApp_WPF8.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace PubApp_WPF8.ViewModels
{
    public class MainViewModel:BaseViewModel
    {
        public FakeRepo BeerRepository{ get; set; }
		private ObservableCollection<Beer> allBeers;

		public ObservableCollection<Beer> AllBeers
        {
			get { return allBeers; }
			set { allBeers = value; OnPropertyChanged(); }
		}
		private List<Beer> purchasedBeers;

		public List<Beer> PurchasedBeers
        {
			get { return purchasedBeers; }
			set { purchasedBeers = value; OnPropertyChanged(); }
		}

		private Beer beer;

		public Beer Beer
		{
			get { return beer; }
			set { beer = value; OnPropertyChanged(); }
		}

		public RelayCommand SelectedCommand { get; set; }
		public RelayCommand MinusCommand { get; set; }
		public RelayCommand PlusCommand { get; set; }
		public RelayCommand BuyCommand { get; set; }
		public RelayCommand ShowHistoryCommand { get; set; }
		public MainViewModel()
		{
			BeerRepository = new FakeRepo();
			AllBeers = new ObservableCollection<Beer>(BeerRepository.GetAll());
			Beer = new Beer();//acilanda null exception atmaginin ehtimali ola biler burda qarshisini aliriq
			PurchasedBeers = new List<Beer>();
			SelectedCommand = new RelayCommand((obj) => {
				var item = obj as Beer;
				Beer = item;
			}	);

			MinusCommand = new RelayCommand((obj)=>
		    {
                var selectedBeer = obj as Beer;
                foreach (var item in AllBeers)
                {
                    if (selectedBeer.Name == item.Name && item.Count>0)
                    {
                        item.Count--;
                        break;
                    }
                }
            });
		
            PlusCommand = new RelayCommand((obj)=>
		    {
                var selectedBeer = obj as Beer;
				foreach (var item in AllBeers)
				{
					if (selectedBeer.Name==item.Name)
					{
						item.Count++;
						
						break;
					}
				}
            });

			BuyCommand = new RelayCommand((obj) => {
                var selectedBeer = obj as Beer;
				PurchasedBeers.Add(selectedBeer);
                MessageBox.Show(selectedBeer.Name+"  was bought ");
            });

			ShowHistoryCommand = new RelayCommand((obj) => {
				HistoryWindow window = new HistoryWindow();
				HistoryViewModel vm = new HistoryViewModel(window.myWrapPanel, PurchasedBeers);
				window.DataContext = vm;
				window.ShowDialog();
            });


		}
	}
}
