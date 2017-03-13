using System.Collections.Generic;
using CvApi.Models;
using GraphQL.Types;

namespace CvApi.Types
{
    public class CvAfsnitType : ObjectGraphType<CvAfsnit>
    {
        public CvAfsnitType()
        {
            Name = "afsnit";
            Description = "Et afsnit i CV´et der lister fx. anættelser, uddannelser eller lign.";
            Field(x => x.Overskrift).Description("Overskrift til dette afsnit i CV´et");

            Field<ListGraphType<FirmaType>>(
                "firma",
                resolve: context =>
                {
                    return new List<Firma>() { new Firma() { Id = 1, Navn = "LEGO" }, new Firma() { Id = 2, Navn = "Maersk" } };
                }
            );
        }
    }
}