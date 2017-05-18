
namespace LiveChatWebhookSample.Controllers
{
    using LiveChatWebhookSample.Models;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;

    [Route("api/[controller]")]
    public class WebhookController : Controller
    {
        [HttpPost("/ChatStarts/")]
        public ActionResult ChatStarts([FromBody]Webhook value)
        {
            return Ok();
        }

        [HttpPost("/ChatEnds/")]
        public ActionResult ChatEnds([FromBody]Webhook value)
        {
            return Ok();
        }

        [HttpPost("/ChatChanged/")]
        public ActionResult ChatChanged([FromBody]Webhook value)
        {
            return Ok();
        }

        [HttpPost("/VisitorQueued/")]
        public ActionResult VisitorQueued([FromBody]Webhook value)
        {
            return Ok();
        }

        [HttpPost("/TicketCreated/")]
        public ActionResult TicketCreated([FromBody]Webhook value)
        {
            return Ok();
        }
    }
}