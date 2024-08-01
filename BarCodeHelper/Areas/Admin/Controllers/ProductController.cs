using BarCodeHelper.DataAccess.Repository.IRepository;
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
            var productFromDB = _unitOfWork.ProductRepository.Get(p => p.SerialNumber == product.SerialNumber);

            if (ModelState.IsValid && productFromDB == null)
            {
                _unitOfWork.ProductRepository.Add(product);
                _unitOfWork.Save();
                TempData["success"] = "Product created successfully";
                return RedirectToAction("Index");
            }

            return View(product);
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
            if (product == null) {
                return RedirectToAction("Index");
            }

            var productFromDB = _unitOfWork.ProductRepository.Get(p => p.SerialNumber == product.SerialNumber);

            if (ModelState.IsValid && productFromDB == null)
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

        public IActionResult GetAllCategories()
        {
            var categories = Enum.GetNames(typeof(ProductCategory));
            return Json(new { data = categories });
        }

        // dynamic
        [HttpPost]
        public JsonResult CheckSerialNumberExists(string serialNumber)
        {
            var productFromDB = _unitOfWork.ProductRepository.Get(p => p.SerialNumber == serialNumber);

            if (productFromDB != null)
            {
                return Json(new { exists = true });
            }

            return Json(new { exists = false });
        }
    }
}
