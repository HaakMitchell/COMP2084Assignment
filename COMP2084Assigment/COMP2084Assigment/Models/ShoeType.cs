using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace COMP2084Assigment.Models
{
    public class ShoeType
    {
        [Key]

        public int TypeId { get; set; }

        [ForeignKey("BrandId")]

        public int BrandId { get; set; }

        public String Name { get; set; }

        public DateTime ReleaseDate { get; set; }

        public ICollection<Shoe> Shoe { get; set; }
    }
}
