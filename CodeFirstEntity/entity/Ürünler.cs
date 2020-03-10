using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstEntity.entity
{
    public class Ürünler
    {
        [Key]
        public int UrunId { get; set; }
        public string UrunADI { get; set; }
        public string UrunMarka { get; set; }
        public int UrunKategori { get; set; }
        public string UrunStok { get; set; }
        public string Aciklama { get; set; }

        
        
    }
}
