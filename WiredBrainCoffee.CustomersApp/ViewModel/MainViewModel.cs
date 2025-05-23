using WiredBrainCoffee.CustomersApp.Command;

namespace WiredBrainCoffee.CustomersApp.ViewModel
{
	public class MainViewModel : ViewModelBase
	{
        public DelegateCommand SelectedViewModelCommand { get; }

        private ViewModelBase? _selectedViewModel;
        public MainViewModel(CustomersViewModel customersViewModel,
			ProductsViewModel productsViewModel)
		{
			CustomersViewModel = customersViewModel;
			ProductsViewModel = productsViewModel;
            SelectedViewModel = CustomersViewModel;
			SelectedViewModelCommand = new DelegateCommand(SelectViewModel);
		}

        public ViewModelBase? SelectedViewModel
		{
			get => _selectedViewModel;
			set
			{
				_selectedViewModel = value;
				RaisePropertyChanged();
			}
		}

        public CustomersViewModel CustomersViewModel { get; }
        public ProductsViewModel ProductsViewModel { get; }

        public DelegateCommand SelectViewModelCommand { get; }

        public async override Task LoadAsync()
		{
			if(SelectedViewModel is not null)
			{
				await SelectedViewModel.LoadAsync();
			}
		}

        private async void SelectViewModel(object? parameter)
        {
            SelectedViewModel = parameter as ViewModelBase;
			await LoadAsync();
        }
    }
}
