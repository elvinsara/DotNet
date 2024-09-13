using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone_2_ECommerce
{
    public interface IOrderProcessor
    {
        void ProcessOrder();
        void CancelOrder();
    }
}
