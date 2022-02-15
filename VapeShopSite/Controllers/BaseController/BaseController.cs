using Microsoft.AspNetCore.Mvc;
using VapeShopeSite.WebApi.Controllers.TestController.Models;
using VapeShopeSite.WebApi.Models;

namespace VapeShopeSite.WebApi.Controllers.HeaderController
{
    [ApiController]
    public class BaseController : Controller
    {
        public JsonResult Json<T>(BasePagedListModel<T> model) where T : BaseNopModel
        {
            return Json(new
            {
                draw = model.Draw,
                recordsTotal = model.RecordsTotal,
                recordsFiltered = model.RecordsFiltered,
                Data = model.Data
            });
        }
    }
}
