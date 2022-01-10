using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    interface ITime
    {
        public DateTime CreationTime { get; set; } 

        public DateTime ModifiedDate { get; set; } 
    }
}
