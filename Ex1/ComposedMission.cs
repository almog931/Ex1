using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    class ComposedMission : IMission
    {

        public event EventHandler<double> OnCalculate;  // An Event of when a mission is activated
        // members.
        public String Name { get; }
        public String Type { get; }
        List<Func> Missions;
        //constructor.
        public ComposedMission(String n)
        {
            Name = n;
            Type = "Composed";
            Missions = new List<Func>();
        }
        // add deligat to the list.
        public ComposedMission Add(Func s)
        {
            Missions.Add(s);
            return this;
        }
        // claculate the all the list of deligat func on value.
        public double Calculate(double value)
        {
            Double result = value;

            foreach (var f in Missions)
            {
                result = f(result);
            }
            // invoke the event.
            OnCalculate?.Invoke(this, result);

            return result;
        }
    }
}
