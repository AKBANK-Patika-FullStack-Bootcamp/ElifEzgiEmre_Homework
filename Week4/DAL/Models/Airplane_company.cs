using Assing1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Week1.Models
{
    public class Airplane_company
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Company_id { get; set; }

        public string Company_name { get; set; }

        public List<Airplane> Airplanes { get; set; }
    }
}
