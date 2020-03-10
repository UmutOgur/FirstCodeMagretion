using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstEntity.entity
{
    class Kategori
    {
        [Key]
        public int KategoriID { get; set; }

        public string KategoriAdı { get; set; }

        public string KategoriDetayi { get; set; }


    }
}
