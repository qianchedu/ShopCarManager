using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Car.Model
{
    public class CarInfo
    {

        [Key]
        public int CId { get; set; }


        [Required]
        [StringLength(100)]
        public string CName { get; set; }

        [Required]
        [StringLength(100)]
        public string CPrice { get; set; }

    }
}
