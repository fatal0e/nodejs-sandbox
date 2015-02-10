using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nodejsMarshal
{
    public class Startup
    {
        public async Task<object> Invoke(object input)
        {
            int v = (int)input;
            return AddSeven(v);
        }

        private int AddSeven(int number)
        {
            return number + 7;
        }
    }
}
