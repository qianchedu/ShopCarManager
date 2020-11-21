using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Car.Model
{
    public class OrderInfo
    {

        [Key]
        public virtual int OId { get; set; }

        [ForeignKey("CarInfo")]
        [Required]
        public virtual int CId { get; set; }

        [Required]
        public virtual int UId { get; set; }

        [Required]
        public virtual int ONumber { get; set; }


        [Required]
        public virtual double OPrice { get; set; }

        [Required]
        public virtual DateTime OCreateTime { get; set; }


        [Required]
        [StringLength(200)]
        public virtual string ORemark { get; set; }



        [Required]
        public virtual int OState { get; set; }


        public virtual CarInfo CarInfo { get; set; }
        public virtual UserInfo UserInfo { get; set; }

    }
}
