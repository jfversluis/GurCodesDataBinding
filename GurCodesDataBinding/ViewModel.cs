using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;

namespace GurCodesDataBinding
{
    public class ViewModel : INotifyPropertyChanged
    {
        private string _viewModelText;
        public string ViewModelText
        {
            get
            {
                return _viewModelText;
            }
            set
            {
                _viewModelText = value;

                OnPropertyChanged(nameof(ViewModelText));
            }
        }

        public ObservableCollection<FooObject> ItemList { get; set; } = new ObservableCollection<FooObject>
        {
			new FooObject { Foo = "Bar" },
			new FooObject { Foo = "Bar1" },
			new FooObject { Foo = "Bar2" },
			new FooObject { Foo = "Bar3" },
			new FooObject { Foo = "Barmitzwa" },
        };

        public Command DeleteCommand { get; set; }

        public ViewModel() {
            ViewModelText = "Hello from the ViewModel";
            DeleteCommand = new Command<FooObject>(Delete);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
			if (PropertyChanged != null)
			{
				PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
        }

        private void Delete(FooObject foo)
        {
            ItemList.Remove(foo);
        }
    }
}