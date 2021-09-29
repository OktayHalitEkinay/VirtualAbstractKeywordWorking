using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualAbstractKeyword.Abstract;

namespace VirtualAbstractKeyword.Concrete
{
    public class CustomerManager : BaseCustomerManager
    {
        public override void Delete()
        {
            Console.WriteLine("Customer deleted.");
        }

        public override string Save()
        {
            return base.Save()+"be happy :):):)";
        }
    }
}
