using AutoMapper;
using GEN_InventarioRestApi.DTO;
using GEN_InventarioRestApi.Interfaces;
using GEN_InventarioRestApi.Modelos;
using Microsoft.AspNetCore.Mvc;

namespace GEN_InventarioRestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedidaController : Controller
    {
        private IUnitOfWork uow;
        private IMapper mapper;

        public MedidaController(IUnitOfWork uow, IMapper mapper)
        {
            this.uow = uow;
            this.mapper = mapper;
        }

        //GET api/medidas/get
        [HttpGet]
        public async Task<IActionResult> GetMedidas()
        {
            var medidas = await uow.MedidaRepository.GetMedidasAsync();

            var medidasDto = mapper.Map<IEnumerable<MedidaDto>>(medidas);

            return Ok(medidasDto);
        }

        //POST api/medida/add
        [HttpPost("post")]
        public async Task<IActionResult> AddMedida(MedidaDto medidaDto)
        {
            var medida = mapper.Map<Medida>(medidaDto);
            uow.MedidaRepository.AddMedida(medida);
            await uow.SaveAsync();
            return StatusCode(201);
        }

        //POST api/medida/add
        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeleteMedida(int id)
        {
            uow.MedidaRepository.DeleteMedida(id);
            await uow.SaveAsync();
            return Ok(id);
        }

        //PUT api/medida/add
        [HttpPut("update/{id}")]
        public async Task<IActionResult> UpdateMedida(int id, MedidaDto medidaDto)
        {
            var medidaFromDb = await uow.MedidaRepository.FindMedida(id);
            mapper.Map(medidaDto, medidaFromDb);
            await uow.SaveAsync();
            return StatusCode(200);
        }
    }
}
