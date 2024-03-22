using Microsoft.AspNetCore.Mvc;
using Data.Models;
using Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Portal.API.Controllers;

public abstract class BaseController<T> : Controller
    where T: class, IIdentified
{
    protected ScaffoldedContext _context;
    protected readonly IConfiguration _config;

    public BaseController(ScaffoldedContext context, IConfiguration configuration)
    {
        _context = context;
        _config = configuration;
    }

    [HttpGet]
    [Route("get/{id}")]
    [ProducesResponseType<object>(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    //[Authorize(Policy="default-api-access")]
    public IActionResult Get(string id)
    {
        var result = _context.Set<T>().Where(x => x.Id == id).FirstOrDefault();
        return result == null ? NotFound() : Ok(result);
    }

    [HttpGet]
    [Route("get")]
    [ProducesResponseType<IEnumerable<object>>(StatusCodes.Status200OK)]
    //[Authorize(Policy="default-api-access")]
    public IActionResult GetAll()
    {
        var result = _context.Set<T>().AsEnumerable().Take(15);
        return Ok(result);
    }

    [HttpPut]
    [Route("put")]
    [ProducesResponseType<object>(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    //[Authorize(Policy="default-api-access")]
    public async virtual Task<IActionResult> Put([FromBody]T entity)
    {
        var entityExists = await _context.Set<T>().Where(x => x.Id == entity.Id).AnyAsync();
        if(entityExists){
            var a = _context.Update<T>(entity);
        }
        else{
            await _context.AddAsync<T>(entity);
        }
        await _context.SaveChangesAsync();
        return Ok(entity);
    }

    [HttpDelete]
    [Route("delete/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    //[Authorize(Policy="default-api-access")]
    public IActionResult Delete(string id)
    {
        var existingEntity = _context.Set<T>().Where(x => x.Id == id).FirstOrDefault();
        if(existingEntity == null){
            return NotFound();
        }
        _context.Remove<T>(existingEntity);
        _context.SaveChanges();
        return Ok();
    }
}
