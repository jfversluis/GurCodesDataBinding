using Xamarin.Forms;

namespace GurCodesDataBinding
{
    public partial class GurCodesDataBindingPage : ContentPage
    {
        public GurCodesDataBindingPage()
        {
            InitializeComponent();

            var viewModel = new ViewModel();

            BindingContext = viewModel;

            viewModel.ViewModelText = "Whatever";
        }
    }
}
