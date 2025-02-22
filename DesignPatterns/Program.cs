// See https://aka.ms/new-console-template for more information

// Check for Testing The Observer Pattern 
using DesignPatterns.Behavioral.Observer;
using DesignPatterns.Behavioral.Observer.Enum;
using DesignPatterns.Behavioral.Observer.Interfaces;
using System.Collections.ObjectModel;
#region Behavioral

    #region Observer
 
 OnlineMarketPlace onlineMarketPlace = new OnlineMarketPlace();

ISubscriber ahmed = new Customer("Ahmed");
ISubscriber mahmoud = new Customer("Mahmoud");
ISubscriber youssef = new Customer("Youssef");

// subcribe ahmed for Product & offer
onlineMarketPlace.subscribe(EventType.NEW_PRODUCT, ahmed);
onlineMarketPlace.subscribe(EventType.NEW_OFFER, ahmed);

// subcribe mahmoud for offer
onlineMarketPlace.subscribe(EventType.NEW_OFFER, mahmoud);

// subcribe youssef for product
onlineMarketPlace.subscribe(EventType.NEW_PRODUCT, youssef);

// Add new Product _name = "Product",_price = 1000.0
onlineMarketPlace.addNewProduct(new Product("Mobile", 1000.0));

// Add new Offer _message :"This new Offer with 20% discount for every item " 
onlineMarketPlace.addNewOffer(new Offer(" This new Offer with 20% discount for every item "));



////Name: "Ahmed", isSubscribedToProducts :true,]isSubscribedToOffers : true
//onlineMarketPlace.addUser(new User("Ahmed", true, true));
////Name: "Mahmoud", isSubscribedToProducts :false,]isSubscribedToOffers : true
//onlineMarketPlace.addUser(new User("Mahmoud", false, true));
////Name: "Youssef", isSubscribedToProducts :true,]isSubscribedToOffers : false
//onlineMarketPlace.addUser(new User("Youssef", true, false));
////Name: "Mostafa", isSubscribedToProducts :false,]isSubscribedToOffers : false
//onlineMarketPlace.addUser(new User("Mostafa", false, false));

#endregion

#endregion









