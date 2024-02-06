using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssestTracking.Data.Models
{
    public class Asset
    {
        public int AssetId { get; set; }
        public string AssetName { get; set; }
        public int CategoryId { get; set; }
        public int LocationId { get; set; }
        public string Status { get; set; }
        // Add other properties as needed
    }
}
