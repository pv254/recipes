﻿using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RecipesCore.Models;

namespace RecipesCore.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly RecipesContext _db;

        public CategoryService(RecipesContext db)
        {
            _db = db;
        }

        public Category Get(long id)
        {
            return _db.Categories.FirstOrDefault(x => x.Id == id);
        }
    }
}