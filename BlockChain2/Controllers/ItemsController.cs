using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BlockChain2.DAL;
using BlockChain2.Models;

namespace BlockChain2.Controllers
{
    public class ItemsController : Controller
    {
        //private BlockchainContext db = new BlockchainContext();
        //return View(db.Items.ToList());
        public static string[] certs = { "Organic ", "Grass-fed ", "Pesticide-free ", "Green " };
        public static string[] test1 = { "Organic ", "Grass-fed " };
        public static string[] test2 = { "Pesticide-free ", "Green " };
        public static string[] test3 = { "Organic ", "Grass-fed ", "Green " };
        public static string[] test4 = { "Organic ", "Pesticide-free " };

        public static List<Item> lstItems = new List<Item>() {
            new Item(1, "cow", "12343", 1, test1),
            new Item(1, "wheat", "19854", 55, certs),
            new Item(1, "peas", "46494", 108, test2),
            new Item(1, "goat", "93847", 3, test3),
            new Item(1, "chickens", "243545", 12, test4),
            new Item(1, "heifer", "92174", 1, test1)
        };
        
        public static List<string> lstCert = new List<string>(certs);

        // GET: Items
        public ActionResult Index()
        {
            return View(lstItems);
        }

        // GET: Items/Details/5
        public ActionResult Details(int id)
        {
            Item item = lstItems[id - 1];
            if (item == null)
            {
                return HttpNotFound();
            }
            return View(item);
        }

        // GET: Items/Create
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Certs = lstCert;
            return View();
        }

        // POST: Items/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Create(Item item)
        {
            if (ModelState.IsValid)
            {
                item.itemID = lstItems.Count() + 1;
                lstItems.Add(item);
                return RedirectToAction("Index", lstItems);
            }
            else
            {
                return View(item);
            }
        }

        // GET: Items/Edit/5
        public ActionResult Edit(int id)
        {
            Item item = lstItems[id- 1];
            if (item == null)
            {
                return HttpNotFound();
            }
            return View(item);
        }

        // POST: Items/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Item item)
        {
            if (ModelState.IsValid)
            {
                lstItems[item.itemID].itemName = item.itemName;
                lstItems[item.itemID].serialNumber = item.serialNumber;
                lstItems[item.itemID].quantityOfItem = item.quantityOfItem;
                //db.Entry(item).State = EntityState.Modified;
                //db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(item);
        }

        // GET: Items/Delete/5
        public ActionResult Delete(int id)
        {
            Item item = lstItems[id];
            if (item == null)
            {
                return HttpNotFound();
            }
            return View(item);
        }

        // POST: Items/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    Item item = lstItems[id];
        //    lstItems.Remove(item);
        //    //db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        //db.Dispose();
        //        lstItems.Clear();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
