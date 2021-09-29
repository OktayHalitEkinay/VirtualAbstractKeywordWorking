using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAbstractKeyword.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public abstract void Delete();
        public virtual string Save()
        {
            return("Customer saved to db-");
        }
    }
}
