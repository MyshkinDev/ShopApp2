using ShopApp2.DataAcces;
using System.ComponentModel;

namespace ShopApp2.Views;

public partial class ProductDetailPage : ContentPage, IQueryAttributable
{
	public ProductDetailPage()
	{
		InitializeComponent();
	}

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        var dbContext = new ShopDbContext();
        var id = int.Parse(query["id"].ToString());
        var producto = dbContext.Products.First(x => x.Id == id);
        container.Children.Add(new Label
        {
            Text = producto.Nombre,
            TextColor = Microsoft.Maui.Graphics.Color.FromRgb(30, 36, 96),
            FontFamily = "Segoe UI",
            FontAttributes = FontAttributes.Bold,
            FontSize = 16,
            Padding = new Thickness(10)
        });

        container.Children.Add(new Label
        {
            Text = producto.Descripcion,
            TextColor = Microsoft.Maui.Graphics.Color.FromRgb(30, 36, 96),
            FontFamily = "Segoe UI",
            FontAttributes = FontAttributes.Bold,
            FontSize = 16,
            Padding = new Thickness(10)
        });

        container.Children.Add(new Label
        {
            Text = producto.Precio.ToString(),
            TextColor = Microsoft.Maui.Graphics.Color.FromRgb(30, 36, 96),
            FontFamily = "Segoe UI",
            FontAttributes = FontAttributes.Bold,
            FontSize = 16,
            Padding = new Thickness(10)
        });

        container.Children.Add(new Image
        {
            Source = ImageSource.FromFile("dotnet_bot.png"),
            WidthRequest = 200, 
            HeightRequest = 200, 
            Aspect = Aspect.AspectFit
        });


    }
}