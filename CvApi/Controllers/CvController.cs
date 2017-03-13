using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Web.Http;
using CvApi.Query;
using CvApi.Repositories;
using GraphQL;
using GraphQL.Types;

namespace CvApi.Controllers
{
    [Route("graphql")]
    public class CvController : ApiController
    {
        [HttpPost]
        public async Task<IHttpActionResult> Post([FromBody] String query)
        {
            var schema = new Schema { Query = new CvQuery() };

            var executionOptions = new ExecutionOptions { Schema = schema, Query = query };

            var result = await new DocumentExecuter().ExecuteAsync(executionOptions).ConfigureAwait(false);

            if (result.Errors?.Count > 0)
            {
                Debug.WriteLine(result.Errors.GetEnumerator().Current.Message);
                return BadRequest();
            }

            return Ok(result);
        }
    }
}