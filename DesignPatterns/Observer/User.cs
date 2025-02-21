
namespace DesignPatterns.Observer
{
    internal class User
    {
        public string  _name { get; set; }
        public bool _isSubscribedToProducts { get; set; }
        public bool _isSubscribedToOffers { get; set; }

        public User( string name ,bool isSubscribedToProducts,bool isSubscribedToOffers) 
        {
            this._name = name;
            this._isSubscribedToProducts = isSubscribedToProducts;
            this._isSubscribedToOffers = isSubscribedToOffers;

        }

        

        internal void notify(Product product) =>Console.WriteLine("Notifying user :  " + this._name + " about new product : "+product._name);
        internal void notify(Offer offer) => Console.WriteLine("Notifying user : " + this._name + " about new offer : " + offer._message);

    }
}