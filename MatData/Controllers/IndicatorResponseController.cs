using System;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore.IQueryable.Extensions.Filter;
using Matdata.API.Serialization;
using Matdata.API.ViewModels;
using MatData.Controllers;
using MatData.Data;
using MatData.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Matdata.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class IndicatorResponseController : ControllerBase
    {
        private readonly ILogger<IndicatorController> _logger;
        private readonly AppDbContext _db;

        public IndicatorResponseController(ILogger<IndicatorController> logger, AppDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        [HttpGet("query/single")]
        public async Task<IActionResult> GetRow([FromQuery] QueryVM query)
        {
            var queryIResponse = _db.IndicatorResponses.AsQueryable();

            if (query.IndicatorId != 0)
            {
                queryIResponse = queryIResponse.Where(q => q.IndicatorId == query.IndicatorId);
            }

            if (query.ProvinceId != 0)
            {
                queryIResponse = queryIResponse.Where(q => q.ProvinceId == query.ProvinceId);
            }

            if (query.MunicipeId != 0)
            {
                queryIResponse = queryIResponse.Where(q => q.MunicipeId == query.MunicipeId);
            }

            if (query.UrbanDistrictCommuneId != 0)
            {
                queryIResponse = queryIResponse.Where(q => q.UrbanDistrictCommuneId == query.UrbanDistrictCommuneId);
            }

            if (query.NeighborhoodVillageId != 0)
            {
                queryIResponse = queryIResponse.Where(q => q.NeighborhoodVillageId == query.NeighborhoodVillageId);
            }

            if (query.Year != null && query.Year != "")
            {
                queryIResponse = queryIResponse.Where(q => q.Year == query.Year);
            }

            var result = IndicatorResponseMapper.Serialize(
                await queryIResponse
                .Include(i => i.Province)
                .Include(i => i.Municipe)
                .Include(i => i.UrbanDistrictCommune)
                .Include(i => i.NeighborhoodVillage)
                .SingleOrDefaultAsync()
            );

            return Ok(result);

        }

        [HttpGet("query/list")]
        public async Task<IActionResult> GetRows([FromQuery] QueryVM query)
        {
            var queryIResponse = _db.IndicatorResponses.AsQueryable();

            if (query.IndicatorId != 0)
            {
                queryIResponse = queryIResponse.Where(q => q.IndicatorId == query.IndicatorId);
            }

            if (query.ProvinceId != 0)
            {
                queryIResponse = queryIResponse.Where(q => q.ProvinceId == query.ProvinceId);
            }

            if (query.MunicipeId != 0)
            {
                queryIResponse = queryIResponse.Where(q => q.MunicipeId == query.MunicipeId);
            }

            if (query.UrbanDistrictCommuneId != 0)
            {
                queryIResponse = queryIResponse.Where(q => q.UrbanDistrictCommuneId == query.UrbanDistrictCommuneId);
            }

            if (query.NeighborhoodVillageId != 0)
            {
                queryIResponse = queryIResponse.Where(q => q.NeighborhoodVillageId == query.NeighborhoodVillageId);
            }

            if (query.Year != null && query.Year != "")
            {
                queryIResponse = queryIResponse.Where(q => q.Year == query.Year);
            }

            var result = await queryIResponse
                .Include(i => i.Province)
                .Include(i => i.Municipe)
                .Include(i => i.UrbanDistrictCommune)
                .Include(i => i.NeighborhoodVillage)
                .Select(i => IndicatorResponseMapper.Serialize(i))
                .ToListAsync();

            return Ok(result);
        }
    }
}

