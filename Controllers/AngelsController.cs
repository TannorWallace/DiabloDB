using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DiabloDB.Models;
using DiabloDB.Data;

namespace DiabloDB.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AngelsController : ControllerBase
  {
    private readonly AngelRepository _repository;

    public AngelsController(AngelRepository repository)
    {
      _repository = repository;
    }

    // POST api/values
    [HttpPost]
    public ActionResult<Angels> Post([FromBody] Angels angels)
    {
      try
      {
        return Ok(_repository.CreateAngels(angels));
      }
      catch (Exception e)
      {

        return BadRequest(e.Message);
      }
    }

    // GET api/values
    [HttpGet]
    public ActionResult<IEnumerable<Angels>> GetAllAngels()
    {
      try
      {
        return Ok(_repository.GetAllAngels());
      }
      catch (Exception e)
      {

        return BadRequest(e.Message);
      }
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public ActionResult<Angels> GetAngelsById(int id)
    {
      try
      {
        return Ok(_repository.GetAngelsById(id));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    // PUT api/values/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/values/5
    [HttpDelete("{id}")]
    public ActionResult<Angels> DeleteAngelsById(int id)
    {
      try
      {
        return Ok(_repository.DeleteAngelsById(id));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}
