﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetTracking.Data.Models
{
    public class TeamMaster
    {
        [Key]
        public int IteamMasterId { get; set; }
        public string IteamName { get; set; }
        public string IteamCode { get; set; }
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
