using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HaloGeneric
{
    internal class HaloGeneric<I>
    {
        private I data;
        public HaloGeneric(I data)
        {
            this.data = data;
        }

        public void PrintData()
        {
            Console.WriteLine("Halo gaiz " + data);
        }
    }
}
