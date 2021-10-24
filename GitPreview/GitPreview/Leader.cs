using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitPreview
{
    public class Leader : Person
    {
        public int NumberOfWorkers { get; set; }

        public Leader()
        {
            for (int i = 0; i < 10000000; i++)
            {
                NumberOfWorkers += int.Parse(new Guid().ToString());
            }
        }

        public override string ToString()
        {
            return "I'm a leader";
        }
    }
}
