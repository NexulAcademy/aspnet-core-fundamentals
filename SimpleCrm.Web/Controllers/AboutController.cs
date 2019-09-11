using Microsoft.AspNetCore.Mvc;

namespace SimpleCrm.Web.Controllers
{
    [Route("[controller]")]
    public class AboutController
    {
        [Route("")]
        [Route("[action]")]
        public string Phone()
        {
            return "555-555-1234";
        }
        [Route("[action]")]
        public string Address()
        {
            return "USA";
        }
    }
}
