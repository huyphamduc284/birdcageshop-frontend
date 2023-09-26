
using BirdCageShop.BusinessLogic.Services;
using Ecommerce.BusinessLogic.RequestModels.OrderDetail;
using Ecommerce.BusinessLogic.ViewModels;
using Microsoft.AspNetCore.Mvc;


namespace BirdCageShop.Presentation.Controllers 
{

    [ApiController]
    [ApiVersion("1")]
    [Route("/api/v1/orderdetails")]
    public class OrderDetailController : ControllerBase {

        private IOrderDetailService _orderdetailService;

         public OrderDetailController(IOrderDetailService orderdetailService)
        {
            _orderdetailService = orderdetailService;
        }

        [MapToApiVersion("1")]
        [HttpPost]
        public ActionResult<OrderDetailViewModel> CreateOrderDetail(CreateOrderDetailRequestModel orderdetailCreate)
        {
            var orderdetailCreated = _orderdetailService.CreateOrderDetail(orderdetailCreate);

            if (orderdetailCreated == null)
            {
                return NotFound("");
            }
            return orderdetailCreated;
        }

        [MapToApiVersion("1")]
        [HttpGet]
        public ActionResult<List<OrderDetailViewModel>> GetAll()
        {
            var orderdetailList = _orderdetailService.GetAll();

            if (orderdetailList == null)
            {
                return NotFound("");
            }
            return orderdetailList;
        }

        [MapToApiVersion("1")]
        [HttpGet("idTmp")]
        public ActionResult<OrderDetailViewModel> GetById(int idTmp)
        {
            var orderdetailDetail = _orderdetailService.GetById(idTmp);

            if (orderdetailDetail == null)
            {
                return NotFound("");
            }
            return orderdetailDetail;
        }

        [MapToApiVersion("1")]
        [HttpDelete]
        public ActionResult<bool> DeleteOrderDetail(int idTmp)
        {
            var check = _orderdetailService.DeleteOrderDetail(idTmp);

            if (check == false)
            {
                return NotFound("");
            }
            return check;
        }

        [MapToApiVersion("1")]
        [HttpPut]
        public ActionResult<OrderDetailViewModel> UpdateOrderDetail(UpdateOrderDetailRequestModel orderdetailCreate)
        {
            var orderdetailUpdated = _orderdetailService.UpdateOrderDetail(orderdetailCreate);

            if (orderdetailUpdated == null)
            {
                return NotFound("");
            }
            return orderdetailUpdated;
        }
    }

}
