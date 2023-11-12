using System.Collections;

namespace ConsoleApp1.DataModel
{
    public class ProductList : IEnumerable<Product>
    {
        private List<Product> _products = new List<Product>();
        public IEnumerator<Product> GetEnumerator()
        {
            return _products.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}


