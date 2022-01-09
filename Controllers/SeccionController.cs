using AutoMapper;
using GEN_InventarioRestApi.Data;
using GEN_InventarioRestApi.Data.Repository;
using GEN_InventarioRestApi.DTO;
using GEN_InventarioRestApi.Interfaces;
using GEN_InventarioRestApi.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace GEN_InventarioRestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeccionController : Controller
    {
        private IUnitOfWork uow;
        private IMapper mapper;

        public SeccionController(IUnitOfWork uow, IMapper mapper)
        {
            this.uow = uow;
            this.mapper = mapper;
        }

        //GET api/seccion/get
        [HttpGet]
        public async Task<IActionResult> GetSecciones()
        {
            var secciones = await uow.SeccionRepository.GetSeccionesAsync();

            var seccionesDto = mapper.Map<IEnumerable<SeccionDto>>(secciones);

            return Ok(seccionesDto);
        }

        //POST api/seccion/add
        [HttpPost("post")]
        public async Task<IActionResult> AddSeccion(SeccionDto seccionDto)
        {
            var seccion = mapper.Map<Seccion>(seccionDto);
            uow.SeccionRepository.AddSeccion(seccion);
            await uow.SaveAsync();
            return StatusCode(201);
        }

        //POST api/seccion/add
        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> AddSeccion(int id)
        {
            uow.SeccionRepository.DeleteSeccion(id);
            await uow.SaveAsync();
            return Ok(id);
        }

        /*
        public IActionResult Index()
        {
            return View();
        }
        */
    }
}
