using AutoMapper;
using GEN_InventarioRestApi.DTO;
using GEN_InventarioRestApi.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GEN_InventarioRestApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : Controller
    {
        private IUnitOfWork uow;
        private IMapper mapper;

        public ProductoController(IUnitOfWork uow, IMapper mapper)
        {
            this.uow = uow;
            this.mapper = mapper;
        }

        //[AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> GetProductosList()
        {
            var productos = await uow.ProductoRepository.GetProductosAsync();
            return Ok(productos);
            //var productosListDto = mapper.Map<IEnumerable<ProductoListDto>>(productos);
            //return Ok(productosListDto);
        }



    }
}
