using CvApi.Models;
using GraphQL.Types;

namespace CvApi.Types
{
    public class UddannelsesType : ObjectGraphType<Uddannelse>
    {
        public UddannelsesType()
        {
            Name = "uddannelse";
            Field(x => x.Id);
            Field(x => x.Navn, nullable: true);
            Field(x => x.Beskrivelse, nullable: true);
        }
    }
}