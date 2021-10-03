using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Test.Data;
using Test.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Test.Controllers
{
    public class HomeController : Controller
    {

        private readonly ApplicationDbContext _context;
        private readonly IHostingEnvironment _he;

        public HomeController(ApplicationDbContext context, IHostingEnvironment he)
        {
            this._context = context;
            this._he = he;
        }

        // GET: Home Index------//


        public async Task<IActionResult> Index(string usertext, string sortOrder, int page)
        //public IActionResult Index(string usertext, string sortOrder)
        {
            //var productTable = _context.Product.ToList();
            //ViewBag.ProductData = productTable;



            ViewBag.sword = usertext;

            ViewBag.sortparam = string.IsNullOrEmpty(sortOrder) ? "desc_name" : "";
            ViewBag.sortsalary = sortOrder == "sal_asc" ? "sal_desc" : "sal_asc";

            IQueryable<Product> application = _context.Product;
            if (!string.IsNullOrEmpty(usertext))
            {
                usertext = usertext.ToLower();
                application = application.Where(a => a.CompanyName.ToLower().Contains(usertext) || a.Details.ToLower().Contains(usertext));
            }
            switch (sortOrder)
            {
                case "desc_name":
                    application = application.OrderByDescending(a => a.CompanyName);
                    break;
                case "sal_asc":
                    application = application.OrderBy(a => a.Details);
                    break;
                case "sal_desc":
                    application = application.OrderByDescending(a => a.Details);
                    break;
                default:
                    application = application.OrderBy(a => a.CompanyName);
                    break;
            }
            ViewBag.count = application.Count();
            if (page <= 0) page = 1;
            int pageSize = 35;
            ViewBag.psize = pageSize;

            return View(await PaginatedList<Product>.CreateAsync(application, page, pageSize));
            //return View(_context.Product.ToList());



        }

        //desktop---------//

        public IActionResult desktop(int page = 1)
        {
            var DesktopTable = _context.Desktop.ToList();
            ViewBag.DesktopData = DesktopTable;


            var data = _context.Desktop
                              .OrderBy(x => x.Id)
                              .Skip((page - 1) * 5)
                              .Take(5);
            int totalPage = (int)Math.Ceiling((decimal)_context.Desktop.Count() / 5);
            ViewBag.Total = totalPage;
            ViewBag.CurrentPage = page;

            return View(data);

            //return View(_context.Desktop.ToList());
        }

        public IActionResult DesktopUpload()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> desktopUpload([Bind("Id,BrandName,Details,Price,Image")] DesktopView desktopView)
        {
            string msg = "";
            if (ModelState.IsValid)
            {
                Dasktop j = new Dasktop();
                j.BrandName = desktopView.BrandName;
                j.Details = desktopView.Details;
                j.Price = desktopView.Price;

                //Image
                string webroot = _he.WebRootPath;
                string folder = "Desktop_img";
                string imgFileName = Path.GetFileName(desktopView.Image.FileName);
                string fileWrite = Path.Combine(webroot, folder, imgFileName);

                using (MemoryStream ms = new MemoryStream())
                {
                    await desktopView.Image.CopyToAsync(ms);

                    j.ImageFile = "/" + folder + "/" + imgFileName;
                }
                using (var stream = new FileStream(fileWrite, FileMode.Create))
                {
                    await desktopView.Image.CopyToAsync(stream);
                }
                _context.Desktop.Add(j);
                await _context.SaveChangesAsync();
                msg = "Product is saved successfully!";
                TempData["msg"] = msg;
                return RedirectToAction(nameof(desktop));

            }
            else
            {
                msg = "Product data is incomplete. Please try again.";
            }
            TempData["msg"] = msg;
            return RedirectToAction("DesktopUpload");

        }


        // GET: Home/desktop-Details----------//

        public async Task<IActionResult> DetailsDesktop(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Dasktop = await _context.Desktop
                .FirstOrDefaultAsync(m => m.Id == id);
            if (Dasktop == null)
            {
                return NotFound();
            }
            var DasktopTable = _context.Desktop.ToList();
            ViewBag.DasktopData = DasktopTable;

            return View(Dasktop);
        }

        // GET: Admin/Edit/Desktop---------//

        //    public async Task<IActionResult> EditDesktop(int? id)
        //    {
        //        if (id == null)
        //        {
        //            return NotFound();
        //        }

        //        var desktop = await _context.Desktop.FindAsync(id);
        //        if (desktop == null)
        //        {
        //            return NotFound();
        //        }
        //        return View(desktop);
        //    }
        //}
        // POST: Home/Edit/EditDesktop--------//
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditDesktop(int id, [Bind("Id,BrandName,Details,Price,Quantity,Image,ImageFile,Description,TextBox")] Dasktop dasktop)
        {
            if (id != dasktop.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dasktop);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(dasktop.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(dasktop);
        }



        //------------//
        public IActionResult DesktopAddToCart(int pid, double qty)
        {
            bool itemFound = false;
            string msg = "";
            if (pid > 0 && qty > 0)
            {
                var dask = _context.Desktop.FirstOrDefault(p => p.Id == pid);
                if (dask != null)
                {
                    List<Dasktop> items = new List<Dasktop>();
                    var xitems = HttpContext.Session.GetObject<List<Dasktop>>("cart");
                    if (xitems != null)
                    {
                        foreach (var item in xitems)
                        {
                            if (pid == item.Id)
                            {
                                item.Quantity += qty;
                                itemFound = true;
                                msg = "Item already added, new qty is added";
                            }
                            items.Add(item);
                        }
                        if (!itemFound)
                        {
                            dask.Quantity = qty;
                            items.Add(dask);
                            msg = "New item is added with existing items.";
                        }
                        HttpContext.Session.SetObject("cart", items);
                    }
                    else
                    {
                        dask.Quantity = qty;
                        items.Add(dask);
                        HttpContext.Session.SetObject("cart", items);
                        msg = "New Item is added to empty cart";
                    }
                }
                else
                {
                    msg = "Item is not found!!";
                }
            }
            else
            {
                msg = "Item Id or qty could not be zero. ";
            }
            TempData["msg"] = msg;
            return RedirectToAction("desktop");
        }

        //Laptops------------//

        public IActionResult Laptops()
        {
            var LaptopTable = _context.Laptop.ToList();
            ViewBag.LaptopData = LaptopTable;

            return View(_context.Laptop.ToList());

        }


        //LaptopUpload----------//

        public IActionResult LaptopUpload()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LaptopUpload([Bind("Id,BrandName,Details,Price,Image")] LaptopView laptopView)
        {
            string msg = "";
            if (ModelState.IsValid)
            {
                Laptop j = new Laptop();
                j.Brand = laptopView.Brand;
                j.Details = laptopView.Details;
                j.Price = laptopView.Price;

                //Image
                string webroot = _he.WebRootPath;
                string folder = "Laptop_img";
                string imgFileName = Path.GetFileName(laptopView.Image.FileName);
                string fileWrite = Path.Combine(webroot, folder, imgFileName);

                using (MemoryStream ms = new MemoryStream())
                {
                    await laptopView.Image.CopyToAsync(ms);

                    j.ImageFile = "/" + folder + "/" + imgFileName;
                }
                using (var stream = new FileStream(fileWrite, FileMode.Create))
                {
                    await laptopView.Image.CopyToAsync(stream);
                }
                _context.Laptop.Add(j);
                await _context.SaveChangesAsync();
                msg = "Product is saved successfully!";
                TempData["msg"] = msg;
                return RedirectToAction(nameof(Laptops));

            }
            else
            {
                msg = "Product data is incomplete. Please try again.";
            }
            TempData["msg"] = msg;
            return RedirectToAction("LaptopUpload");
        }

        // GET: Home/Laptops-Details-----------//
        public async Task<IActionResult> LaptopDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Laptop = await _context.Laptop
                .FirstOrDefaultAsync(m => m.Id == id);
            if (Laptop == null)
            {
                return NotFound();
            }

            var LaptopTable = _context.Laptop.ToList();
            ViewBag.LaptopData = LaptopTable;


            return View(Laptop);
        }

        // POST: Home/EditLaptops--------//
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditLaptops(int id, [Bind("Id,BrandName,Details,Price,Quantity,Image,ImageFile,Description,TextBox")] Laptop laptop)
        {
            if (id != laptop.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(laptop);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(laptop.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(laptop);
        }
        //------------//
        public IActionResult LaptopAddToCart(int pid, double qty)
        {
            bool itemFound = false;
            string msg = "";
            if (pid > 0 && qty > 0)
            {
                var lap = _context.Laptop.FirstOrDefault(p => p.Id == pid);
                if (lap != null)
                {
                    List<Laptop> items = new List<Laptop>();
                    var xitems = HttpContext.Session.GetObject<List<Laptop>>("cart");
                    if (xitems != null)
                    {
                        foreach (var item in xitems)
                        {
                            if (pid == item.Id)
                            {
                                item.Quantity += qty;
                                itemFound = true;
                                msg = "Item already added, new qty is added";
                            }
                            items.Add(item);
                        }
                        if (!itemFound)
                        {
                            lap.Quantity = qty;
                            items.Add(lap);
                            msg = "New item is added with existing items.";
                        }
                        HttpContext.Session.SetObject("cart", items);
                    }
                    else
                    {
                        lap.Quantity = qty;
                        items.Add(lap);
                        HttpContext.Session.SetObject("cart", items);
                        msg = "New Item is added to empty cart";
                    }
                }
                else
                {
                    msg = "Item is not found!!";
                }
            }
            else
            {
                msg = "Item Id or qty could not be zero. ";
            }
            TempData["msg"] = msg;
            return RedirectToAction("Laptops");
        }

        //Baik-----------//
        public IActionResult Baik()
        {
            var BaikTable = _context.Baik.ToList();
            ViewBag.BaikData = BaikTable;

            return View(_context.Baik.ToList());
        }
        //BaikUpload----------//
        public IActionResult BaikUpload()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BaikUpload([Bind("Id,BrandName,Details,Price,Image")] BaikView baikView)
        {
            string msg = "";
            if (ModelState.IsValid)
            {
                Baik j = new Baik();
                j.BranD = baikView.BranD;
                j.Details = baikView.Details;
                j.Price = baikView.Price;

                //Image
                string webroot = _he.WebRootPath;
                string folder = "Baik_img";
                string imgFileName = Path.GetFileName(baikView.Image.FileName);
                string fileWrite = Path.Combine(webroot, folder, imgFileName);

                using (MemoryStream ms = new MemoryStream())
                {
                    await baikView.Image.CopyToAsync(ms);

                    j.ImageFile = "/" + folder + "/" + imgFileName;
                }
                using (var stream = new FileStream(fileWrite, FileMode.Create))
                {
                    await baikView.Image.CopyToAsync(stream);
                }
                _context.Baik.Add(j);
                await _context.SaveChangesAsync();
                msg = "Product is saved successfully!";
                TempData["msg"] = msg;
                return RedirectToAction(nameof(Baik));

            }
            else
            {
                msg = "Product data is incomplete. Please try again.";
            }
            TempData["msg"] = msg;
            return RedirectToAction("BaikUpload");
        }

        // GET: Home/Baik-Details---------//
        public async Task<IActionResult> BaikDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Baik = await _context.Baik
                .FirstOrDefaultAsync(m => m.Id == id);
            if (Baik == null)
            {
                return NotFound();
            }
            var BaikTable = _context.Baik.ToList();
            ViewBag.BaikData = BaikTable;
            return View(Baik);
        }
        // POST: Home/Edit Baik--------//
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BaikEdit(int id, [Bind("Id,BrandName,Details,Price,Quantity,Image,ImageFile,Description,TextBox")] Baik baik)
        {
            if (id != baik.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(baik);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(baik.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Baik));
            }
            return View(baik);
        }

        //------baikAddToCart------//

        public IActionResult baikAddToCart(int pid, double qty)
        {
            bool itemFound = false;
            string msg = "";
            if (pid > 0 && qty > 0)
            {
                var baik = _context.Baik.FirstOrDefault(p => p.Id == pid);
                if (baik != null)
                {
                    List<Baik> items = new List<Baik>();
                    var xitems = HttpContext.Session.GetObject<List<Baik>>("cart");
                    if (xitems != null)
                    {
                        foreach (var item in xitems)
                        {
                            if (pid == item.Id)
                            {
                                item.Quantity += qty;
                                itemFound = true;
                                msg = "Item already added, new qty is added";
                            }
                            items.Add(item);
                        }
                        if (!itemFound)
                        {
                            baik.Quantity = qty;
                            items.Add(baik);
                            msg = "New item is added with existing items.";
                        }
                        HttpContext.Session.SetObject("cart", items);
                    }
                    else
                    {
                        baik.Quantity = qty;
                        items.Add(baik);
                        HttpContext.Session.SetObject("cart", items);
                        msg = "New Item is added to empty cart";
                    }
                }
                else
                {
                    msg = "Item is not found!!";
                }
            }
            else
            {
                msg = "Item Id or qty could not be zero. ";
            }
            TempData["msg"] = msg;
            return RedirectToAction("Baik");
        }

        // GET: Home/Details/Index---------//
        public async Task<IActionResult> Details(int? id /*int page = 1*/)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            var productTable = _context.Product.ToList();
            ViewBag.ProductData = productTable;



            //var data = _context.Product 
            //                  .OrderBy(x => x.Id)
            //                  .Skip((page - 1) * 10)
            //                  .Take(10);
            //int totalPage = (int)Math.Ceiling((decimal)_context.Desktop.Count() / 10);
            //ViewBag.Total = totalPage;
            //ViewBag.CurrentPage = page;

            //return View(data);



            return View(product);

        }

        // GET: Home/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Home/Create---------//
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CompanyName,Details,Price,Description,Image,TextBox")] ProductView productView)
        {
            string msg = "";
            if (ModelState.IsValid)
            {
                Product p = new Product();
                p.CompanyName = productView.CompanyName;
                p.Details = productView.Details;
                p.Price = productView.Price;
                p.Description = productView.Description;
                p.TextBox = productView.TextBox;



                //Image
                string webroot = _he.WebRootPath;
                string folder = "product_image";
                string imgFileName = Path.GetFileName(productView.Image.FileName);
                string fileWrite = Path.Combine(webroot, folder, imgFileName);

                using (MemoryStream ms = new MemoryStream())
                {
                    await productView.Image.CopyToAsync(ms);

                    p.ImageFile = "/" + folder + "/" + imgFileName;
                    
                }
                using (var stream = new FileStream(fileWrite, FileMode.Create))
                {
                    await productView.Image.CopyToAsync(stream);
                }
                _context.Add(p);
                await _context.SaveChangesAsync();
                msg = "Product is saved successfully!";
                TempData["msg"] = msg;
                return RedirectToAction(nameof(Index));

            }
            else
            {
                msg = "Product data is incomplete. Please try again.";
            }
            TempData["msg"] = msg;
            return RedirectToAction("Create");

        }

        // GET: Home/Edit/5------------//
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: Home/Edit/5----------//
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CompanyName,Unit,Price,ImageFile")] Product product)
        {
            if (id != product.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Home/Delete/5---------//
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Home/Delete/5---------//
        [HttpPost, ActionName("Delete")]        
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Product.FindAsync(id);
            _context.Product.Remove(product);           

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }

        private bool ProductExists(int id)
        {
            return _context.Product.Any(e => e.Id == id);
        }

        //ShowCart--------------//

        public IActionResult ShowCart()
        {
            List<Product> items = new List<Product>();
            var xitems = HttpContext.Session.GetObject<List<Product>>("cart");
            if (xitems != null)
            {
                return View(xitems);
            }
            else
            {
                return View();
            }
        }
        //AddToCart------------//

        public IActionResult AddToCart(int pid, double qty)
        {
            bool itemFound = false;
            string msg = "";
            if (pid > 0 && qty > 0)
            {
                var prod = _context.Product.FirstOrDefault(p => p.Id == pid);
                if (prod != null)
                {
                    List<Product> items = new List<Product>();
                    var xitems = HttpContext.Session.GetObject<List<Product>>("cart");
                    if (xitems != null)
                    {
                        foreach (var item in xitems)
                        {
                            if (pid == item.Id)
                            {
                                item.Quantity += qty;
                                itemFound = true;
                                msg = "Item already added, new qty is added";
                            }
                            items.Add(item);
                        }
                        if (!itemFound)
                        {
                            prod.Quantity = qty;
                            items.Add(prod);
                            msg = "New item is added with existing items.";
                        }
                        HttpContext.Session.SetObject("cart", items);
                    }
                    else
                    {
                        prod.Quantity = qty;
                        items.Add(prod);
                        HttpContext.Session.SetObject("cart", items);
                        msg = "New Item is added to empty cart";
                    }
                }
                else
                {
                    msg = "Item is not found!!";
                }
            }
            else
            {
                msg = "Item Id or qty could not be zero. ";
            }
            TempData["msg"] = msg;
            return RedirectToAction("Index");
        }

        //Product details AddToCart------------//

        //public IActionResult ProductdetailsAddToCart(int pid, double qty)
        //{
        //    bool itemFound = false;
        //    string msg = "";
        //    if (pid > 0 && qty > 0)
        //    {
        //        var pro = _context.Product.FirstOrDefault(p => p.Id == pid);
        //        if (pro != null)
        //        {
        //            List<Product> items = new List<Product>();
        //            var xitems = HttpContext.Session.GetObject<List<Product>>("cart");
        //            if (xitems != null)
        //            {
        //                foreach (var item in xitems)
        //                {
        //                    if (pid == item.Id)
        //                    {
        //                        item.Quantity += qty;
        //                        itemFound = true;
        //                        msg = "Item already added, new qty is added";
        //                    }
        //                    items.Add(item);
        //                }
        //                if (!itemFound)
        //                {
        //                    pro.Quantity = qty;
        //                    items.Add(pro);
        //                    msg = "New item is added with existing items.";
        //                }
        //                HttpContext.Session.SetObject("cart", items);
        //            }
        //            else
        //            {
        //                pro.Quantity = qty;
        //                items.Add(pro);
        //                HttpContext.Session.SetObject("cart", items);
        //                msg = "New Item is added to empty cart";
        //            }
        //        }
        //        else
        //        {
        //            msg = "Item is not found!!";
        //        }
        //    }
        //    else
        //    {
        //        msg = "Item Id or qty could not be zero. ";
        //    }
        //    TempData["msg"] = msg;
        //    return RedirectToAction("Details");
        //}

        //--------------//

        //RemoveFromCart----------//

        public IActionResult RemoveFromCart(int id)
        {
            if (id > 0)
            {
                List<Product> items = new List<Product>();
                var xitems = HttpContext.Session.GetObject<List<Product>>("cart");
                if (xitems != null)
                {
                    var prod = xitems.FirstOrDefault(p => p.Id == id);
                    if (prod != null)
                    {
                        xitems.Remove(prod);
                    }
                    HttpContext.Session.SetObject("cart", xitems);
                    return RedirectToAction("ShowCart");
                }
            }
            return RedirectToAction("Index");
        }



        //CheckOut---------//

        [Authorize]
        public IActionResult CheckOut()
        {
            //var us = HttpContext.Session.GetString("un");
            //var id = HttpContext.Session.GetString("id");

            var orderAddressTable = _context.OrderAddress.ToList();
            ViewBag.OrderAddressData = orderAddressTable;

            ViewBag.Area = new SelectList(GetArea(), "Id", "Text");
            ViewBag.City = new SelectList(GetCity(), "Id", "Text");

            return View();

        }



        [HttpPost]

        public ActionResult CheckOut(OrderAddress t)
        {        
            if (ModelState.IsValid)
            {
                _context.OrderAddress.Add(t);
                _context.SaveChanges();
                //return RedirectToAction("CheckOut");
                return RedirectToAction("submit");
            }
            ViewBag.Area = new SelectList(GetArea(), "Id", "Text");
            ViewBag.City = new SelectList(GetCity(), "Id", "Text");

            return View(t);
            
        }


        private List<AreaModel> GetArea()
        {
            return new List<AreaModel>()
            {
                new AreaModel(){ Id = 1, Text = "Wari"},
                new AreaModel(){ Id = 2, Text = "Motijheel"},
                new AreaModel(){ Id = 4, Text = "Polton" },
                new AreaModel(){ Id = 5, Text = "Shahbag" },
                new AreaModel(){ Id = 6, Text = "Elephant road" },
                new AreaModel(){ Id = 7, Text = "Newmarket" },
                new AreaModel(){ Id = 8, Text = "Panthapath" },
                new AreaModel(){ Id = 9, Text = "Mohakhali" },
                new AreaModel(){ Id = 10, Text = "Gulshan" },
                new AreaModel(){ Id = 11, Text = "banani" },
            };
        }
        private List<City> GetCity()
        {
            return new List<City>()
            {
                new City(){ Id = 1, Text = "Dhaka"},

            };
        }

        //OrderAddress-----------//

        public IActionResult OrderAddress()
        {
            return View(_context.OrderAddress.ToList());

        }
        public IActionResult submit()
        {
            return View();

        }
        //------- AllShops----//
        public IActionResult AllShops()
        {
            //var productTable = _context.Product.ToList();
            //ViewBag.ProductData = productTable;
            var productTable = _context.Product.ToList();
            ViewBag.productData = productTable;

            return View(_context.Product.ToList());
        }

        public IActionResult GiftCard()
        {
            return View();
        }
        public IActionResult Campaign()
        {
            return View();
        }
        
        public IActionResult FAQ()
        {
            return View();
        }
        //.....Index home cart//
        public IActionResult Aarong()
        {
            return View(_context.Aarong.ToList());
        }
        //....Aarong Add to cart.....//
        public IActionResult AarongAddToCart(int pid, double qty)
        {
            bool itemFound = false;
            string msg = "";
            if (pid > 0 && qty > 0)
            {
                var aaro = _context.Aarong.FirstOrDefault(p => p.Id == pid);
                if (aaro != null)
                {
                    List<Aarong> items = new List<Aarong>();
                    var xitems = HttpContext.Session.GetObject<List<Aarong>>("cart");
                    if (xitems != null)
                    {
                        foreach (var item in xitems)
                        {
                            if (pid == item.Id)
                            {
                                item.Quantity += qty;
                                itemFound = true;
                                msg = "Item already added, new qty is added";
                            }
                            items.Add(item);
                        }
                        if (!itemFound)
                        {
                            aaro.Quantity = qty;
                            items.Add(aaro);
                            msg = "New item is added with existing items.";
                        }
                        HttpContext.Session.SetObject("cart", items);
                    }
                    else
                    {
                        aaro.Quantity = qty;
                        items.Add(aaro);
                        HttpContext.Session.SetObject("cart", items);
                        msg = "New Item is added to empty cart";
                    }
                }
                else
                {
                    msg = "Item is not found!!";
                }
            }
            else
            {
                msg = "Item Id or qty could not be zero. ";
            }
            TempData["msg"] = msg;
            return RedirectToAction("Aarong");
        }
//....Aarong Add to cart end.....//

        public IActionResult BdFood()
        {
            return View(_context.BdFood.ToList());
        }
        //....BdFood Add to cart.....//
        public IActionResult BdFoodAddToCart(int pid, double qty)
        {
            bool itemFound = false;
            string msg = "";
            if (pid > 0 && qty > 0)
            {
                var bd = _context.BdFood.FirstOrDefault(p => p.Id == pid);
                if (bd != null)
                {
                    List<BdFood> items = new List<BdFood>();
                    var xitems = HttpContext.Session.GetObject<List<BdFood>>("cart");
                    if (xitems != null)
                    {
                        foreach (var item in xitems)
                        {
                            if (pid == item.Id)
                            {
                                item.Quantity += qty;
                                itemFound = true;
                                msg = "Item already added, new qty is added";
                            }
                            items.Add(item);
                        }
                        if (!itemFound)
                        {
                            bd.Quantity = qty;
                            items.Add(bd);
                            msg = "New item is added with existing items.";
                        }
                        HttpContext.Session.SetObject("cart", items);
                    }
                    else
                    {
                        bd.Quantity = qty;
                        items.Add(bd);
                        HttpContext.Session.SetObject("cart", items);
                        msg = "New Item is added to empty cart";
                    }
                }
                else
                {
                    msg = "Item is not found!!";
                }
            }
            else
            {
                msg = "Item Id or qty could not be zero. ";
            }
            TempData["msg"] = msg;
            return RedirectToAction("BdFood");
        }
        //....BdFood end.....//

        public IActionResult Lux()
        {
            return View(_context.Lux.ToList());
        }
        //....Lux Add to cart.....//
        public IActionResult LuxAddToCart(int pid, double qty)
        {
            bool itemFound = false;
            string msg = "";
            if (pid > 0 && qty > 0)
            {
                var lax = _context.Lux.FirstOrDefault(p => p.Id == pid);
                if (lax != null)
                {
                    List<Lux> items = new List<Lux>();
                    var xitems = HttpContext.Session.GetObject<List<Lux>>("cart");
                    if (xitems != null)
                    {
                        foreach (var item in xitems)
                        {
                            if (pid == item.Id)
                            {
                                item.Quantity += qty;
                                itemFound = true;
                                msg = "Item already added, new qty is added";
                            }
                            items.Add(item);
                        }
                        if (!itemFound)
                        {
                            lax.Quantity = qty;
                            items.Add(lax);
                            msg = "New item is added with existing items.";
                        }
                        HttpContext.Session.SetObject("cart", items);
                    }
                    else
                    {
                        lax.Quantity = qty;
                        items.Add(lax);
                        HttpContext.Session.SetObject("cart", items);
                        msg = "New Item is added to empty cart";
                    }
                }
                else
                {
                    msg = "Item is not found!!";
                }
            }
            else
            {
                msg = "Item Id or qty could not be zero. ";
            }
            TempData["msg"] = msg;
            return RedirectToAction("Lux");
        }
        //....Lux end.....//
        public IActionResult Shopno()
        {
            return View(_context.Shopno.ToList());
        }
        //....Shopno Add to cart.....//
        public IActionResult ShopnoAddToCart(int pid, double qty)
        {
            bool itemFound = false;
            string msg = "";
            if (pid > 0 && qty > 0)
            {
                var sop = _context.Shopno.FirstOrDefault(p => p.Id == pid);
                if (sop != null)
                {
                    List<Shopno> items = new List<Shopno>();
                    var xitems = HttpContext.Session.GetObject<List<Shopno>>("cart");
                    if (xitems != null)
                    {
                        foreach (var item in xitems)
                        {
                            if (pid == item.Id)
                            {
                                item.Quantity += qty;
                                itemFound = true;
                                msg = "Item already added, new qty is added";
                            }
                            items.Add(item);
                        }
                        if (!itemFound)
                        {
                            sop.Quantity = qty;
                            items.Add(sop);
                            msg = "New item is added with existing items.";
                        }
                        HttpContext.Session.SetObject("cart", items);
                    }
                    else
                    {
                        sop.Quantity = qty;
                        items.Add(sop);
                        HttpContext.Session.SetObject("cart", items);
                        msg = "New Item is added to empty cart";
                    }
                }
                else
                {
                    msg = "Item is not found!!";
                }
            }
            else
            {
                msg = "Item Id or qty could not be zero. ";
            }
            TempData["msg"] = msg;
            return RedirectToAction("Shopno");
        }
        //....Shopno end.....//
        public IActionResult Unilever()
        {
            return View(_context.Unilever.ToList());
        }
        //....Unilever Add to cart.....//
        public IActionResult UnileverAddToCart(int pid, double qty)
        {
            bool itemFound = false;
            string msg = "";
            if (pid > 0 && qty > 0)
            {
                var uni = _context.Unilever.FirstOrDefault(p => p.Id == pid);
                if (uni != null)
                {
                    List<Unilever> items = new List<Unilever>();
                    var xitems = HttpContext.Session.GetObject<List<Unilever>>("cart");
                    if (xitems != null)
                    {
                        foreach (var item in xitems)
                        {
                            if (pid == item.Id)
                            {
                                item.Quantity += qty;
                                itemFound = true;
                                msg = "Item already added, new qty is added";
                            }
                            items.Add(item);
                        }
                        if (!itemFound)
                        {
                            uni.Quantity = qty;
                            items.Add(uni);
                            msg = "New item is added with existing items.";
                        }
                        HttpContext.Session.SetObject("cart", items);
                    }
                    else
                    {
                        uni.Quantity = qty;
                        items.Add(uni);
                        HttpContext.Session.SetObject("cart", items);
                        msg = "New Item is added to empty cart";
                    }
                }
                else
                {
                    msg = "Item is not found!!";
                }
            }
            else
            {
                msg = "Item Id or qty could not be zero. ";
            }
            TempData["msg"] = msg;
            return RedirectToAction("Unilever");
        }
        //....Unilever end.....//
        public IActionResult AmanFeed()
        {
            return View();
        }
        public IActionResult Tshirt()
        {
            return View();
        }
        public IActionResult Aci()
        {
            return View();
        }
        public IActionResult Dano()
        {
            return View();
        }
        public IActionResult Fresh()
        {
            return View();
        }
        public IActionResult Lifebuoy()
        {
            return View();
        }
        public IActionResult Primier()
        {
            return View(_context.Primier.ToList());
        }
        //....Primier Add to cart.....//
        public IActionResult PrimierAddToCart(int pid, double qty)
        {
            bool itemFound = false;
            string msg = "";
            if (pid > 0 && qty > 0)
            {
                var pri = _context.Primier.FirstOrDefault(p => p.Id == pid);
                if (pri != null)
                {
                    List<Primier> items = new List<Primier>();
                    var xitems = HttpContext.Session.GetObject<List<Primier>>("cart");
                    if (xitems != null)
                    {
                        foreach (var item in xitems)
                        {
                            if (pid == item.Id)
                            {
                                item.Quantity += qty;
                                itemFound = true;
                                msg = "Item already added, new qty is added";
                            }
                            items.Add(item);
                        }
                        if (!itemFound)
                        {
                            pri.Quantity = qty;
                            items.Add(pri);
                            msg = "New item is added with existing items.";
                        }
                        HttpContext.Session.SetObject("cart", items);
                    }
                    else
                    {
                        pri.Quantity = qty;
                        items.Add(pri);
                        HttpContext.Session.SetObject("cart", items);
                        msg = "New Item is added to empty cart";
                    }
                }
                else
                {
                    msg = "Item is not found!!";
                }
            }
            else
            {
                msg = "Item Id or qty could not be zero. ";
            }
            TempData["msg"] = msg;
            return RedirectToAction("Primier");
        }
        //....Premier end.....//
        public IActionResult Jamuna()
        {
            return View();
        }
        public IActionResult Efood()
        {
            return View(_context.Efood.ToList());
        }
        //....Efood Add to cart.....//
        public IActionResult EfoodAddToCart(int pid, double qty)
        {
            bool itemFound = false;
            string msg = "";
            if (pid > 0 && qty > 0)
            {
                var efood = _context.Efood.FirstOrDefault(p => p.Id == pid);
                if (efood != null)
                {
                    List<Efood> items = new List<Efood>();
                    var xitems = HttpContext.Session.GetObject<List<Efood>>("cart");
                    if (xitems != null)
                    {
                        foreach (var item in xitems)
                        {
                            if (pid == item.Id)
                            {
                                item.Quantity += qty;
                                itemFound = true;
                                msg = "Item already added, new qty is added";
                            }
                            items.Add(item);
                        }
                        if (!itemFound)
                        {
                            efood.Quantity = qty;
                            items.Add(efood);
                            msg = "New item is added with existing items.";
                        }
                        HttpContext.Session.SetObject("cart", items);
                    }
                    else
                    {
                        efood.Quantity = qty;
                        items.Add(efood);
                        HttpContext.Session.SetObject("cart", items);
                        msg = "New Item is added to empty cart";
                    }
                }
                else
                {
                    msg = "Item is not found!!";
                }
            }
            else
            {
                msg = "Item Id or qty could not be zero. ";
            }
            TempData["msg"] = msg;
            return RedirectToAction("Efood");
        }
        //....Efood end.....//
      
        public IActionResult ContactUs()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ContactUs(Contact t)
        {
            if (ModelState.IsValid)
            {
                _context.Contact.Add(t);
                _context.SaveChanges();
                return RedirectToAction("ContactUs");
            }
            return View(t);
        }      
    }
    }

