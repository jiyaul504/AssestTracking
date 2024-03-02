using AssestTracking.Data.Models;
using DocumentFormat.OpenXml.Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetTracking.Data.Models
{
    public class ImportExportAsset
    {
        public int Id { get; set; }
       
        public Asset Asset { get; set; }
        public string IteamName { get; set; }
        public string IteamCode { get; set; }
        public string IteamDescription { get; set; }
        public string UID { get; set; }
        public string RFID { get; set; }
        public string BarCode { get; set; }
        public string SerialNo { get; set; }
        public string Model { get; set; }
        public int Stock { get; set; }
        public bool bStock { get; set; }

      //  [ForeignKey("TeamTypeMaster")]
        public int mIteamTypeMasterId { get; set; }
       

        
        public int mIteamMasterId { get; set; }
        
    }
}
