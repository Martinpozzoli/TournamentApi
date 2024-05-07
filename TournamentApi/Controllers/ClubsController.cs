using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Model.Interface;
using Model.Entities;
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

        // GET api/<ClubsController>/name
        [HttpGet("{name}")]
        public async Task<ActionResult<string>> GetByName(string name)
        {
            var club = await _unitOfWork.ClubRepository.GetByName(name);

            if (club.Count != 0)
                return Ok(club);
            else
                return NotFound();
        }

        // CREATE
        // POST api/<ClubsController>
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<Club>> CreateNewClub([FromBody] NewClubDTO newClub)
        {
            if (newClub == null)
                return BadRequest("No se pudo crear el recurso");
            else
            {
                var club = await _unitOfWork.ClubRepository.CreateNewClub(newClub.Name, newClub.ShortName, newClub.Players);

                if (club != null)
                    return new ObjectResult(club) { StatusCode = StatusCodes.Status201Created };
                else
                    return StatusCode(StatusCodes.Status422UnprocessableEntity);
            }

        }

        // REPLACE
        // PUT api/<ClubsController>/name
        [HttpPut("{name}")]
        [Authorize]
        public async Task<ActionResult<Club>> UpdateClub(string name, [FromBody] ClubUpdateDTO clubUpdate)
        {
            if (name == "" || clubUpdate == null)
                return BadRequest();
            else
            {
                var clubs = await _unitOfWork.ClubRepository.GetByName(name);

                if (clubs.Count != 1)
                    return Conflict("Se encontró más de un club con ese nombre, sea más específico");
                else
                {
                    var updatedClub = await _unitOfWork.ClubRepository.UpdateClub(name, clubUpdate.ShortName, clubUpdate.Players);

                    if (updatedClub != null)
                        return new ObjectResult(updatedClub) { StatusCode = StatusCodes.Status201Created };
                    else
                        return StatusCode(StatusCodes.Status304NotModified);
                }
            }
        }



        // DELETE api/<ClubsController>/name
        [HttpDelete("{name}")]
        [Authorize]
        public async Task<ActionResult<Club>> Delete(string name)
        {

            var club = await _unitOfWork.ClubRepository.DeleteClub(name);

            if (club != null)
                return Ok(club);
            else
                return NotFound();
        }

    }
}
