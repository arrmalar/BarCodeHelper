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
            if(!ModelState.IsValid)
            {
                return View(barCode);
            }

            var barCodeFromDB = _unitOfWork.BarCodeRepository.Get(b => b.BarCodeNumber == barCode.BarCodeNumber, includeProperties: "Product");
            var productFromDB = _unitOfWork.ProductRepository.Get(p => p.SerialNumber == barCode.ProductSerialNumber);

            if (productFromDB != null) {
                // tutaj powinna byæ informacja o tym, ze siê nie uda³o, bo taki element istnieje
                // dodatkowo powinno byæ pytanie czy u¿yæ istniej¹cego elementu
            }

            if (barCodeFromDB == null) {

                var product = barCode.Product;
                barCode.Created = DateTime.Now;
                product.SerialNumber = barCode.ProductSerialNumber;

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
            return Json(new { data = categories });
        }

        public IActionResult GetAllProducts()
        {
            var products = _unitOfWork.ProductRepository.GetAll();
            return Json(new { data = products });
        }
    }
}
