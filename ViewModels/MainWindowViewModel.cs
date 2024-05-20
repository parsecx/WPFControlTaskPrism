using Prism.Mvvm;

namespace WPFControlTaskPrism.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Little CRM";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel()
        {

        }
    }
}
