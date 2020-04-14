using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorCRUD.Server.Db;
using BlazorCRUD.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorCRUD.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {

        private readonly MainDbContext context;

        public PatientController(MainDbContext context)
        {
            this.context = context;
        }


        [HttpGet]
        public async Task<ActionResult<List<Patient>>> Get()
        {   
            return await context.Patients.ToListAsync();
        }


        [HttpGet("{id}", Name = "GetPatient")]
        public async Task<ActionResult<Patient>> Get(int id )
        {
            return await context.Patients.FirstOrDefaultAsync(p => p.Id == id);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Patient patient)
        {
            context.Add(patient);
            await context.SaveChangesAsync();
            return new CreatedAtRouteResult("GetPatient", new { id = patient.Id }, patient);
        }

        [HttpPut]
        public async Task<ActionResult> Put(Patient patient)
        {
            context.Entry(patient).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var patient = new Patient { Id = id };
            context.Remove(patient);
            await context.SaveChangesAsync();
            return NoContent();
        }


    }
}