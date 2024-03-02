using AssetTracking.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetTracking.Data.ViewModels
{
    public class ImportAssetViewModel
    {
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
        public string Model { get; set; }
        [Required(ErrorMessage = "ModelNo is required.")]
        [StringLength(300)]
        public int Stock { get; set; }
        [Required(ErrorMessage = "DefaultWarranty is required.")]
        [Range(0, double.MaxValue, ErrorMessage = "DefaultWarranty must be a positive number.")]
        public bool bStock { get; set; }
        [Required(ErrorMessage = "Img is required.")]
        [StringLength(200)]

        //Relationship  tables


        [ForeignKey("TeamTypeMaster")]
        public int mIteamTypeMasterId { get; set; }
        public TeamTypeMaster TeamTypeMaster { get; }
        [ForeignKey("TeamMaster")]
        public int mIteamMasterId { get; set; }
        public TeamMaster TeamMaster { get; set; }
    }
}