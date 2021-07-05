using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BookProject.Data;
using BookProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace BookProject.ViewComponents
{
    public class CategoryMenuViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext dbContext;

        public CategoryMenuViewComponent(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categoryList = await dbContext.Categories.ToListAsync();
            return View(categoryList);
        }
    }
}
