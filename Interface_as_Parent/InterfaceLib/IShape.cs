using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLib
{
    /* an Interface is like a pure abstract class 
     * (that is all the methods and properties are abstract)
     * Further more, an interface does not contain any private fields nor constructor
     * 
     *      By default any method or property defined in an interface is considered public
     *      and abstract, therefore you do not add the keyword public abstract to a method
     *      or property defined in an interface
     *      
     *      Cannot create/instanciate an object of an interface
     *      
     *      Any child of an interface MUST override ALL the methods and properties
     *      
     *      An interface can be seen as a contract
     * */
    public interface IShape
    {
        double Volume();
        double Area();
        double Perimeter();
    }
}
