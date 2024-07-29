using Microsoft.AspNetCore.Mvc;
using ProjectName.Api.Services;
using ProjectName.Api.DTOs;

namespace ProjectName.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PartMasterController : ControllerBase
    {
        private readonly PartMasterService _partMasterService;

        public PartMasterController(PartMasterService partMasterService)
        {
            _partMasterService = partMasterService;
        }

        [HttpGet("GetPartMasterData")]
        public ActionResult<PartMasterDTO> GetPartMasterData()
        {
            var partMasterData = _partMasterService.GetPartMasterData();
            return Ok(partMasterData);
        }

        [HttpGet("GetCurrentDate")]
        public ActionResult<string> GetCurrentDate()
        {
            var currentDate = _partMasterService.GetCurrentDate();
            return Ok(currentDate);
        }
    }
}