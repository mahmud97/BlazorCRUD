using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GridSample.Data
{
    public class TestList
    {
        public int Id { get; set; }

        [Column("Test ID")]
        [DisplayName("Test ID")]
        [Required]
        public int TestId { get; set; }

        [Column("Category Name")]
        [DisplayName("Category Name")]
        [Required]
        public string CategoryName { get; set; }

        [Column("Test Short Name")]
        [DisplayName("Test Short Name")]
        [Required]
        public string TestShortName { get; set; }

        [Column("Test Name")]
        [DisplayName("Test Name")]
        [Required]
        public string TestName { get; set; }

        [Column("Test Price")]
        [DisplayName("Test Price")]
        [Required]
        public double TestPrice { get; set; }

        [Column("Currently Performing")]
        [DisplayName("Currently Performing")]
        [Required]
        public string CurrentlyPerforming { get; set; }

    }
}
