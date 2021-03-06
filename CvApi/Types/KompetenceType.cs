using CvApi.Models;
using GraphQL.Types;

namespace CvApi.Types
{
    public class KompetenceType : ObjectGraphType<Kompetence>
    {
        public KompetenceType()
        {
            Name = "kompetence";
            Field(x => x.Id);
            Field(x => x.Navn, nullable: true);
            Field(x => x.Beskrivelse, nullable: true);
        }
    }
}