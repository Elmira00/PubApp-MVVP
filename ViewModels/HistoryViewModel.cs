using PubApp_WPF8.Models;
using PubApp_WPF8.Views.UserControls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace PubApp_WPF8.ViewModels
{
    public class HistoryViewModel:BaseViewModel
    {
        private List<Beer> myPurchasedBeers;

        public WrapPanel WrapPanel { get; set; }
        public List<Beer> MyPurchasedBeers
        {
            get { return myPurchasedBeers; }
            set { myPurchasedBeers = value;  }
        }
        public HistoryViewModel(WrapPanel wrapPanel, List<Beer> paramPurchasedBeers)
        {
            MyPurchasedBeers = paramPurchasedBeers;
            WrapPanel = wrapPanel;
            foreach (var item in MyPurchasedBeers)
            {
                var vm = new HistoryUCViewModel(item);
                var uc = new HistoryUC();
                uc.DataContext = vm;
                WrapPanel.Children.Add(uc);
            }
        }
    }
}
