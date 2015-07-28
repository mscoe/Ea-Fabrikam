using System;
using System.Reflection;

namespace Fabrikam.Module1.Uc1.Services.WebApi.v1.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}