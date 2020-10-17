﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SonicWarehouseManagement.Server.Data;
using SonicWarehouseManagement.Shared;

namespace SonicWarehouseManagement.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesmanMastersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public SalesmanMastersController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/SalesmanMasters
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SalesmanMaster>>> GetSalesman_Masters()
        {
            return await _context.Salesman_Masters.ToListAsync();
        }

        // GET: api/SalesmanMasters/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SalesmanMaster>> GetSalesmanMaster(int id)
        {
            var salesmanMaster = await _context.Salesman_Masters.FindAsync(id);

            if (salesmanMaster == null)
            {
                return NotFound();
            }

            return salesmanMaster;
        }

        // PUT: api/SalesmanMasters/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSalesmanMaster(int id, SalesmanMaster salesmanMaster)
        {
            if (id != salesmanMaster.Id)
            {
                return BadRequest();
            }

            _context.Entry(salesmanMaster).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SalesmanMasterExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/SalesmanMasters
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<SalesmanMaster>> PostSalesmanMaster(SalesmanMaster salesmanMaster)
        {
            _context.Salesman_Masters.Add(salesmanMaster);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSalesmanMaster", new { id = salesmanMaster.Id }, salesmanMaster);
        }

        // DELETE: api/SalesmanMasters/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SalesmanMaster>> DeleteSalesmanMaster(int id)
        {
            var salesmanMaster = await _context.Salesman_Masters.FindAsync(id);
            if (salesmanMaster == null)
            {
                return NotFound();
            }

            _context.Salesman_Masters.Remove(salesmanMaster);
            await _context.SaveChangesAsync();

            return salesmanMaster;
        }

        private bool SalesmanMasterExists(int id)
        {
            return _context.Salesman_Masters.Any(e => e.Id == id);
        }
    }
}
