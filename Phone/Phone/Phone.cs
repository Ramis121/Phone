using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    public class Phone : BaseViewModel
    {
        private string title;
        private string company;
        private int price;

        public string Title
        {
            get => title;
            set => SetValue(ref title, value);
        }
        public string Company
        {
            get => company;
            set => SetValue(ref company, value);
        }
        public int Price
        {
            get => price;
            set => SetValue(ref price, value);
        }
    }
}
