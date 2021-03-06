﻿using eManager.Domain;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace eManager.Web.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentDataSource _db;

        public DepartmentController(IDepartmentDataSource db)
        {
            _db = db;
        }


        public ActionResult Detail(int id)
        {
            var model = _db.Departments
                .Include(d => d.Employees)
                .Single(d => d.Id == id);

            return View(model);
        }
    }
}
