using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KerimProje.ToDo.Web.Middlewares
{
    public static class CustomFileExtension
    {
        public static void UseCustomStaticFiles(this IApplicationBuilder app)
        {
            app.UseStaticFiles();
        }
    }
}
