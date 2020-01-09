using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CouchSignal.Data;
using CouchSignal.Models;
using DeviceTask = CouchSignal.Models.Task;

namespace CouchSignal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DevicesController : ControllerBase
    {
        private readonly DataContext _context;

        public DevicesController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Devices
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Device>>> GetDevices()
        {
            return await _context.Devices.ToListAsync();
        }

        // GET: api/Devices/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Device>> GetDevice(long id)
        {
            var device = await _context.Devices.FindAsync(id);

            if (device == null)
            {
                return NotFound();
            }

            return device;
        }

        // PUT: api/Devices/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDevice(long id, Device device)
        {
            if (id != device.ID)
            {
                return BadRequest();
            }

            _context.Entry(device).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DeviceExists(id))
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

        // POST: api/Devices
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Device>> PostDevice(Device device)
        {
            _context.Devices.Add(device);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDevice", new { id = device.ID }, device);
        }

        // DELETE: api/Devices/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Device>> DeleteDevice(long id)
        {
            var device = await _context.Devices.FindAsync(id);
            if (device == null)
            {
                return NotFound();
            }

            _context.Devices.Remove(device);
            await _context.SaveChangesAsync();

            return device;
        }

        // GET: api/Devices/5/Tasks
        [HttpGet("{deviceId}/Tasks")]
        public async Task<ActionResult<IEnumerable<DeviceTask>>> GetTasks(long deviceID)
        {
            var device = await _context.Devices.FindAsync(deviceID);

            if (device == null)
            {
                return NotFound();
            }

            return device.Tasks;
        }

        // GET: api/Devices/5/Tasks/2
        [HttpGet("{deviceId}/Tasks/{id}")]
        public async Task<ActionResult<DeviceTask>> GetTask(long deviceID, long id)
        {
            var task = await _context.Tasks
                .Where(t => t.DeviceID == deviceID)
                .Where(t => t.ID == id)
                .FirstAsync();

            if (task == null)
            {
                return NotFound();
            }

            return task;
        }

        [HttpPut("{deviceId}/Tasks/{id}")]
        public async Task<IActionResult> PutTask(long id, DeviceTask task)
        {
            if (id != task.ID)
            {
                return BadRequest();
            }

            _context.Entry(task).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TaskExists(id))
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

        private bool DeviceExists(long id)
        {
            return _context.Devices.Any(e => e.ID == id);
        }

        private bool TaskExists(long id)
        {
            return _context.Tasks.Any(e => e.ID == id);
        }
    }
}
