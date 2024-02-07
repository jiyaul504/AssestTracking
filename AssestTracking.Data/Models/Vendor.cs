using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetTracking.Data.Models
{
    public class Vendor
    {
        [Key]
        public int VendorId { get; set; }
        public string VendorName { get; set; }
        public string ContactName { get; set; }
        public string GSTIN { get; set; }
        public string PAN { get; set; }
        public string TIN { get; set; }
        public string Mobile { get; set; }
        public string EmailId { get; set; }
        public string Address { get; set; }
        public int StateID { get; set; }
        public string City { get; set; }
        public string Pincode { get; set; }
        public bool IsAction { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }

        [ForeignKey("Organization")]
        public int OrgInfoId { get; set; } //Foreign Key
        public Organization Organization { get; set; }//Reference navigation property
    }
}
