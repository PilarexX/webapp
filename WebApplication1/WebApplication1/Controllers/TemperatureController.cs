using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TemperatureController : ControllerBase
    {
        private readonly TemperatureStore _store;

        public TemperatureController(TemperatureStore store)
        {
            _store = store;
        }

        [HttpGet("average")]
        public ActionResult<string> Average()
        {
            return new ObjectResult(_store.GetAverage());
        }


        [HttpGet]
        public ActionResult<string> Last()
        {
            return new ObjectResult(_store.GetLastReading());
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] PostTemperature model)
        {
            _store.AddTemperature(model.NewValue);
        }
    }
}
