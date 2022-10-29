using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp_Test.Data
{
    public class JwtService
    {
        public Task<string> Get(string userName, string password)
        {
            return Task.FromResult("12314436");
        }
    }
}
