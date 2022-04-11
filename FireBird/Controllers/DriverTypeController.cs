using Domain.Models;
using Infrastructure.EF;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FireBird.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DriverTypeController : ControllerBase
    {

        private readonly DatabaseContext _databaseContext;

        private readonly ILogger<DriverTypeController> _logger;

        public DriverTypeController(ILogger<DriverTypeController> logger, DatabaseContext databaseContext)
        {
            _logger = logger;
            _databaseContext = databaseContext;
        }

        [HttpGet]
        public ActionResult<IEnumerable<DriverType>> GetAll()
        {
            try
            {
                return Ok(_databaseContext.DriverTypes.AsNoTracking());
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpGet("id")]
        public ActionResult<DriverType> GetById(int id)
        {
            try
            {
                var driverType = _databaseContext.DriverTypes.FirstOrDefault(x => x.Id == id);
                if (driverType == null)
                {
                    return NotFound();
                }

                return Ok(driverType);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpPost]
        public async Task<ActionResult<DriverType>> Create(string name)
        {
            try
            {
                var entry = await _databaseContext.DriverTypes.AddAsync(new DriverType() { Name = name });
                await _databaseContext.SaveChangesAsync();

                return Created($"api/drivertype/{entry.Entity.Id}", entry.Entity);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
        [HttpPut]
        public async Task<ActionResult<DriverType>> Update(int id, string newName)
        {
            try
            {
                var driverType = await _databaseContext.DriverTypes.FirstOrDefaultAsync(x => x.Id == id);
                if (driverType == null)
                {
                    return NotFound();
                }

                driverType.Name = newName;
                await _databaseContext.SaveChangesAsync();
                return Ok(driverType);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                var driverType = await _databaseContext.DriverTypes.FirstOrDefaultAsync(x => x.Id == id);
                if (driverType == null)
                {
                    return NotFound();
                }
                _databaseContext.DriverTypes.Remove(driverType);
                await _databaseContext.SaveChangesAsync();

                return NoContent();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

    }
}