using BarCodeHelper.DataAccess.Repository.IRepository;
using BarCodeHelper.Models;
using BarCodeHelper.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CookSupp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = $"{SD.Role_Admin}")]
    public class BarCodeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public BarCodeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var objBarCodeList = _unitOfWork.BarCodeRepository.GetAll();
            return View(objBarCodeList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(BarCode barcode)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.BarCodeRepository.Add(barcode);
                _unitOfWork.Save();
                TempData["success"] = "Barcode created successfully";
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Edit(string? barCodeNumber)
        {
            var barcode = _unitOfWork.BarCodeRepository.Get(p => p.BarCodeNumber == barCodeNumber);

            if (barcode != null)
            {
                return View(barcode);
            }

            return NotFound();
        }

        [HttpPost]
        public IActionResult Edit(BarCode? barcode)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.BarCodeRepository.Update(barcode);
                _unitOfWork.Save();
                TempData["success"] = "Barcode edited successfully";
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var objBarCodeList = _unitOfWork.BarCodeRepository.GetAll().ToList();
            return Json(new { data = objBarCodeList });
        }

        public IActionResult Delete(string? barCodeNumber)
        {
            var barCodeToBeDeleted = _unitOfWork.BarCodeRepository.Get(u => u.BarCodeNumber == barCodeNumber);

            if (barCodeToBeDeleted == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

            _unitOfWork.BarCodeRepository.Remove(barCodeToBeDeleted);
            _unitOfWork.Save();

            return Json(new { success = true, message = "Delete successful" });
        }
    }
}
