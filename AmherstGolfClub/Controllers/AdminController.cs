﻿using AmherstGolfClub.DAL;
using AmherstGolfClub.Models;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace AmherstGolfClub.Controllers
{
    public class AdminController : Controller
    {
        private GolfContext db = new GolfContext();

        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(HttpPostedFileBase CSVName)
        {
            string path = null;
            var ProductsToDisplay = new List<Product>();
            try
            {
                if (CSVName.ContentLength > 0)
                {
                    var fileName = Path.GetFileName(CSVName.FileName);
                    path = AppDomain.CurrentDomain.BaseDirectory + "upload\\" + fileName;
                    CSVName.SaveAs(path);

                    var csv = new CsvReader(new StreamReader(path));
                    var db = new GolfContext();
                    db.Database.ExecuteSqlCommand("delete from products");
                    db.Database.ExecuteSqlCommand("DBCC CHECKIDENT ('[products]', RESEED, 0);");
                    int count = 0;
                    
                    while (csv.Read())
                    {
                        Product product = new Product();
                        product.ProductID =+ 1;              
                        product.Name = csv.GetField<string>(0);                        
                        product.Price = csv.GetField<string>(2);
                        product.Quantity = csv.GetField<string>(3);
                        product.SubDepartment = csv.GetField<string>(7);
                        product.ItemCategory = csv.GetField<string>(8);                        
                        ProductsToDisplay.Add(product);
                        var exists = db.Products.Where(i=>i.ProductID == product.ProductID).SingleOrDefault();
                        if (exists == null)
                        {
                            db.Products.Add(product);
                            db.SaveChanges();
                            count += 1;
                        }                        
                    }
                    ViewBag.RecordsUploaded = ProductsToDisplay.Count();
                    ViewBag.RecordsSaved = count;
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }

            return View(ProductsToDisplay);
        }
    }
}