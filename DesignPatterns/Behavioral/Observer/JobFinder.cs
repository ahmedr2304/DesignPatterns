
namespace DesignPatterns.Behavioral.Observer
{
    internal class JobFinder : ISubscriber
    {
        public string _name { get; set; }

        public JobFinder(string name)
        {
                this._name = name;
        }
        public void notify(string message) => Console.WriteLine(_name + "is receiving a notification about job finding " + message);
        
    }
}
