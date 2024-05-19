using ShopApp2.DataAcces;

namespace ShopApp2.Views;

public partial class ProductsPage : ContentPage
{
	public ProductsPage()
	{
		InitializeComponent();

        var dbContext = new ShopDbContext();

        foreach (var product in dbContext.Products)
        {
            var boton = new Button { Text = product.Nombre };
            boton.Clicked += async (s, e) =>
            {
                var uri = $"{nameof(ProductDetailPage)}?id={product.Id}";
                await Shell.Current.GoToAsync(uri);
            };

            container.Children.Add(boton);


            //container.Children.Add(new Label {
            //	Text = product.Nombre,
            //             TextColor = Microsoft.Maui.Graphics.Color.FromRgb(30, 36, 96),
            //             FontFamily = "Segoe UI",    
            //             FontAttributes = FontAttributes.Bold, 
            //             FontSize = 16,             
            //             Padding = new Thickness(10)
            //         });
        }
    }
}