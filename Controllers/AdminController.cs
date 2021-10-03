using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Test.Data;
using Test.Models;

namespace Test.Controllers
{
    [Authorize(Policy = "AdminTypeUser")]

    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IHostingEnvironment _he;

        public AdminController(ApplicationDbContext context, IHostingEnvironment he)
        {
            this._context = context;
            this._he = he;
        }

        // GET: Admin-------//

        public async Task<IActionResult> Index()
        {
            var productTable = _context.Product.ToList();
            ViewBag.ProductData = productTable;

            return View(await _context.Product.ToListAsync());
        }

        public async Task<IActionResult> HomeProduct()
        {
           
            

            return View(await _context.Product.ToListAsync());
        }


        // GET: Admin/Details/5-----//

        public async Task<IActionResult> Details(int? id)
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

        // GET: Admin/Create-------//

        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CompanyName,Details,Description,Price,Image,TextBox")] ProductView productView)
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
                    //p.ImageFile = folder + "/" + imgFileName;
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

        //Admin desktop//

        public IActionResult desktop()
        {
            return View(_context.Desktop.ToList());
        }

        public IActionResult DesktopUpload()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> desktopUpload([Bind("Id,BrandName,Details,Price,Image,Description,TextBox")] DesktopView desktopView)
        {
            string msg = "";
            if (ModelState.IsValid)
            {
                Dasktop j = new Dasktop();
                j.BrandName = desktopView.BrandName;
                j.Details = desktopView.Details;
                j.Price = desktopView.Price;
                j.Description = desktopView.Description;
                j.TextBox = desktopView.TextBox;

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

        // GET: Admin/Edit/Desktop---------//

        public async Task<IActionResult> EditDesktop(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var desktop = await _context.Desktop.FindAsync(id);
            if (desktop == null)
            {
                return NotFound();
            }
            return View(desktop);
        }
        // POST: Admin/Edit/EditDesktop--------//
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


        // GET: Admin/Details-Desktop/6-----//

        public async Task<IActionResult> DetailsDesktop(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var desktop = await _context.Desktop
                .FirstOrDefaultAsync(m => m.Id == id);
            if (desktop == null)
            {
                return NotFound();
            }

            return View(desktop);
        }
        // GET: Admin/Delete-Desktop/5-------//

        public async Task<IActionResult> DeleteDesktop(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var desktop = await _context.Desktop
                .FirstOrDefaultAsync(m => m.Id == id);
            if (desktop == null)
            {
                return NotFound();
            }

            return View(desktop);
        }

        // POST: Admin/Delete-Desktop/6-----------//
        [HttpPost, ActionName("DeleteDesktop")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteDesktopConfirmed(int id)
        {
            var desktop = await _context.Desktop.FindAsync(id);
            _context.Desktop.Remove(desktop);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DesktopExists(int id)
        {
            return _context.Desktop.Any(e => e.Id == id);
        }
        //Laptops------------//

        public IActionResult Laptops()
        {
            var LaptopTable = _context.Laptop.ToList();
            ViewBag.LaptopData = LaptopTable;

            return View(_context.Laptop.ToList());

        }

        //Laptop-Upload----------//

        public IActionResult LaptopUpload()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LaptopUpload([Bind("Id,Brand,Details,Price,Image,Description,TextBox")] LaptopView laptopView)
        {
            string msg = "";
            if (ModelState.IsValid)
            {
                Laptop j = new Laptop();
                j.Brand = laptopView.Brand;
                j.Details = laptopView.Details;
                j.Price = laptopView.Price;
                j.Description = laptopView.Description;
                j.TextBox = laptopView.TextBox;

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
        public async Task<IActionResult> BaikUpload([Bind("Id,BranD,Details,Price,Image,Description,TextBox")] BaikView baikView)
        {
            string msg = "";
            if (ModelState.IsValid)
            {
                Baik j = new Baik();
                j.BranD = baikView.BranD;
                j.Details = baikView.Details;
                j.Price = baikView.Price;
                j.Description = baikView.Description;
                j.TextBox = baikView.TextBox;

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




        // GET: Admin/Edit/5---------//

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
        // POST: Admin/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CompanyName,Details,Price,Quantity,Image,ImageFile,Description,TextBox")] Product product)
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

        // GET: Admin/Delete/5-------//

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

        // POST: Admin/Delete/5-----------//
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Product.FindAsync(id);
            _context.Product.Remove(product);
            /*-------------Start Change--------------*/
            int count = product.ImageFile.Count();
            char[] imgfileName = product.ImageFile.ToCharArray();
            string orginalfilename = string.Empty;

            for(int i = 1; i < count; i++)
            {
                orginalfilename = orginalfilename + imgfileName[i].ToString();
            }

            string rootPath = _he.WebRootPath;
            string fullpath = Path.Combine(rootPath, orginalfilename);
            System.IO.File.Delete(fullpath);
            /*-------------End Change--------------*/
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Product.Any(e => e.Id == id);
        }
        //.......Admin Index Home card........//
        public IActionResult Aarong()
        {
            return View(_context.Aarong.ToList());
        }
        public IActionResult AarongUpload()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>AarongUpload([Bind("Id,CompanyName,Details,Price,Image,Description,TextBox")] AarongView aarongView)
        {
            string msg = "";
            if (ModelState.IsValid)
            {
                Aarong j = new Aarong();
                j.CompanyName = aarongView.CompanyName;
                j.Details = aarongView.Details;
                j.Price = aarongView.Price;
                j.Description = aarongView.Description;
                j.TextBox = aarongView.TextBox;

                //Image
                string webroot = _he.WebRootPath;
                string folder = "Aarong";
                string imgFileName = Path.GetFileName(aarongView.Image.FileName);
                string fileWrite = Path.Combine(webroot, folder, imgFileName);

                using (MemoryStream ms = new MemoryStream())
                {
                    await aarongView.Image.CopyToAsync(ms);

                    j.ImageFile = "/" + folder + "/" + imgFileName;
                }
                using (var stream = new FileStream(fileWrite, FileMode.Create))
                {
                    await aarongView.Image.CopyToAsync(stream);
                }
                _context.Aarong.Add(j);
                await _context.SaveChangesAsync();
                msg = "Product is saved successfully!";
                TempData["msg"] = msg;
                return RedirectToAction(nameof(Aarong));

            }
            else
            {
                msg = "Product data is incomplete. Please try again.";
            }
            TempData["msg"] = msg;
            return RedirectToAction("AarongUpload");
        }
        public IActionResult BdFood()
        {
            return View(_context.BdFood.ToList());
        }
        public IActionResult BdFoodUpload()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BdFoodUpload([Bind("Id,CompanyName,Details,Price,Image,Description,TextBox")] BdFoodView bdFoodView)
        {
            string msg = "";
            if (ModelState.IsValid)
            {
                BdFood j = new BdFood();
                j.CompanyName = bdFoodView.CompanyName;
                j.Details = bdFoodView.Details;
                j.Price = bdFoodView.Price;
                j.Description = bdFoodView.Description;
                j.TextBox = bdFoodView.TextBox;

                //Image
                string webroot = _he.WebRootPath;
                string folder = "BdFood";
                string imgFileName = Path.GetFileName(bdFoodView.Image.FileName);
                string fileWrite = Path.Combine(webroot, folder, imgFileName);

                using (MemoryStream ms = new MemoryStream())
                {
                    await bdFoodView.Image.CopyToAsync(ms);

                    j.ImageFile = "/" + folder + "/" + imgFileName;
                }
                using (var stream = new FileStream(fileWrite, FileMode.Create))
                {
                    await bdFoodView.Image.CopyToAsync(stream);
                }
                _context.BdFood.Add(j);
                await _context.SaveChangesAsync();
                msg = "Product is saved successfully!";
                TempData["msg"] = msg;
                return RedirectToAction(nameof(BdFood));

            }
            else
            {
                msg = "Product data is incomplete. Please try again.";
            }
            TempData["msg"] = msg;
            return RedirectToAction("BdFoodUpload");
        }
        public IActionResult Lux()
        {
            return View(_context.Lux.ToList());
        }
        public IActionResult LuxUpload()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>LuxUpload([Bind("Id,CompanyName,Details,Price,Image,Description,TextBox")] LuxView luxView)
        {
            string msg = "";
            if (ModelState.IsValid)
            {
                Lux j = new Lux();
                j.CompanyName = luxView.CompanyName;
                j.Details = luxView.Details;
                j.Price = luxView.Price;
                j.Description = luxView.Description;
                j.TextBox = luxView.TextBox;

                //Image
                string webroot = _he.WebRootPath;
                string folder = "Lux";
                string imgFileName = Path.GetFileName(luxView.Image.FileName);
                string fileWrite = Path.Combine(webroot, folder, imgFileName);

                using (MemoryStream ms = new MemoryStream())
                {
                    await luxView.Image.CopyToAsync(ms);

                    j.ImageFile = "/" + folder + "/" + imgFileName;
                }
                using (var stream = new FileStream(fileWrite, FileMode.Create))
                {
                    await luxView.Image.CopyToAsync(stream);
                }
                _context.Lux.Add(j);
                await _context.SaveChangesAsync();
                msg = "Product is saved successfully!";
                TempData["msg"] = msg;
                return RedirectToAction(nameof(Lux));
            }
            else
            {
                msg = "Product data is incomplete. Please try again.";
            }
            TempData["msg"] = msg;
            return RedirectToAction("LuxUpload");
        }

        public IActionResult Shopno()
        {
            return View(_context.Shopno.ToList());
        }
        public IActionResult ShopnoUpload()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ShopnoUpload([Bind("Id,CompanyName,Details,Price,Image,Description,TextBox")] ShopnoView shopnoView)
        {
            string msg = "";
            if (ModelState.IsValid)
            {
                Shopno j = new Shopno();
                j.CompanyName = shopnoView.CompanyName;
                j.Details = shopnoView.Details;
                j.Price = shopnoView.Price;
                j.Description = shopnoView.Description;
                j.TextBox = shopnoView.TextBox;

                //Image
                string webroot = _he.WebRootPath;
                string folder = "Shopno";
                string imgFileName = Path.GetFileName(shopnoView.Image.FileName);
                string fileWrite = Path.Combine(webroot, folder, imgFileName);

                using (MemoryStream ms = new MemoryStream())
                {
                    await shopnoView.Image.CopyToAsync(ms);

                    j.ImageFile = "/" + folder + "/" + imgFileName;
                }
                using (var stream = new FileStream(fileWrite, FileMode.Create))
                {
                    await shopnoView.Image.CopyToAsync(stream);
                }
                _context.Shopno.Add(j);
                await _context.SaveChangesAsync();
                msg = "Product is saved successfully!";
                TempData["msg"] = msg;
                return RedirectToAction(nameof(Shopno));
            }
            else
            {
                msg = "Product data is incomplete. Please try again.";
            }
            TempData["msg"] = msg;
            return RedirectToAction("ShopnoUpload");
        }
        public IActionResult Unilever()
        {
            return View(_context.Unilever.ToList());
        }
        public IActionResult UnileverUpload()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>UnileverUpload([Bind("Id,CompanyName,Details,Price,Image,Description,TextBox")] UnileverView unileverView)
        {
            string msg = "";
            if (ModelState.IsValid)
            {
                Unilever j = new Unilever();
                j.CompanyName = unileverView.CompanyName;
                j.Details = unileverView.Details;
                j.Price = unileverView.Price;
                j.Description = unileverView.Description;
                j.TextBox = unileverView.TextBox;

                //Image
                string webroot = _he.WebRootPath;
                string folder = "Unilever";
                string imgFileName = Path.GetFileName(unileverView.Image.FileName);
                string fileWrite = Path.Combine(webroot, folder, imgFileName);

                using (MemoryStream ms = new MemoryStream())
                {
                    await unileverView.Image.CopyToAsync(ms);

                    j.ImageFile = "/" + folder + "/" + imgFileName;
                }
                using (var stream = new FileStream(fileWrite, FileMode.Create))
                {
                    await unileverView.Image.CopyToAsync(stream);
                }
                _context.Unilever.Add(j);
                await _context.SaveChangesAsync();
                msg = "Product is saved successfully!";
                TempData["msg"] = msg;
                return RedirectToAction(nameof(Unilever));
            }
            else
            {
                msg = "Product data is incomplete. Please try again.";
            }
            TempData["msg"] = msg;
            return RedirectToAction("UnileverUpload");
        }

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
        public IActionResult PrimierUpload()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PrimierUpload([Bind("Id,CompanyName,Details,Price,Image,Description,TextBox")] PrimierView primierView)
        {
            string msg = "";
            if (ModelState.IsValid)
            {
                Primier j = new Primier();
                j.CompanyName = primierView.CompanyName;
                j.Details = primierView.Details;
                j.Price = primierView.Price;
                j.Description = primierView.Description;
                j.TextBox = primierView.TextBox;

                //Image
                string webroot = _he.WebRootPath;
                string folder = "Primier";
                string imgFileName = Path.GetFileName(primierView.Image.FileName);
                string fileWrite = Path.Combine(webroot, folder, imgFileName);

                using (MemoryStream ms = new MemoryStream())
                {
                    await primierView.Image.CopyToAsync(ms);

                    j.ImageFile = "/" + folder + "/" + imgFileName;
                }
                using (var stream = new FileStream(fileWrite, FileMode.Create))
                {
                    await primierView.Image.CopyToAsync(stream);
                }
                _context.Primier.Add(j);
                await _context.SaveChangesAsync();
                msg = "Product is saved successfully!";
                TempData["msg"] = msg;
                return RedirectToAction(nameof(Primier));
            }
            else
            {
                msg = "Product data is incomplete. Please try again.";
            }
            TempData["msg"] = msg;
            return RedirectToAction("PrimierUpload");
        }


        public IActionResult Jamuna()
        {
            return View();
        }
        public IActionResult Efood()
        {
            return View(_context.Efood.ToList());
        }
        public IActionResult EfoodUpload()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EfoodUpload([Bind("Id,CompanyName,Details,Price,Image,Description,TextBox")] EfoodView efoodView)
        {
            string msg = "";
            if (ModelState.IsValid)
            {
                Efood j = new Efood();
                j.CompanyName = efoodView.CompanyName;
                j.Details = efoodView.Details;
                j.Price = efoodView.Price;
                j.Description = efoodView.Description;
                j.TextBox = efoodView.TextBox;

                //Image
                string webroot = _he.WebRootPath;
                string folder = "Primier";
                string imgFileName = Path.GetFileName(efoodView.Image.FileName);
                string fileWrite = Path.Combine(webroot, folder, imgFileName);

                using (MemoryStream ms = new MemoryStream())
                {
                    await efoodView.Image.CopyToAsync(ms);

                    j.ImageFile = "/" + folder + "/" + imgFileName;
                }
                using (var stream = new FileStream(fileWrite, FileMode.Create))
                {
                    await efoodView.Image.CopyToAsync(stream);
                }
                _context.Efood.Add(j);
                await _context.SaveChangesAsync();
                msg = "Product is saved successfully!";
                TempData["msg"] = msg;
                return RedirectToAction(nameof(Efood));
            }
            else
            {
                msg = "Product data is incomplete. Please try again.";
            }
            TempData["msg"] = msg;
            return RedirectToAction("EfoodUpload");
        }

        public IActionResult ContactUs()
        {
            return View(_context.Contact.ToList());
        }

    }
}
