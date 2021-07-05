using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BookProject.Data;
using BookProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System.Net;

namespace BookProject.Views.Products
{
    [Authorize(Policy = "readpolicy")]
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public ProductsController(ApplicationDbContext context,IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            this._hostEnvironment = hostEnvironment;
        }
        // GET: Products
        public async Task<IActionResult> Index(SearchViewModel searchModel)
        {
            var query = _context.Products.Include(t => t.Category)
                .Include(t => t.Author)
                .Include(t => t.Publisher)
                .AsQueryable();

            if (searchModel.CategoryId != 0)
            {
                query = query.Where(t => t.CategoryId == searchModel.CategoryId);
            }
            if (searchModel.InDescription)
            {
                query = query.Where(t => t.Description.Contains(searchModel.SearchTitle));

            }
            else if (!String.IsNullOrWhiteSpace(searchModel.SearchTitle))
            {
                query = query.Where(t => t.Title.Contains(searchModel.SearchTitle));
            }
            query = query.OrderBy(w => w.Id);
            searchModel.Result = await query.ToListAsync();
            return View(searchModel);
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Author)
                .Include(p => p.Category)
                .Include(p => p.Publisher)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            ViewData["AuthorId"] = new SelectList(_context.Authors, "Id", "Fullname");
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name");
            ViewData["PublisherId"] = new SelectList(_context.Publishers, "Id", "Name");
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Description,Code,Price,Isbn,Sort,Qty,ImageFile,CategoryId,AuthorId,PublisherId")] Product product)
        {
            if (ModelState.IsValid)
            {
                if (product.ImageFile != null)
                {
                    Random rand = new Random(Environment.TickCount);
                    string wwwRootPath = _hostEnvironment.WebRootPath;
                    string fileName = Path.GetFileNameWithoutExtension(product.ImageFile.FileName) + rand.Next();
                    string extension = Path.GetExtension(product.ImageFile.FileName);
                    product.Image = fileName + extension;
                    string path = Path.Combine(wwwRootPath + "/Image/", fileName + extension);
                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        await product.ImageFile.CopyToAsync(fileStream);
                    }
                }
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
                ViewData["AuthorId"] = new SelectList(_context.Authors, "Id", "Fullname", product.AuthorId);
                ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", product.CategoryId);
                ViewData["PublisherId"] = new SelectList(_context.Publishers, "Id", "Name");
            return View(product);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["AuthorId"] = new SelectList(_context.Authors, "Id", "Fullname", product.AuthorId);
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", product.CategoryId);
            ViewData["PublisherId"] = new SelectList(_context.Publishers, "Id", "Name");
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Description,Code,Price,Isbn,Sort,Qty,Image,ImageFile,CategoryId,AuthorId,PublisherId")] Product product)
        {
            if (id != product.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                   
                   
                    if (product.ImageFile != null)
                    {
                        Random rand = new Random(Environment.TickCount);
                        string wwwRootPath = _hostEnvironment.WebRootPath;
                        string fileName = Path.GetFileNameWithoutExtension(product.ImageFile.FileName) + rand.Next();
                        string extension = Path.GetExtension(product.ImageFile.FileName);
                        product.Image = fileName + extension;
                        string path = Path.Combine(wwwRootPath + "/Image/", fileName + extension);
                        using (var fileStream = new FileStream(path, FileMode.Create))
                        {
                            await product.ImageFile.CopyToAsync(fileStream);
                        }
                    }
                    else
                    {
                        product.Image = product.Image;
                    }

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
           
            ViewData["AuthorId"] = new SelectList(_context.Authors, "Id", "Fullname", product.AuthorId);
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", product.CategoryId);
            ViewData["PublisherId"] = new SelectList(_context.Publishers, "Id", "Name");
            return View(product);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Author)
                .Include(p => p.Category)
                .Include(p => p.Publisher)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Products.FindAsync(id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.Id == id);
        }
    }
}
