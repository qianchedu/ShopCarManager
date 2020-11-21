using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Shop.Car.Model
{
    public class UserInfo
    {

        [Key]
        public int UId { get; set; }

        [Required]
        [StringLength(100)]
        public string UName { get; set; }


        [Required]
        [StringLength(100)]
        public string UPwd { get; set; }


        [Required]
        [StringLength(100)]
        public string URealName { get; set; }


        [Required]
        public int UIsAdmin { get; set; }

    }
}
