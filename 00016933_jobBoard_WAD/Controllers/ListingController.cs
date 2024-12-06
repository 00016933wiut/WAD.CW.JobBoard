/*This is work of a student of WIUT with ID of 00016933*/

using jobBoardWADCW.Controllers;
using jobBoardWADCW.Data;
using jobBoardWADCW.Models;
using Microsoft.AspNetCore.Mvc;
namespace jobBoardWADCW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListingsController : ControllerBase
    {
        private readonly IListingRepository _repository;
        public ListingsController(IListingRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetAllListings()
        {
            var listings = _repository.GetAllListings();
            return Ok(listings);
        }

        [HttpPost]
        public IActionResult AddListing(AddListingRequestDTO request)
        {
            var listing = new Listing
            {
                Id = Guid.NewGuid(),
                CompanyName = request.companyName,
                Position = request.position,
                Salary = request.salary,
            };
            _repository.AddListing(listing);
            return Ok();
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public IActionResult DeleteListing(Guid id)
        {
            _repository.DeleteListing(id);
            return Ok();
        }

        [HttpPut]
        [Route("{id:guid}")]
        public IActionResult UpdateListing(Guid id, [FromBody] Listing updatedListing)
        {
            if (updatedListing == null || id == Guid.Empty)
            {
                return BadRequest(new { Message = "Invalid data provided." });
            }

            try
            {
                _repository.UpdateListing(id, updatedListing);
                return Ok(new { Message = "Listing updated successfully." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "An error occurred while updating the listing.", Error = ex.Message });
            }
        }


    }
}
