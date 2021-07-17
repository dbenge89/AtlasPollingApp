using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtlasPollingApp.API.Data;
using AtlasPollingApp.API.Models;
using AtlasPollingApp.Models.PollModels;
using AtlasPollingApp.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AtlasPollingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PollsController : ControllerBase
    {
        private readonly User _user;
        public PollsController (User user)
        {
            _user = user;
        }
        private PollServices CreatePollService()
        {
            var userId = _user.Id;
            var pollService = new PollServices(userId);
            return pollService;
        }

        // GET: api/Polls
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Poll>>> GetPoll()
        {
            PollServices pollServices = CreatePollService();
            var polls = pollServices.GetPolls();
            return Ok(polls);
        }

        // GET: api/Polls/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Poll>> GetPoll(int id)
        {
            PollServices pollServices = CreatePollService();
            var post = pollServices.GetPollById(id);
            return Ok(post);
        }

        // PUT: api/Polls/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPoll(PollEdit poll)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreatePollService();

            if (!service.UpdatePoll(poll))
                return NotFound();

            return Ok();
        }

        // POST: api/Polls
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Poll>> PostPoll(PollCreate poll)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreatePollService();

            if (!service.CreatePoll(poll))
                return NotFound();

            return Ok();
        }

        // DELETE: api/Polls/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePoll(int id)
        {
            var service = CreatePollService();

            if (!service.DeletePoll(id))
                return NotFound();

            return Ok();
        }
    }
}
