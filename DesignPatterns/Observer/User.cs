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
    }
}