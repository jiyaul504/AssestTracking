using AssetTracking.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetTracking.Data
{
    public class AssetViewModel
    {
        public AssetViewModel()
        {
        }
        [Key]
        public int tAssetTagId { get; set; }
        [Required(ErrorMessage = "IteamName is required.")]
        [StringLength(255)]
        public string IteamName { get; set; }
        [Required(ErrorMessage = "IteamCode is required.")]
        [StringLength(100)]
        public string IteamCode { get; set; }
        [Required(ErrorMessage = "IteamDescription is required.")]
        [StringLength(400)]
        public string IteamDescription { get; set; }
        [Required(ErrorMessage = "UID is required.")]
        [StringLength(200)]
        public string UID { get; set; }
        [Required(ErrorMessage = "RFID is required.")]
        [StringLength(200)]
        public string RFID { get; set; }
        [Required(ErrorMessage = "BarCode is required.")]
        [StringLength(200)]
        public string BarCode { get; set; }
        [Required(ErrorMessage = "SerialNo is required.")]
        [StringLength(200)]
        public string SerialNo { get; set; }
        [Required(ErrorMessage = "Manufacturer is required.")]
        [StringLength(300)]
        public string Manufacturer { get; set; }
        [Required(ErrorMessage = "Model is required.")]
        [StringLength(300)]
        public string Model { get; set; }
        [Required(ErrorMessage = "ModelNo is required.")]
        [StringLength(300)]
        public string ModelNo { get; set; }
        [Required(ErrorMessage = "SourceNo is required.")]
        [StringLength(300)]
        public string SourceNo { get; set; }
        [Required(ErrorMessage = "LotNo is required.")]
        [StringLength(300)]
        public string LotNo { get; set; }
        public DateTime CalibrationDueDate { get; set; }
        [Required(ErrorMessage = "PurchaseCost is required.")]
        [Range(0, double.MaxValue, ErrorMessage = "PurchaseCost must be a positive number.")]
        public decimal PurchaseCost { get; set; }
        public DateTime PurchaseDate { get; set; }
        [Required(ErrorMessage = "InvNo is required.")]
        [StringLength(300)]
        public string InvNo { get; set; }
        public decimal Depreciation { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ReturnDate { get; set; }
        [Required(ErrorMessage = "ReceivedBy is required.")]
        [StringLength(200)]
        public string ReceivedBy { get; set; }

        public string DefaultWarranty { get; set; }
        [Required(ErrorMessage = "DefaultWarranty is required.")]
        [Range(0, double.MaxValue, ErrorMessage = "DefaultWarranty must be a positive number.")]
        public int Stock { get; set; }
        [Required(ErrorMessage = "DefaultWarranty is required.")]
        [Range(0, double.MaxValue, ErrorMessage = "DefaultWarranty must be a positive number.")]
        public bool BStock { get; set; }
        [Required(ErrorMessage = "Img is required.")]
        [StringLength(200)]
        public string Img { get; set; }
        public bool IsAction { get; set; }
        public DateTime CreatedDate { get; set; }
        [Required(ErrorMessage = "CreatedBy is required.")]
        [StringLength(200)]
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        [Required(ErrorMessage = "ModifiedBy is required.")]
        [StringLength(200)]
        public string ModifiedBy { get; set; }



        //Relationship  tables

        [ForeignKey("Organization")]
        public int OrgInfoId { get; set; } //Foreign Key
        public Organization Organization { get; set; }//Reference navigation property

        [ForeignKey("TeamMaster")]
        public int mIteamMasterId { get; set; }
        public TeamMaster TeamMaster { get; set; }

        [ForeignKey("Vendor")]
        public int mVendorId { get; set; }
        public Vendor Vendor { get; set; }

        [ForeignKey("StatusMaster")]
        public int mStatusMasterId { get; set; }
        public StatusMaster StatusMaster { get; set; }
        [ForeignKey("Employee")]
        public int tEmployeeTagId { get; set; }
        public Employee Employee { get; set; }

        [ForeignKey("UnitMaster")]
        public int mUnitMasterId { get; set; }
        public UnitMaster UnitMaster { get; set; }

        [ForeignKey("GroupMaster")]
        public int mGroupMasterId { get; set; }
        public GroupMaster GroupMaster { get; set; }

        [ForeignKey("TeamTypeMaster")]
        public int mIteamTypeMasterId { get; set; }
        public TeamTypeMaster TeamTypeMaster { get; }

        [ForeignKey("SiteMaster")]
        public int mSiteMasterId { get; set; }
        public SiteMaster SiteMaster { get; set; }

        [ForeignKey("Zone")]
        public int mZoneId { get; set; }
        public Zone Zone { get; set; }

        [ForeignKey("FloorMaster")]
        public int mFloorMasterId { get; set; }
        public FloorMaster FloorMaster { get; set; }

        [ForeignKey("RoomMaster")]
        public int mRoomMasterId { set; get; }
        public RoomMaster RoomMaster { get; }

    }
}
