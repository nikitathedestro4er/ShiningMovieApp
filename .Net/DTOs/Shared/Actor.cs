using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.Shared
{
    public class Actor
    {
        public int Id {get; set;}

        public string Name {get; set;}

        public string Image { get; set; }

        public DateTime DateOfBirthday { get; set; }

        public double Rating { get; set; }

        public string Description { get; set; }

    }
}
