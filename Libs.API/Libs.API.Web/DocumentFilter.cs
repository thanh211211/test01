using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Collections.Generic;

namespace Halliburton.App.Web
{
    public class DocumentFilter : IDocumentFilter
    {
        public void Apply(SwaggerDocument swaggerDoc, DocumentFilterContext context)
        {
            if (swaggerDoc != null)
                swaggerDoc.Schemes = new List<string> { "http" };//, "https"};
        }
    }
}
