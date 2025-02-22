using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer.Interfaces
{
    public interface ISubscriber
    {
       public void notify(string message);
    }
}
