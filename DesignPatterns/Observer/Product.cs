﻿namespace DesignPatterns.Observer
{
    internal class Product
    {
        public  string _name { get; set; }
        public double _price { get; set; }

        public Product(string name , double price)
        {
            this._name = name;  
            this._price = price;

        }

    }

    
  
}