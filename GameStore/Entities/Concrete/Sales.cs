using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Entities.Concrete
{
    public class Sales
    {
        public int Id { get; set; }
        public DateTime SalesDate { get; set; }
        public int Discount { get; set; }

    }
}
