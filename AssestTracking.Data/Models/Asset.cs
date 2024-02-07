using AssetTracking.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssestTracking.Data.Models
{
    public class Asset
    {
            [Key]
            public int tAssetTagId { get; set; }
            public string IteamName { get; set; }
            public string IteamCode { get; set; }
            public string IteamDescription { get; set; }
            public string UID { get; set; }
            public string RFID { get; set; }
            public string BarCode { get; set; }
            public string SerialNo { get; set; }
            public string Manufacturer { get; set; }
            public string Model { get; set; }
            public string ModelNo { get; set; }
            public string SourceNo { get; set; }
            public string LotNo { get; set; }
            public DateTime CalibrationDueDate { get; set; }
            public decimal PurchaseCost { get; set; }
            public DateTime PurchaseDate { get; set; }
            public string InvNo { get; set; }
            public decimal Depreciation { get; set; }
            public DateTime IssueDate { get; set; }
            public DateTime ReturnDate { get; set; }
            public string ReceivedBy { get; set; }
            public string DefaultWarranty { get; set; }
            public int Stock { get; set; }
            public bool BStock { get; set; }
            public string Img { get; set; }
            public bool IsAction { get; set; }
            public DateTime CreatedDate { get; set; }
            public string CreatedBy { get; set; }
            public DateTime ModifiedDate { get; set; }
            public string ModifiedBy { get; set; }



        //Relationship  tables

        [ForeignKey("Organization")]
        public int OrgInfoId { get; set; } //Foreign Key
        public Organization Organization { get; set; }//Reference navigation property

        [ForeignKey("TeamMaster")]
        public int mIteamMasterId { get; set; }
        public TeamMaster TeamMaster {  get; set; }

        [ForeignKey("Vendor")]
        public int mVendorId { get; set; }
        public Vendor Vendor { get; set; }

        [ForeignKey("StatusMaster")]
        public int mStatusMasterId { get; set; }
        public StatusMaster StatusMaster { get; set; }
        [ForeignKey("Employee")]
        public int tEmployeeTagId {  get; set; }
        public Employee Employee {  get; set; }

        [ForeignKey("UnitMaster")]
        public int mUnitMasterId {  get; set; }
        public UnitMaster UnitMaster { get; set; }

        [ForeignKey("GroupMaster")]
        public int mGroupMasterId {  get; set; }
        public GroupMaster GroupMaster { get; set;}

        [ForeignKey("TeamTypeMaster")]
        public int mIteamTypeMasterId {  get; set; }
        public TeamTypeMaster TeamTypeMaster { get;}

        [ForeignKey("SiteMaster")]
        public int mSiteMasterId {  get; set; }
        public SiteMaster SiteMaster { get; set; }

        [ForeignKey("Zone")]
        public int mZoneId {  get; set; }
        public Zone Zone { get; set; }

        [ForeignKey("FloorMaster")]
        public int mFloorMasterId { get; set; }
        public FloorMaster FloorMaster { get; set; }

        [ForeignKey("RoomMaster")]
        public int mRoomMasterId { set; get; }
        public RoomMaster RoomMaster { get;}
    }
}
