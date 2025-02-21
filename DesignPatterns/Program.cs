﻿// See https://aka.ms/new-console-template for more information

// Check for Testing The Observer Pattern 
using DesignPatterns.Observer;
using System.Collections.ObjectModel;

OnlineMarketPlace onlineMarketPlace = new OnlineMarketPlace();
//Name: "Ahmed", isSubscribedToProducts :true,]isSubscribedToOffers : true
onlineMarketPlace.addUser(new User("Ahmed", true, true));
//Name: "Mahmoud", isSubscribedToProducts :false,]isSubscribedToOffers : true
onlineMarketPlace.addUser(new User("Mahmoud", false, true));
//Name: "Youssef", isSubscribedToProducts :true,]isSubscribedToOffers : false
onlineMarketPlace.addUser(new User("Youssef", true, false));
//Name: "Mostafa", isSubscribedToProducts :false,]isSubscribedToOffers : false
onlineMarketPlace.addUser(new User("Mostafa", false, false));
// Add new Product _name = "Product",_price = 1000.0
onlineMarketPlace.addNewProduct(new Product("Mobile", 1000.0));
// Add new Offer _message :"This new Offer with 20% discount for every item " 
onlineMarketPlace.addNewOffer(new Offer(" This new Offer with 20% discount for every item "));








