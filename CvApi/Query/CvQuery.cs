using CvApi.Repositories;
using CvApi.Types;
using GraphQL.Types;

namespace CvApi.Query
{
    public class CvQuery : ObjectGraphType
    {
        public CvQuery(CvRepository cvRepository)
        {
            //Field<FirmaType>(
            //        "firma",
            //        arguments: new QueryArguments(new QueryArgument<IntGraphType>() { Name = "id", Description = "firmaid" }),
            //        resolve: context =>
            //        {
            //            //  var id = context.GetArgument<int>("id");
            //            //return cvRepository.Get(1);

            //            return cvRepository.GetAll();
            //        }
            //        );

            Field<CvAfsnitType>(
                "afsnit",
                resolve: context =>
                {
                    return cvRepository.Get(1);
                }
            );
        }
    }
}