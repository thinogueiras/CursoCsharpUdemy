using EnumeraçõesComposições.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnumeraçõesComposições.Entities
{
    public class OrderTest
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatusTest Status { get; set; }

        public override string ToString()
        {
            return $"{Id}, {Moment}, {Status}";
        }
    }
}
