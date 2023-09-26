

using BirdCageShop.BusinessLogic.Services;
using Ecommerce.BusinessLogic.RequestModels.Product;
using Ecommerce.BusinessLogic.ViewModels;
using Microsoft.AspNetCore.Mvc;


namespace BirdCageShop.Presentation.Controllers 
{

    [ApiController]
    [ApiVersion("1")]
    [Route("/api/v1/products")]
    public class ProductController : ControllerBase {

        private IProductService _productService;

         public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [MapToApiVersion("1")]
        [HttpPost]
        public ActionResult<ProductViewModel> CreateProduct(CreateProductRequestModel productCreate)
        {
            var productCreated = _productService.CreateProduct(productCreate);

            if (productCreated == null)
            {
                return NotFound("");
            }
            return productCreated;
        }

        [MapToApiVersion("1")]
        [HttpGet]
        public ActionResult<List<ProductViewModel>> GetAll()
        {
            var productList = _productService.GetAll();

            if (productList == null)
            {
                return NotFound("");
            }
            return productList;
        }

        [MapToApiVersion("1")]
        [HttpGet("idTmp")]
        public ActionResult<ProductViewModel> GetById(int idTmp)
        {
            var productDetail = _productService.GetById(idTmp);

            if (productDetail == null)
            {
                return NotFound("");
            }
            return productDetail;
        }

        [MapToApiVersion("1")]
        [HttpDelete]
        public ActionResult<bool> DeleteProduct(int idTmp)
        {
            var check = _productService.DeleteProduct(idTmp);

            if (check == false)
            {
                return NotFound("");
            }
            return check;
        }

        [MapToApiVersion("1")]
        [HttpPut]
        public ActionResult<ProductViewModel> UpdateProduct(UpdateProductRequestModel productCreate)
        {
            var productUpdated = _productService.UpdateProduct(productCreate);

            if (productUpdated == null)
            {
                return NotFound("");
            }
            return productUpdated;
        }
    }

}
