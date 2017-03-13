using CvApi.Repositories;
using CvApi.Types;
using GraphQL.Types;

namespace CvApi.Query
{
    public class CvQuery : ObjectGraphType
    {
        public CvQuery()
        {
            Field<CvType>(
                "cv",
                resolve: context =>
                {
                    return new CvRepository().Get();
                }
            );
        }
    }
}