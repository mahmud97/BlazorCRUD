using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GridSample.Data
{
    public class TestListDetails
    {

        public int Id { get; set; }

        [Column("Test Unit")]
        [DisplayName("Test Unit")]
        [Required]
        public float TestUnit { get; set; }

        [Column("Test Normal Value")]
        [DisplayName("Test Normal Value")]
        [Required]
        public float TestNormalValue { get; set; }

        [Column("Test Parameter")]
        [DisplayName("Test Parameter")]
        [Required]
        public bool TestParameter { get; set; }

        [Column("Validation Date")]
        [DisplayName("Validation Date")]
        [Required]

        public DateTime ValidationDate { get; set; }






    }
}
