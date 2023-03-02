using ProductStoreAPP;

namespace ProductStoreApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter to select the properties you want\n" +

                "enter ALL to display all Properties");

            string UserSelection = Console.ReadLine();
            List<string> CommaSeparatedProperties = UserSelection.ToLower().Split().ToList();

            if (UserSelection == "")
            {
                CommaSeparatedProperties = null;
            }

            ProductStore store = new ProductStore();
            var ListOfSelectedProducts = store.ProductList(CommaSeparatedProperties);

            foreach (dynamic product in ListOfSelectedProducts)
            {
                var dynamicDictionary = product as IDictionary<string, object>;

                foreach (KeyValuePair<string, object> property in dynamicDictionary)
                {
                    Console.WriteLine("{0} : {1}", property.Key.ToUpper(), property.Value.ToString());
                }
                Console.WriteLine();

            }
            Console.ReadKey();
        }
    }
}