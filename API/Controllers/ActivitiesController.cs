using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers;

public class ActivitiesController : BaseApiController
{

    private readonly DataContext _context;
    public ActivitiesController(DataContext context)
    {
        _context = context;
    }

    [HttpGet] //API/ACTIVTIEWS

    public async Task<ActionResult<List<Activity>>> GetActivities()
    {
        return await _context.Activities.ToListAsync();
    }

    [HttpGet("{id}")]

    public async Task<ActionResult<Activity>> GetActivityById(Guid id)
    {

        return await _context.Activities.FindAsync(id);
    }
}