using BarCodeHelper.DataAccess.Repository.IRepository;
using BarCodeHelper.Models;
using Microsoft.AspNetCore.Mvc;

namespace CookSupp.Areas.Customer.Controllers
{
    [Area("Employee")]
    public class NewBarCodeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public NewBarCodeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index(string barCodeNumber)
        {
            var barcode = new BarCode();
            barcode.BarCodeNumber = barCodeNumber;
            return View(barcode);
        }

        [HttpPost]
        public IActionResult Index(BarCode barCode)
        {
            var barCodeFromDB = _unitOfWork.BarCodeRepository.Get(b => b.BarCodeNumber == barCode.BarCodeNumber, includeProperties: "Product");

            // zapisaæ produkt i zapisaæ barcode
            if (barCodeFromDB == null) {

                var product = barCode.Product;

                _unitOfWork.ProductRepository.Add(product);
                _unitOfWork.BarCodeRepository.Add(barCode);

                _unitOfWork.Save();

                return RedirectToAction("OptionsPanel", "Options", barCode);
            }

            return View();
        }

        public IActionResult GetAllCategories()
        {
            var categories = Enum.GetNames(typeof(ProductCategory));
            //var sss = (ProductCategory)Enum.Parse(typeof(ProductCategory), categories[0]);
            return Json(new { data = categories });
        }

        public IActionResult GetAllProducts()
        {
            var products = _unitOfWork.ProductRepository.GetAll();
            return Json(new { data = products });
        }
    }
}
