using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.Model;

namespace Test.API.Controllers
{
    public class SearchViewModel
    {
        public string Field { get; set; }
    }

    [Route("api/[controller]")]
    public class AssessmentTypesController : Controller
    {
        private TestContext context;

        public AssessmentTypesController(TestContext TestContext)
        {
            this.context = TestContext;
        }

        // GET: api/values
        [HttpGet]
        [Produces(typeof(IEnumerable<AssessmentType>))]
        public async Task<IActionResult> Get([FromQuery]SearchViewModel search)
        {
            int currentPage = 1;
            int currentPageSize = 4;

            var values = await this.context.AssessmentTypes
                .OrderBy(f => search.Field == "code" ? f.Code : f.Description)
                .Skip((currentPage - 1) * currentPageSize)
                .Take(currentPageSize)
                .ToListAsync();

            return Ok(values);
        }
    }
}
