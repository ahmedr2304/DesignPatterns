namespace DesignPatterns.Behavioral.Observer
{
    internal class User
    {
        public string _name { get; set; }
        public bool _isSubscribedToProducts { get; set; }
        public bool _isSubscribedToOffers { get; set; }

        public User(string name, bool isSubscribedToProducts, bool isSubscribedToOffers)
        {
            _name = name;
            _isSubscribedToProducts = isSubscribedToProducts;
            _isSubscribedToOffers = isSubscribedToOffers;

        }
        // notify new product
        internal void notify(Product product) => Console.WriteLine("Notifying user :  " + _name + " about new product : " + product._name);
        // notify new offer
        internal void notify(Offer offer) => Console.WriteLine("Notifying user : " + _name + " about new offer : " + offer._message);

    }
}