using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetTracking.Data.Models
{
    public class Employee
    {
        [Key]
        public int tEmployeeTagId { get; set; }
        public string RFID { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeId { get; set; }
        public int mAgencyId { get; set; }
        public int mDesignationId { get; set; }
        public int mSkillCategoryId { get; set; }
        public int mWorkCategoryId { get; set; }
        public int mActivityId { get; set; }
        public int mShiftId { get; set; }
        public int mSiteMasterId { get; set; }
        public int mZoneId { get; set; }
        public int mFloorMasterId { get; set; }
        public int mRoomMasterId { get; set; }
        public string EmailId { get; set; }
        public string ContactNo { get; set; }
        public string Address { get; set; }
        public bool IsAction { get; set; }
        public int OrgInfoId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
