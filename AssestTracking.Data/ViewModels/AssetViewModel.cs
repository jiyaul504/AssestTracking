using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetTracking.Data
{
    public class AssetViewModel
    {
        public int AssetId { get; set; }
        public string AssetName { get; set; }
        public string CategoryName { get; set; }
        public string LocationName { get; set; }
        public string Status { get; set; }
    }
}
