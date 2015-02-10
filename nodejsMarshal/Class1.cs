using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nodejsMarshal
{
    public class Startup
    {
        public async Task<object> Invoke(dynamic input)
        {
            int v = (int)input.anInteger;
            return AddSeven(v);
        }

        private int AddSeven(int number)
        {
            return number + 7;
        }
    }
}
