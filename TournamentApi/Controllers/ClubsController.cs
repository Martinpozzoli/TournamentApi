using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Model.Interface;
using Repository.UnitOfWork;
using TournamentApi.DTO;
using TournamentApi.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TournamentApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClubsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ClubsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/<ClubsController>
        [HttpGet]
        public async Task<ActionResult<List<ClubResponse>>> Get()
        {
            var clubs = await _unitOfWork.ClubRepository.GetAll();
            List<ClubResponse> clubsResponse = new List<ClubResponse>();
            foreach (var club in clubs)
            {
                clubsResponse.Add(DtoMapper.MapClubToClubResponse(club));
            }
            return clubsResponse;
        }

        // GET api/<ClubsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ClubsController>
        [HttpPost]
        [Authorize]
        public void Post([FromBody] string value) { }

        // PUT api/<ClubsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value) { }

        // DELETE api/<ClubsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id) { }
    }
}
