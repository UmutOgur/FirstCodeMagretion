using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstEntity.entity
{
    class Müsteri
    {
        [Key]
        public int MusteriID { get; set; }
        public string MusteriADİ { get; set; }
        public string MusteriSOYADİ { get; set; }

        public string MusteriSehir { get; set; }

    }
}
