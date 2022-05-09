using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KredekStronaZadDom.Models
{
    public class kurs
    {
        public kurs(int Id,string Name, int Price, string Description)
        {
            this.Id = Id;
            this.Name=Name;
            this.Price = Price;
            this.Description = Description;
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }

        public string Description { get; set; }
    }
}
