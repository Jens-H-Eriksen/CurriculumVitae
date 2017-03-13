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
            Field(x => x.Navn);
            Field(x => x.Beskrivelse);
        }
    }
}

