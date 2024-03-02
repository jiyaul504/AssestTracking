using AssetTracking.Data;
using AssetTracking.Data.Models;

using AssetTracking.Repository.Repository.ImportExport;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.InkML;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace AssetTracking.Web.Controllers
{
    public class ImportExportAssetController : Controller
    {
        private readonly AppDbContext _context;
        public ImportExportAssetController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetAssetList()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AssetList()
        {
            int totalRecord = 0;
            int filterRecord = 0;
            var draw = Request.Form["draw"].FirstOrDefault();
            var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][data]"].FirstOrDefault();
            var sortColumnDirection = Request.Form["order[0][dir]"].FirstOrDefault();
            var searchValue = Request.Form["search[value]"].FirstOrDefault();
            int pageSize = Convert.ToInt32(Request.Form["length"].FirstOrDefault() ?? "0");
            int skip = Convert.ToInt32(Request.Form["start"].FirstOrDefault() ?? "0");
            var data = _context.Set<ImportExportAsset>().AsQueryable();

            //get total count of data in table
            totalRecord = data.Count();

            // search data when search value found
            if (!string.IsNullOrEmpty(searchValue))
            {
                data = data.Where(x => x.IteamName.ToLower().Contains(searchValue.ToLower())
                || x.IteamCode.ToLower().Contains(searchValue.ToLower())
                || x.IteamDescription.ToLower().Contains(searchValue.ToLower())
                || x.UID.ToString().ToLower().Contains(searchValue.ToLower())
                || x.RFID.ToString().ToLower().Contains(searchValue.ToLower())
                || x.UID.ToString().ToLower().Contains(searchValue.ToLower())
                || x.BarCode.ToString().ToLower().Contains(searchValue.ToLower())
                || x.SerialNo.ToString().ToLower().Contains(searchValue.ToLower())
                || x.Model.ToString().ToLower().Contains(searchValue.ToLower())
                || x.Stock.ToString().ToLower().Contains(searchValue.ToLower())
                || x.bStock.ToString().ToLower().Contains(searchValue.ToLower())
                || x.mIteamTypeMasterId.ToString().ToLower().Contains(searchValue.ToLower())
                || x.mIteamMasterId.ToString().ToLower().Contains(searchValue.ToLower()));
            }

            // get total count of records after search
            filterRecord = data.Count();

            // sort data
            if (!string.IsNullOrEmpty(sortColumn) && !string.IsNullOrEmpty(sortColumnDirection))
            {
                // Explicitly specify type arguments for OrderBy
                data = sortColumnDirection == "asc"
                    ? data.OrderBy(x => EF.Property<object>(x, sortColumn))
                    : data.OrderByDescending(x => EF.Property<object>(x, sortColumn));
            }

            // pagination
            var empList = data.Skip(skip).Take(pageSize).ToList();

            var returnObj = new
            {
                draw = draw,
                recordsTotal = totalRecord,
                recordsFiltered = filterRecord,
                data = empList
            };

            return Json(returnObj);
        }
    }
} 

  

