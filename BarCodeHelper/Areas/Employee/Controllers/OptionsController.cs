using BarCodeHelper.DataAccess.Repository.IRepository;
using BarCodeHelper.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CookSupp.Areas.Customer.Controllers
{
    [Area("Employee")]
    public class OptionsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public OptionsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult OptionsPanel(BarCode barCode)
        {
            return View(barCode);
        }

        public IActionResult Delete(string? barCodeNumber)
        {
            var barCodeToBeDeleted = _unitOfWork.BarCodeRepository.Get(b => b.BarCodeNumber == barCodeNumber);

            if (barCodeToBeDeleted == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

            _unitOfWork.BarCodeRepository.Remove(barCodeToBeDeleted);
            _unitOfWork.Save();

            return Json(new { success = true, message = "Delete successful" });
        }

        public IActionResult Move(BarCode barCode)
        {
            return View(barCode);
        }

        public IActionResult Logs(BarCode barCode)
        {
            return View(barCode);
        }

        public IActionResult Details(BarCode barCode)
        {
            var barCodeFromDb = _unitOfWork.BarCodeRepository.Get(b => b.BarCodeNumber == barCode.BarCodeNumber, includeProperties: "Product");
            return View(barCodeFromDb);
        }

        [HttpPost]
        public IActionResult Save(BarCode barCode)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors)
                                              .Select(e => e.ErrorMessage)
                                              .ToList();

                return BadRequest(new { Success = false, Message = "Validation failed", Errors = errors });
            }

            try
            {
                _unitOfWork.ProductRepository.Update(barCode.Product);
                _unitOfWork.Save();
                return Ok(new { Success = true, Message = "Product updated successfully" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Success = false, Message = "An error occurred while updating the product", Error = ex.Message });
            }
        }


        public IActionResult GetAllCategories()
        {
            var categories = Enum.GetNames(typeof(ProductCategory));
            return Json(new { data = categories });
        }

        public IActionResult GetAllProducts()
        {
            var products = _unitOfWork.ProductRepository.GetAll();
            return Json(new { data = products });
        }
    }
}
