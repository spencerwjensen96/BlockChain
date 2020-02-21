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
        List<Item> lstItems = new List<Item>();

        // GET: Items
        public ActionResult Index()
        {
            return View(lstItems.ToList());
        }

        // GET: Items/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Item item = lstItems[id];
            if (item == null)
            {
                return HttpNotFound();
            }
            return View(item);
        }

        // GET: Items/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Items/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "itemID,itemName,serialNumber,quantityOfItem")] Item item)
        {
            if (ModelState.IsValid)
            {
                lstItems.Add(item);
                //db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(item);
        }

        // GET: Items/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Item item = lstItems[id];
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
        public ActionResult Edit([Bind(Include = "itemID,itemName,serialNumber,quantityOfItem")] Item item)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(item).State = EntityState.Modified;
                //db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(item);
        }

        // GET: Items/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Item item = lstItems[id];
            if (item == null)
            {
                return HttpNotFound();
            }
            return View(item);
        }

        // POST: Items/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Item item = lstItems[id];
            lstItems.Remove(item);
            //db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                //db.Dispose();
                lstItems.Clear();
            }
            base.Dispose(disposing);
        }
    }
}
