﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetTracking.Data.Models
{
    public class RoomMaster
    {
        [Key]
        public int mRoomMasterId { get; set; }
        public int mFloorMasterId { get; set; }
        public string RoomName { get; set; }
        public int RoomNo { get; set; }
        public int mSiteMasterId { get; set; }
        public int mZoneId { get; set; }
        public bool IsAction { get; set; }
        public int OrgInfoId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }

}
