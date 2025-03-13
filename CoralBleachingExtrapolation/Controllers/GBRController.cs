//using CoralBleachingExtrapolation.Data;
//using CoralBleachingExtrapolation.Models;
//using CoralBleachingExtrapolation.ViewModels;
//using Microsoft.AspNetCore.Mvc;
//using System.Collections.Generic;
//using System.Linq;
//using NetTopologySuite.Geometries;
//using NetTopologySuite.IO;
//using NetTopologySuite.Algorithm;

///// <summary>
///// Date         Version   Name       Comment
///// 03-03-2025   1.0       Keelin     Create, Read, Update, Delete Intial
///// </summary>
///// 



//namespace CoralBleachingExtrapolation.Controllers
//{
//    public class GBRController : Controller
//    {
//        private readonly ApplicationDbContextGBR _db;

//        List<GBRCoralPoint> TheModel;

//        public GBRController(ApplicationDbContextGBR db)
//        {
//            _db = db;
//        }

//        //--------------------------------Read All----------------------------------//
//        public IActionResult Index() // Read
//        {
//            //TheModel = _db.tbl_GlobalCoralPolygon.ToList();

//            TheModel = _db.tbl_GBRCoralPoint
//                               .OrderByDescending(x => x.GBRCoralPointID) // Sort by ID in descending order
//                               .Take(10)                     // Get the last 10 records
//                               .ToList();

//            return View(TheModel);
//        }

//        //--------------------------------Read One:TODO----------------------------------//
//        public IActionResult Read(int id)
//        {
//            if (id == null || id == 0)
//            {
//                return NotFound();
//            }

//            GBRCoralPoint? Coral = _db.tbl_GBRCoralPoint.Find(id);

//            if (Coral == null)
//            {
//                return NotFound();
//            }
//            return View(Coral);
//        }


//        //--------------------------------Create----------------------------------//
//        public IActionResult Create() //Create
//        {
//            return View();
//        }

//        [HttpPost]
//        public IActionResult Create(GBRCoralPoint obj) //Create
//        {
//            //test only
//            obj.Latitude = 1;
//            obj.Longitude = 1;
//            string wkt = "POINT((-75.0 40.0, -73.0 40.5, -74.0 41.0, -75.0 40.0))";
//            var geometryFactory = new GeometryFactory(new PrecisionModel(), 4326);
//            var wktReader = new WKTReader(geometryFactory);
//            Point point = (Point)wktReader.Read(wkt);
//            obj.Point = point;
//            obj.Point.SRID = 4326;
//            //test only
//            _db.tbl_GBRCoralPoint.Add(obj);
//            _db.SaveChanges();
//            return View();
//        }


//        //--------------------------------Update----------------------------------//
//        [HttpGet]
//        public IActionResult Update(int? id) // Update
//        {
//            if (id == null || id == 0)
//            {
//                return NotFound();
//            }

//            GBRCoralPoint? Coral = _db.tbl_GBRCoralPoint.Find(id);

//            if (Coral == null)
//            {
//                return NotFound();
//            }
//            return View(Coral);
//        }

//        [HttpPost]
//        public IActionResult Update(GBRCoralPoint obj, string ShapeWkt)
//        {
//            if (!string.IsNullOrEmpty(ShapeWkt))
//            {
//                try
//                {
//                    var geometryFactory = new GeometryFactory(new PrecisionModel(), 4326); // SRID 4326 for geography
//                    var reader = new WKTReader(geometryFactory);
//                    obj.Point = (Point)reader.Read(ShapeWkt); // Convert WKT to Polygon
//                    obj.Point.SRID = 4326;
//                }
//                catch (Exception ex)
//                {
//                    ModelState.AddModelError("Point", "Invalid point format.");
//                }
//            }

//            if (ModelState.IsValid)
//            {
//                _db.tbl_GBRCoralPoint.Update(obj);
//                _db.SaveChanges();
//                return RedirectToAction("Index");
//            }

//            return View(obj);
//        }
//        //--------------------------------Delete:TODO----------------------------------//

//        public IActionResult Delete(GBRCoralPoint obj) //Delete
//        {
//            _db.tbl_GBRCoralPoint.Remove(obj);
//            _db.SaveChanges();
//            return RedirectToAction("Index");
//        }
//    }
//}
