namespace DesignPatterns.Behavioral.Observer
{
    internal class Product
    {
        public string _name { get; set; }
        public double _price { get; set; }

        public Product(string name, double price)
        {
            _name = name;
            _price = price;

        }

    }



}