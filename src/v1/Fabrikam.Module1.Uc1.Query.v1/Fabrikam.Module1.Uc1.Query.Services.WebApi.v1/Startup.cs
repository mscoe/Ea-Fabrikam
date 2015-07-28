using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Fabrikam.Module1.Uc1.Query.Services.WebApi.v1.Startup))]

namespace Fabrikam.Module1.Uc1.Query.Services.WebApi.v1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
