using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorCRUD.Shared.Models
{
    public class Patient
    {
        public int Id { get; set; }

        [Required]
        
        public int SerialNo { get; set; }
        [Required]
        [DisplayName("Patient Name")]
        public string Name { get; set; }
    }
}
