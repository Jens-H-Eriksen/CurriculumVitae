using System.Collections.Generic;
using System.Threading.Tasks;
using CvApi.Models;
using CvApi.Repositories;
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
                arguments: new QueryArguments(new QueryArgument<IntGraphType>() { Name = "id", Description = "Firma id" }),
                resolve: context =>
                {
                    var id = context.GetArgument<int?>("id");
                    return new FirmaRepository().Get(id);
                 }
            );

            Field<ListGraphType<UddannelsesType>>(
                "uddannelse",
                arguments: new QueryArguments(new QueryArgument<IntGraphType>() { Name = "id", Description = "Uddannelse id" }),
                resolve: context =>
                {
                    var id = context.GetArgument<int?>("id");
                    return new UddannelseRepository().Get(id);
                }
            );

            Field<ListGraphType<ProjektType>>(
               "projekt",
                arguments: new QueryArguments(new QueryArgument<IntGraphType>() { Name = "id", Description = "Uddannelse id" }),
                resolve: context =>
                {
                    var id = context.GetArgument<int?>("id");
                    return new ProjektRepository().Get(id);
                }
           );

            Field<ListGraphType<KompetenceType>>(
               "kompetence",
                arguments: new QueryArguments(new QueryArgument<IntGraphType>() { Name = "id", Description = "Uddannelse id" }),
                resolve: context =>
                {
                    var id = context.GetArgument<int?>("id");
                    return new KompetenceRepository().Get(id);
                }
           );


        }
    }
}