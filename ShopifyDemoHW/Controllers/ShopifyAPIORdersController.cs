using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ShopifyDemoHW.Models;

namespace ShopifyDemoHW.Controllers
{
    public class ShopifyAPIORdersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ShopifyAPIORders
        public async Task<ActionResult> Index()
        {
            return View(await db.ShopifyAPIORders.ToListAsync());
        }

        // GET: ShopifyAPIORders/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShopifyAPIORders shopifyAPIORders = await db.ShopifyAPIORders.FindAsync(id);
            if (shopifyAPIORders == null)
            {
                return HttpNotFound();
            }
            return View(shopifyAPIORders);
        }

        // GET: ShopifyAPIORders/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ShopifyAPIORders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "id")] ShopifyAPIORders shopifyAPIORders)
        {
            if (ModelState.IsValid)
            {
                db.ShopifyAPIORders.Add(shopifyAPIORders);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(shopifyAPIORders);
        }

        // GET: ShopifyAPIORders/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShopifyAPIORders shopifyAPIORders = await db.ShopifyAPIORders.FindAsync(id);
            if (shopifyAPIORders == null)
            {
                return HttpNotFound();
            }
            return View(shopifyAPIORders);
        }

        // POST: ShopifyAPIORders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "id")] ShopifyAPIORders shopifyAPIORders)
        {
            if (ModelState.IsValid)
            {
                db.Entry(shopifyAPIORders).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(shopifyAPIORders);
        }

        // GET: ShopifyAPIORders/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShopifyAPIORders shopifyAPIORders = await db.ShopifyAPIORders.FindAsync(id);
            if (shopifyAPIORders == null)
            {
                return HttpNotFound();
            }
            return View(shopifyAPIORders);
        }

        // POST: ShopifyAPIORders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            ShopifyAPIORders shopifyAPIORders = await db.ShopifyAPIORders.FindAsync(id);
            db.ShopifyAPIORders.Remove(shopifyAPIORders);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
