using System.Collections.Generic;
using CvApi.Models;
using GraphQL.Types;

namespace CvApi.Types
{
    public class CvType : ObjectGraphType<Cv>
    {
        public CvType()
        {
            Name = "cv";
            Description = "Curriculum Vitae";
            Field(x => x.Overskrift).Description("Overskrift til CV´et");
            Field(x => x.Navn).Description("Navnet på den CV´et omhandler");
            Field(x => x.Alder).Description("Alderen på den CV´et omhandler");
            Field(x => x.Resume).Description("Kort indeledende resumé");

            Field<ListGraphType<FirmaType>>(
                "firma",
                resolve: context =>
                {
                    return new List<Firma>() { new Firma() { Id = 1, Navn = "Von Ands pengetank", Beskrivelse = "Pudsning af flere fantasilliarder mønter"}, new Firma() { Id = 2, Navn = "Smørfabrikken" } };
                }
            );

            Field<ListGraphType<UdannelsesType>>(
                "uddannelse",
                resolve: context =>
                {
                    return new List<Udannelse>() { new Udannelse() { Id = 1, Navn = "Gåserød lilleskole" }, new Udannelse() { Id = 2, Navn = "Andeby folkeskole" } };
                }
            );


            Field<ListGraphType<ProjektType>>(
               "projekt",
               resolve: context =>
               {
                   return new List<Projekt>() { new Projekt() { Id = 1, Navn = "Projekt Joakims arving" } };
               }
           );

            Field<ListGraphType<KompetenceType>>(
               "kompetence",
               resolve: context =>
               {
                   return new List<Kompetence>() { new Kompetence() { Id = 1, Navn = "Dovneri" }, new Kompetence() { Id = 2, Navn = "Raserianfald" } };
               }
           );
        }
    }
}