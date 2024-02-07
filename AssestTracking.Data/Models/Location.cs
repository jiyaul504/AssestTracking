using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace AssetTracking.Data.Models
{
    public class Location
    {
        [Key]
        public int LocationId { get; set; }

        [Required]
        [StringLength(255)]
        public string LocationName { get; set; }

        public int CompanyId { get; set; }

        //[ForeignKey("CompanyId")]
        //public Company Company { get; set; }

        // Add other location-related fields as needed
    }
}
