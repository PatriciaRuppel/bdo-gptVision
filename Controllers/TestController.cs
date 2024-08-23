using bdo.gptVisionApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace bdo.gptVisionApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        protected GPTVisionContext context;
        public TestController(GPTVisionContext _context)
        {
            this.context = _context;
        }

        /// <summary>
        /// Returns all Chat Entries in Database
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<List<ChatEntry>>> GetAll()
        {

            var chatEntries = await context.ChatEntries.ToListAsync();
            return Ok(chatEntries);
        }

        /// <summary>
        /// Get one entry in Chat Entries by Id
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<ChatEntry>> GetById(int id)
        {

            var chatEntry = await context.ChatEntries.FirstOrDefaultAsync<ChatEntry>(x => x.Id == id);
            if (chatEntry == null)
                return NotFound();
            return Ok(chatEntry);
        }

        [HttpPost]
        public async Task<ActionResult<string>> Post(ChatEntry entry)
        {
            entry.TimeStamp = DateTime.Now;
            context.ChatEntries.Add(entry);
            await context.SaveChangesAsync();
            var chatEntry = await context.ChatEntries.FirstOrDefaultAsync<ChatEntry>(x => x.Id == entry.Id);
            if (chatEntry == null)
                return NotFound();
            return Ok(chatEntry);
        }

    }
}
