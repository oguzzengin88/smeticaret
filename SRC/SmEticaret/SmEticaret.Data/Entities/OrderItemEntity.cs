using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmEticaret.Data.Entities
{
    public class OrderItemEntity : EntityBase
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Paid { get; set; }


        //Navigation keys
        [ForeignKey(nameof(OrderId))]
        public OrderEntity OrderEntity { get; set; }

            [ForeignKey(nameof(ProductId))]
            public ProductEntity ProductEntity { get; set; }

        }
}
