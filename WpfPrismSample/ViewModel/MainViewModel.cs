using Newtonsoft.Json;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Data;
using WpfPrismSample.Model;

namespace WpfPrismSample.ViewModel
{
    public class MainViewModel : BindableBase
    {
        private string _title = "hi";
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }
        private string _longText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
        public string LongText
        {
            get => _longText;
            set => SetProperty(ref _longText, value);
        }
        private string _alertText = "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
        public string AlertText
        {
            get => _alertText;
            set => SetProperty(ref _alertText, value);
        }
        private ObservableCollection<Coin> _coinCollection = new ObservableCollection<Coin>();
        public ObservableCollection<Coin> CoinCollection
        {
            get => _coinCollection;
            set => SetProperty(ref _coinCollection, value);
        }
        public ICollectionView CoinCollectionView { get; private set; }
        public DelegateCommand AscendingCommand { get; }
        public DelegateCommand DescendingCommand { get; }
        public MainViewModel()
        {
            Title = "WPF Style Samples";
            getJson();
            CoinCollectionView = CollectionViewSource.GetDefaultView(CoinCollection);           
            CoinCollectionView.SortDescriptions.Add(new SortDescription(nameof(Coin.Name), ListSortDirection.Descending));
            AscendingCommand = new DelegateCommand(AscendingExecute);
            DescendingCommand = new DelegateCommand(DescendingExecute);
        }

        private void DescendingExecute()
        {
            CoinCollectionView.SortDescriptions.Clear();
            CoinCollectionView.SortDescriptions.Add(new SortDescription(nameof(Coin.Name), ListSortDirection.Descending));
            CoinCollectionView.Refresh();
        }

        private void AscendingExecute()
        {
            CoinCollectionView.SortDescriptions.Clear();
            CoinCollectionView.SortDescriptions.Add(new SortDescription(nameof(Coin.Name), ListSortDirection.Ascending));
            CoinCollectionView.Refresh();
        }

        private void getJson()
        {

            var myDeserializedClass = JsonConvert.DeserializeObject<CoinRoot>(TestData.CoinJson);
            if (myDeserializedClass == null) return;
            CoinCollection.AddRange(myDeserializedClass.Data.Coins);            
        }
    }
}
