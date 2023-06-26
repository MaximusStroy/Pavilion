using Pavilion.Model;
using Pavilion.Model.Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pavilion.ViewModel
{
    public class ShopsCenterViewModel : BaseViewModel
    {
        private ShopCenterRepository _repository;

        public ShopsCenterViewModel()
        {
            _repository = new ShopCenterRepository();
            Shops = new ObservableCollection<shops_centers>(_repository.GetMany().ToList());
        }

        private ObservableCollection<shops_centers> _shops;
        public ObservableCollection<shops_centers> Shops
        {
            get { return _shops; }
            set { _shops = value; OnPropertyChanged(nameof(Shops)); }
        }
    }
}
