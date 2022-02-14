using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace InventoryApi.Models
{
    public class Articulo
    {
        [Key]
        public int IdArticulo { get; set; }
        public string Descripcion { get; set; }
        public int Sku { get; set; }
        public int IdMarca { get; set; }
    }
}
