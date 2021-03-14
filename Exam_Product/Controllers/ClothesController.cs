using Exam_Product.Entity;
using Exam_Product.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exam_Product.Controllers
{
    public class ClothesController : Controller
    {
        private ApplicationDbContext _context;


        public ClothesController()
        {
            _context = new ApplicationDbContext();
        }
        [Authorize]
        public ActionResult Index()
        {
            var data = _context.Clothes.Select(t => new ClothesViewModel
            {
                Id = t.Id,
                Name=t.Name,
                Price=t.Price,
                Color = t.Color,
                URL_Image=t.URL_Image,
                Size=t.Size,
                Details=t.Details
                
            }).ToList();

            return View(data);
        }

        [HttpGet]
        public ActionResult CreateCloth()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "admin")]
        public ActionResult CreateCloth(CreateClothViewModel model)
        {
            _context.Clothes.Add(new Entity.Cloth
            {
                Name = model.Name,
                Price = model.Price,
                Color = model.Color,
                Size = model.Size,
                URL_Image = model.URL_Image,
                Details=model.Details
            });
            _context.SaveChanges();


            return RedirectToAction("Index", "Clothes");
        }
        [Authorize(Roles = "admin")]
        public ActionResult Delete(int id)
        {
            var deleteClothes = _context.Clothes.FirstOrDefault(t => t.Id == id);
            if (deleteClothes != null)
            {
                _context.Clothes.Remove(deleteClothes);
                _context.SaveChanges();
            }

            return RedirectToAction("Index", "Clothes");
        }


        [HttpGet]
        public ActionResult Edit(int id)
        {
            var editCloth = _context.Clothes.Select(t => new ClothesViewModel
            {
                Name = t.Name,
                Price = t.Price,
                Color = t.Color,
                URL_Image = t.URL_Image,
                Size = t.Size,
                Details=t.Details
            }).FirstOrDefault(t => t.Id == id);

            if (editCloth != null)
            {
                return View(editCloth);
            }
            else
            {
                return RedirectToAction("Index", "Clothes");
            }
        }

        [HttpPost]
        public ActionResult Edit(ClothesViewModel model)
        {
            var editStudent = _context.Clothes.FirstOrDefault(t => t.Id == model.Id);

            if (editStudent != null)
            {

                editStudent.Name = model.Name;
                editStudent.Price = model.Price;
                editStudent.URL_Image = model.URL_Image;
                editStudent.Color = model.Color;
                editStudent.Size = model.Size;
                editStudent.Details = model.Details;
                _context.SaveChanges();
                return RedirectToAction("Index", "Clothes");
            }
            else
            {
                return RedirectToAction("Index", "Clothes");
            }
        }
    }
}