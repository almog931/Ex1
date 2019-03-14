using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    class FunctionsContainer
    {

        // members
        private Dictionary<String, Func> funcsMap;     // the data structor.

        // constructor
        public FunctionsContainer()
        {
            funcsMap = new Dictionary<String, Func>();
        }

        // functions.
        public Func this[String idx]
        {
            set
            {
                // allowing only one func in the deligat.
                funcsMap[idx] = value;
            }
            get
            {
                if (!funcsMap.ContainsKey(idx))
                {
                    // defult func.
                    funcsMap[idx] = var => var;
                }
                return funcsMap[idx];
            }
        }

        public List<String> getAllMissions()
        {
            //get all names of missions.
            var nameList = new List<String>(funcsMap.Keys);

            return nameList;
        }

    }
}
