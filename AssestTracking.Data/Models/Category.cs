using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetTracking.Data.Models
{
    public class Category
    {
        
        public int CategoryId { get; set; }

        
        public string CategoryName { get; set; }

        // Add other category-related fields as needed
    }
}
