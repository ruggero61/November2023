namespace ConsoleApp1.DataModel
{
    public class Product
    {
        private int _id;
        private string _name;
        private decimal _price;
        private int _stock;
        private string _productName;
        private string _productDescription;

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public decimal Price
        {
            get => _price;
            set => _price = value;
        }

        public int Stock
        {
            get => _stock;
            set => _stock = value;
        }
        public string ProductName
        {
            get => _productName;
            set => _productName = value;
        }
        public string ProductDescription
        {
            get => _productDescription;
            set => _productDescription = value;
        }
    }
}