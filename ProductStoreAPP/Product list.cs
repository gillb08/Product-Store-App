using System.Dynamic;

namespace ProductStoreAPP
{
    public class ProductStore
    {
        public List<Product> products;
        public ProductStore()
        {
            products = new List<Product>();
            products.Add(new Product { name = "PR_1", id = 1, price = 23, category = "Electronics", orderCount = 2, quantity = 45, });
            products.Add(new Product { name = "PR_2", id = 2, price = 15, category = "Beach Wears", orderCount = 7, quantity = 67, });
            products.Add(new Product { name = "PR_3", id = 3, price = 14, category = "Phone Accessories", orderCount = 5, quantity = 89, });
            products.Add(new Product { name = "PR_4", id = 4, price = 56, category = "Food Stuffs", orderCount = 4, quantity = 788, });
        }

        public List<dynamic> ProductList(List<string> properties = null)
        {
            if (properties == null)
            {
                return products.Select((Product product) =>
                {
                    dynamic expandoObject = new ExpandoObject();
                    expandoObject.id = product.id;
                    expandoObject.price = product.price;
                    expandoObject.category = product.category;
                    expandoObject.orderCount = product.orderCount;
                    expandoObject.quantity = product.quantity;

                    return expandoObject;
                }).ToList();
            }
            else
            {
                return products.Select((Product product) =>
                {
                    dynamic expandoObject = new ExpandoObject();
                    if (properties.Contains("ID".ToLower()))
                    {
                        expandoObject.id = product.id;
                    }
                    if (properties.Contains("name".ToLower()))
                    {
                        expandoObject.name = product.name;
                    }
                    if (properties.Contains("price".ToLower()))
                    {
                        expandoObject.price = product.price;
                    }
                    if (properties.Contains("category".ToLower()))
                    {
                        expandoObject.category = product.category;
                    }
                    if (properties.Contains("ordercount".ToLower()))
                    {
                        expandoObject.ordercount = product.orderCount;
                    }
                    if (properties.Contains("quantity".ToLower()))
                    {
                        expandoObject.quantity = product.quantity;
                    }
                    return expandoObject;

                }).ToList();
            }

        }
    }
}
