using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    public class ApplicationViewModel : BaseViewModel
    {
        private Phone selectedPhone;

        public ObservableCollection<Phone> Phones { get; set; }
        public ApplicationViewModel()
        {
            Phones = new ObservableCollection<Phone>
            {
                new Phone {Title="iPhone 7", Company="Apple", Price=56000 },
                new Phone {Title="Galaxy S7 Edge", Company="Samsung", Price =60000 },
                new Phone {Title="Elite x3", Company="HP", Price=56000 },
                new Phone {Title="Mi5S", Company="Xiaomi", Price=35000 }
            };
        }

        public Phone SelectedPhone
        {
            get => selectedPhone;
            set => SetValue(ref selectedPhone, value);
        }
    }
}
