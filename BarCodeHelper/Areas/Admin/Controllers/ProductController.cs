﻿using BarCodeHelper.DataAccess.Repository.IRepository;
using BarCodeHelper.Models;
using BarCodeHelper.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CookSupp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = $"{SD.Role_Admin}")]
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var objProductList = _unitOfWork.ProductRepository.GetAll();
            return View(objProductList);
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.ProductRepository.Add(product);
                _unitOfWork.Save();
                TempData["success"] = "Product created successfully";
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Edit(string? serialNumber)
        {
            var product = _unitOfWork.ProductRepository.Get(p => p.SerialNumber == serialNumber);

            if (product != null)
            {
                return View(product);
            }

            return NotFound();
        }

        [HttpPost]
        public IActionResult Edit(Product? product)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.ProductRepository.Update(product);
                _unitOfWork.Save();
                TempData["success"] = "Category edited successfully";
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var objProductList = _unitOfWork.ProductRepository.GetAll().ToList();
            return Json(new { data = objProductList });
        }

        public IActionResult Delete(string? serialNumber)
        {
            var productToBeDeleted = _unitOfWork.ProductRepository.Get(u => u.SerialNumber == serialNumber);

            if (productToBeDeleted == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

            _unitOfWork.ProductRepository.Remove(productToBeDeleted);
            _unitOfWork.Save();

            return Json(new { success = true, message = "Delete successful" });
        }
    }
}
