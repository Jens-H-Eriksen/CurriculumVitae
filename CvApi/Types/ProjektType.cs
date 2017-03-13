using GraphQL.Types;

namespace CvApi.Types
{
    public class ProjektType : ObjectGraphType<Projekt>
    {
        public ProjektType()
        {
            Name = "projekt";
            Field(x => x.Id);
            Field(x => x.Navn);
            Field(x => x.Beskrivelse);
        }
    }
}