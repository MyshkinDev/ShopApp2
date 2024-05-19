using ShopApp2.DataAcces;

namespace ShopApp2.Views
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();

            var dbContext = new ShopDbContext();
            category.Text = dbContext.Categories.Count().ToString();
            product.Text = dbContext.Products.Count().ToString();
            client.Text = dbContext.Clients.Count().ToString();


            //int searchById = 1;

            //var nombreProducto = dbContext.Products.FirstOrDefault(p => p.Id == searchById);
            //if (nombreProducto != null)
            //{
            //    product.Text = nombreProducto.Nombre;
            //}

            //var nombreCategoria = dbContext.Categories.FirstOrDefault(p => p.Id == searchById);
            //if (nombreCategoria != null)
            //{
            //    category.Text = nombreCategoria.Nombre;
            //}

            //var nombreCliente = dbContext.Clients.FirstOrDefault(p => p.Id == searchById);
            //if (nombreCliente != null)
            //{
            //    client.Text = nombreCliente.Nombre;
            //}

            //int idSearch=2;

            //var computadoras = dbContext.Products.Where(p => p.CategoryId == idSearch).ToList();
            //if (computadoras.Any())
            //{
            //    StringBuilder sb = new StringBuilder();
            //    foreach (var producto in computadoras)
            //    {
            //        sb.AppendLine($"Id: {producto.Id}, Nombre: {producto.Nombre}, Descripción: {producto.Descripcion}, Precio: {producto.Precio}");
            //    }
            //    client.Text = sb.ToString();
            //}
            //else
            //{
            //    client.Text = "No se encontraron productos en la categoría Computadoras.";
            //}



        }

    }

}
