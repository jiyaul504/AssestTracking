using AssestTracking.Data.Models;
using AssetTracking.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetTracking.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Asset> tAssetTag { get; set; }
        public DbSet<Employee> tEmployeeTag { get; set; }
        public DbSet<FloorMaster> mFloorMaster { get; set; }
        public DbSet<GroupMaster> mGroupMaster { get; set; }
        public DbSet<Organization> OrgInfo { get; set; }
        public DbSet<RoomMaster> mRoomMaster { get; set; }
        public DbSet<SiteMaster> mSiteMaster { get; set; }
        public DbSet<StatusMaster> mStatusMaster { get; set; }
        public DbSet<TeamMaster> mIteamMaster { get; set; }
        public DbSet<TeamTypeMaster> mIteamTypeMaster { get; set; }
        public DbSet<UnitMaster> mUnitMaster { get; set; }
        public DbSet<Vendor> mVendor { get; set; }
        public DbSet<Zone> mZone { get; set; }
       

        // Add other DbSets as needed

    }
}
