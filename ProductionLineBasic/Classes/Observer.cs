using ProductionLineBasic.Interface;

namespace ProductionLineBasic.Classes
{
    public class Observer(string name) : IObserver
    {
        protected string name = name;

        public virtual void Update(string state, string from)
        {
            // Do Nothing
        }
    }
}