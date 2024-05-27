using ShopApp2.DataAcces;

namespace ShopApp2.Views;

public partial class ProductsPage : ContentPage
{
	public ProductsPage()
	{
		InitializeComponent();

        var database = new ShopDbContext();
        products.ItemsSource = database.Products;

       
    }
}