using ShopApp2.DataAcces;
using ShopApp2.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp2.Handlers
{
    public class ProductoBusquedaHandler : SearchHandler
    {
        ShopDbContext dbContext;

        public ProductoBusquedaHandler()
        {
            this.dbContext = new ShopDbContext();
        }
        protected override void OnQueryChanged(string oldValue, string newValue)
        {
            if (string.IsNullOrWhiteSpace(newValue))
            {
                ItemsSource = null;
                return;
            }

            var resultados = dbContext.Products
                .Where(p => p.Nombre.ToLowerInvariant()
                .Contains(newValue.ToLowerInvariant()));

            ItemsSource = resultados;

        }

        protected async override void OnItemSelected(object item)
        {
            await Shell.Current
                .GoToAsync($"{nameof(ProductDetailPage)}?id={((Product)item).Id}");
        }


    }
}
