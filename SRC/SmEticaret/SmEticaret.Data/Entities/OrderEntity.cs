using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmEticaret.Data.Entities
{
    public class OrderEntity : EntityBase
    {
        public int UserId { get; set; }
        public DateTime CreatedAt { get; set; }
        [Required,MaxLength(250)]
        public string DeliveryAddress { get; set; }

        //navigation key

        [ForeignKey("UserId")]
        public UserEntity UserEntity{ get; set; }


    }
}
