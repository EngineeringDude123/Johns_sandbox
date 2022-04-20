using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{

    class RoboBee4000 : IWorker
    {

        public string Job
        {
            get { return "Egg Care"; }
        }
        public void WorkTheNextShift()
        {
            // Do the work of three bees!
        }
    }
}
