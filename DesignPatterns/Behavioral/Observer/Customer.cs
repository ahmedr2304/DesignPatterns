using DesignPatterns.Behavioral.Observer.Interfaces;

namespace DesignPatterns.Behavioral.Observer
{
    internal class Customer : ISubscriber
    {
        public string _name { get; set; }
        

        public Customer(string name)
        {
            _name = name;
        }
        
       public void notify(string message) => Console.WriteLine("Notifying customer :  " + _name + " about new message : " + message);

        
    }
}