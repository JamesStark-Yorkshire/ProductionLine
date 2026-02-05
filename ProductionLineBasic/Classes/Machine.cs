using ProductionLineBasic.Interface;

namespace ProductionLineBasic.Classes;

public class Machine(string name) : Subject
{
    private string name = name;
    
    public override ISubject SetState(string s)
    {
        Console.Write($"[Machine: {name}] ");
        
        return base.SetState(s);
    }
    
    public override void NotifyAllObservers()
    {
        foreach (IObserver o in observers)
        {
            o.Update(state, name);
        }
        
        Console.WriteLine();
    }
}