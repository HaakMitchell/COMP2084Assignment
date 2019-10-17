using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COMP2084Assigment.Models
{
    public class Brands
    {
        [Key]
        public int BrandId { get; set; }

        public String Name { get; set; }

        public ICollection<ShoeType> Shoetype { get; set; }
    }
}
