using DesignPatterns.Behavioral.Observer.Enum;
using DesignPatterns.Behavioral.Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{
    internal class OnlineMarketPlace
    {
        private Dictionary<EventType, List<ISubscriber>> _subscribers;

        //private List<User> _users;

        private List<Product> _products;

        private List<Offer> _offers;

        public OnlineMarketPlace()
        {
            // _users = new List<User>();
            _subscribers = new Dictionary<EventType, List<ISubscriber>>();

            initSubscriberEvents();

            _products = new List<Product>();
            _offers = new List<Offer>();


        }

        public void initSubscriberEvents() 
        {
            _subscribers.Add(EventType.NEW_PRODUCT, new List<ISubscriber>());
            _subscribers.Add(EventType.NEW_OFFER, new List<ISubscriber>());
            _subscribers.Add(EventType.JOB_OPENING, new List<ISubscriber>());

        }

        public void subscribe(EventType eventType, ISubscriber subscriber) 
        {
            _subscribers.GetValueOrDefault(eventType)!.Add(subscriber);
        }

        public void unSubscribe(EventType eventType, ISubscriber subscriber)
        {
            _subscribers.GetValueOrDefault(eventType)!.Remove(subscriber);
        }

        

        public void addNewProduct(Product product)
        {
            _products.Add(product);
            notifySubcribers(EventType.NEW_PRODUCT, "New Product is added : " + product._name);

         //   notifyUsers(product);

        }

        public void addNewOffer(Offer offer)
        {
            _offers.Add(offer);
            notifySubcribers(EventType.NEW_OFFER, "New offer is added : " + offer._message);
            //notifyUsers(offer);

        }

        private void notifySubcribers(EventType eventType, string message)
        {
            _subscribers.GetValueOrDefault(eventType)!.ForEach(subscribe => subscribe.notify(message));
        }


        // public void addUser(User user) => _users.Add(user);


        //// Notify only the subscribed users for new product

        //private void notifyUsers(Product product)
        //{
        //    _users.ForEach(U =>
        //    {
        //        if (!U._isSubscribedToProducts) return;
        //        U.notify(product);
        //    });
        //}



        //// Notify only the subscribed users for new offer
        //private void notifyUsers(Offer offer)
        //{
        //    _users.ForEach(U =>
        //    {
        //        if (!U._isSubscribedToOffers) return;
        //        U.notify(offer);
        //    });
        //}




    }
}
