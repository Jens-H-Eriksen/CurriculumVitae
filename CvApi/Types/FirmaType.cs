using CvApi.Models;
using GraphQL.Types;

namespace CvApi.Types
{
    public class FirmaType : ObjectGraphType<Firma>
    {
        public FirmaType()
        {
            Name = "firma";
            Field(x => x.Id);
            Field(x => x.Navn, nullable: true);
            Field(x => x.Beskrivelse, nullable: true);
        }
    }
}

