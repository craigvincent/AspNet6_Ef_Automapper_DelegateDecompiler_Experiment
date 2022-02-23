using Accent.DotNetExperiments.Dtos;
using Accent.DotNetExperiments.Entities;
using AutoMapper;
using DelegateDecompiler;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;

namespace Accent.DotNetExperiments.Controllers;

[ApiController]
[Route("[controller]")]
public class LocationController : ControllerBase
{
    private readonly ExperimentsDbContext _dbContext;
    private readonly IMapper _mapper;
    private readonly ILogger<LocationController> _logger;

    public LocationController(ExperimentsDbContext dbContext, IMapper mapper, ILogger<LocationController> logger)
    {
        _dbContext = dbContext;
        _mapper = mapper;
        _logger = logger;
    }

    [HttpGet(Name = "GetLocation")]
    [EnableQuery]
    public IQueryable<LocationDto> Get() => _mapper.ProjectTo<LocationDto>(_dbContext.Locations).Decompile();

    [HttpGet("Create", Name = "Create")]
    public ActionResult Create()
    {
        _dbContext.Locations.Add(new Location
        {
            Name = Guid.NewGuid().ToString(),
            IsFavorite = false,
            OccupantCount = new Random().Next(0, 100)
        });
        _dbContext.SaveChanges();

        return Ok();
    }
}