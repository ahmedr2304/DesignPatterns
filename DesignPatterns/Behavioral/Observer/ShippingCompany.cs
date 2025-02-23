namespace DesignPatterns.Behavioral.Observer
{
    internal class ShippingCompany : ISubscriber
    {
        public string _name { get; set; }

        public ShippingCompany(string name)
        {
            _name = name;

        }
        public void notify(string message) => Console.WriteLine(_name + " is receiveing new message about : " + message);

    }
}
