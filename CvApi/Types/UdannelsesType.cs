using CvApi.Models;
using GraphQL.Types;

namespace CvApi.Types
{
    public class UdannelsesType : ObjectGraphType<Udannelse>
    {
        public UdannelsesType()
        {
            Name = "uddannelse";
            Field(x => x.Id);
            Field(x => x.Navn);
        }
    }
}