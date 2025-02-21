using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    internal class OnlineMarketPlace
    {
        private List<User> _users;
        
        private List<Product> _products;

        private List<Offer> _offers;

        public OnlineMarketPlace()
        {
            this._users = new List<User>();
            this._products = new List<Product>();
            this._offers = new List<Offer>();

                
        }

        public void addUser(User user) => this._users.Add(user);

        public void addNewProduct(Product product) 
        {
            this._products.Add(product);
            notifyUsers(product);

        }

        // Notify only the subscribed users for new product

        private void notifyUsers(Product product)
        {
            _users.ForEach(U =>
            {
                if (!U._isSubscribedToProducts) return;
                U.notify(product);
            });
        }

        public void addNewOffer(Offer offer )
        {
            this._offers.Add(offer);
            notifyUsers(offer);

        }

        // Notify only the subscribed users for new offer
        private void notifyUsers(Offer offer)
        {
            _users.ForEach(U =>
            {
                if (!U._isSubscribedToOffers) return;
                U.notify(offer);
            });
        }




    }
}
