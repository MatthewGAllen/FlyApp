using System.Threading.Tasks;
using AutoMapper;
using FlyApp.API.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FlyApp.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class MaterialsController : ControllerBase
    {
        private readonly IMaterialRepository _repo;
        private readonly IMapper _mapper;

        public MaterialsController(IMaterialRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetMaterials()
        {
            var mats = await _repo.GetMaterials();

            return Ok(mats);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            var mat = await _repo.GetMaterial(id);

            return Ok(mat);
        }
    }
}