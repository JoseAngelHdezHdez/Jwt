using Jwt.Models;

namespace Jwt.Constants
{
    public class ProductsConstants
    {
        public static List<ProductModel> Products = new List<ProductModel>()
        {
            new ProductModel() {Name = "CocaCola", Description= "Refresco de Cola"},
            new ProductModel() {Name = "Gansito", Description= "Pasteleria Bimbo"},
            new ProductModel() {Name = "Sabritas", Description= "Papas clasicas"}

        };
    }
}
