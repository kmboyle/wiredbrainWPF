using WiredBrainCoffee.CustomersApp.Model;

namespace WiredBrainCoffee.CustomersApp.Data
{
    public interface IProductDataProvider
    {
        Task<IEnumerable<Product>?> GetAllAsync();
    }
    public class ProductDataProvider : IProductDataProvider
    {
        public async Task<IEnumerable<Product>?> GetAllAsync()
        {
            await Task.Delay(100); // Simulate a bit of server work

            return new List<Product>
            {
                new Product{Name="Cappuccino", Description="A coffee drink consisting of espresso and steamed milk."},
                new Product{Name="Doppio", Description="A double shot of espresso."},
                new Product{Name="Espresso", Description="A concentrated coffee brewed by forcing hot water through finely-ground coffee."},
                new Product{Name="Latte", Description="A coffee drink made with espresso and steamed milk."},
                new Product{Name="Macchiato", Description="An espresso coffee drink with a small amount of milk."},
                new Product{Name="Mocha", Description="A chocolate-flavored variant of a latte."},
            };
        }
    }
}
