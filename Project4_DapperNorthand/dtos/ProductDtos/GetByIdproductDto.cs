using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4_DapperNorthand.dtos.ProductDtos
{
    public class GetByIdproductDto
    {
        public int ProductId { get; set; }
        public String ProductName { get; set; }
        public decimal unitPrice { get; set; }
        public int UnitsStock { get; set; }
        public int CategoryId { get; set; }


    }
}
