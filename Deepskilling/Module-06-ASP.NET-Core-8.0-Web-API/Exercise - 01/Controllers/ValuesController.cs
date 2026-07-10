using Microsoft.AspNetCore.Mvc;

namespace MyWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        static List<string> values = new List<string>
        {
            "Apple",
            "Banana",
            "Orange"
        };

        // GET - Read
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(values);
        }

        // POST - Create
        [HttpPost]
        public IActionResult Post(string value)
        {
            values.Add(value);
            return Ok(values);
        }

        // PUT - Update
        [HttpPut]
        public IActionResult Put(int index, string value)
        {
            if (index >= 0 && index < values.Count)
            {
                values[index] = value;
                return Ok(values);
            }

            return BadRequest("Invalid Index");
        }

        // DELETE - Delete
        [HttpDelete]
        public IActionResult Delete(int index)
        {
            if (index >= 0 && index < values.Count)
            {
                values.RemoveAt(index);
                return Ok(values);
            }

            return BadRequest("Invalid Index");
        }
    }
}