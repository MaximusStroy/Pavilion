using Pavilion.Model;
using Pavilion.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pavilion.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        private TabItem _selectedItemMain;
        public TabItem SelectesTabMain
        {
            get { return _selectedItemMain; }
            set { _selectedItemMain = value; OnPropertyChanged(nameof(SelectesTabMain)); }
        }

        public MainViewModel()
        {
            Tabs = new ObservableCollection<TabItem>();
            Tabs.Add(new TabItem { Header = "Торговые центры", Content = new ShopsCentersView() });
            /*Tabs.Add(new TabItem { Header = "Список услуг", Content = new ServiceView() });
            Tabs.Add(new TabItem { Header = "Склад запчастей", Content = new StorageView() });*/

            _selectedItemMain = Tabs.FirstOrDefault();
        }

        public ObservableCollection<TabItem> Tabs { get; set; }


        public string _title = $"{CurrentUser.surname} {CurrentUser.name} - {DateTime.Now}";
        public string Title { get { return _title; } set { _title = value; OnPropertyChanged(nameof(Title)); } }
    }

    public class TabItem
    {
        public string Header { get; set; }

        public object Content { get; set; }

    }
}
