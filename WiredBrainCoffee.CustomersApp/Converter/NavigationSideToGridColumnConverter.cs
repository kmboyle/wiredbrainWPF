using System.Globalization;
using System.Windows.Data;
using static WiredBrainCoffee.CustomersApp.ViewModel.CustomersViewModel;

namespace WiredBrainCoffee.CustomersApp.Converter
{
    public class NavigationSideToGridColumnConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var navigationSide = (NavigationSideEnum)value;
            return navigationSide == NavigationSideEnum.Left
                ? 0 // <-- Valud for Grid.Column
                : 2;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
