using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Pedidos.Models
{
    public class ProductModel
    {
        public long id {get; set;}
        public string product {get; set;}
        public int quantity {get; set;}
        public double totalValue {get; set;}
    }
}