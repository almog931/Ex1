using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    // delegate of mission.
    public delegate Double Func(Double d);

    class SingleMission : IMission
    {
        // event handler.
        public event EventHandler<double> OnCalculate; // An Event of when a mission is activated

        // members.
        public String Name { get; }
        public String Type { get; }
        private Func f;

        // constructor.
        public SingleMission(Func s, String n)
        {
            Name = n;
            Type = "Single";
            f = new Func(s);
        }

        // functions.
        // activ the deligat function on value.
        public double Calculate(double value)
        {
            double result = f(value);

            // invoke the event
            OnCalculate?.Invoke(this, result);

            return result;
        }
    }
}
