using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicManage.Tool
{
    public static class MyHttpContext
    {
        private static Microsoft.AspNetCore.Http.IHttpContextAccessor m_httpContextAccessor;

        static MyHttpContext()
        { }
        public static void Configure(Microsoft.AspNetCore.Http.IHttpContextAccessor httpContextAccessor)
        {
            m_httpContextAccessor = httpContextAccessor;
        }

        public static Microsoft.AspNetCore.Http.HttpContext Current
        {
            get
            {
                return m_httpContextAccessor.HttpContext;
            }
        }

    }
}
