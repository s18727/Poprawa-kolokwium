using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Poprawa.Models;
using Poprawa.Services;
using Microsoft.AspNetCore.Mvc;

namespace Poprawa.Controllers
{
    [Route("api/volunteers")]
    public class MyController : ControllerBase
    {

        readonly IDbService _service;

        public MyController(IDbService service)
        {
            _service = service;
        }

        //Scaffold-DbContext 'Data Source=db-mssql;Initial Catalog=s18727;Integrated Security=True' Microsoft.EntityFrameworkCore.SqlServer -T Volunteer_Pet, Volunteer, Pet, BreedType -OutputDir Models


        [HttpGet("{id}/pets")]
        public IActionResult GetPets(int id)
        {
            try
            {

                var result = _service.GetPets(id);
                return Ok(result);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }

        }

    }
}