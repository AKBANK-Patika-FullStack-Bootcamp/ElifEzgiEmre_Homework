using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Week1.Models;

namespace Assing1.Models
{
    public class Airplane
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int airplane_id { get; set; }

        public int total_number_of_seats { get; set; }

        public string airplane_models { get; set; }

        public string airplane_type { get; set; }


        [ForeignKey("Airplane_company")]
        public string company_name { get; set; }

        public Airplane_company airplane_company { get; set; }


    }
}
