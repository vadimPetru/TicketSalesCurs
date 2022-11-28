using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSalesCurs.interfaces;

namespace TicketSalesCurs
{
    public class ForExample 
    {
        FindPeople find = new();
        
        public void Start()
        {
            find.Find(3);
        }
    }
}
