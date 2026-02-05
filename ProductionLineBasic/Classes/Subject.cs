using System.ComponentModel;
using ProductionLineBasic.Enums;
using ProductionLineBasic.Interface;

namespace ProductionLineBasic.Classes;

public class Subject : ISubject
{
    protected string state;
    
    protected List<IObserver> observers;

    protected Subject()
    {
        state = nameof(SubjectState.IDLE);
        observers = new List<IObserver>();
    }

    public virtual ISubject SetState(string s)
    {
        Console.WriteLine($"State changing: {state} -> {s}");
        
        if (!Enum.IsDefined(typeof(SubjectState), s))
        {
            throw new InvalidEnumArgumentException();
        }
        
        state = s;
        
        NotifyAllObservers();

        return this;
    }

    public virtual ISubject Attach(IObserver o)
    {
        observers.Add(o);
        
        Console.WriteLine($"{o.GetType().Name} attached to {GetType().Name}");

        return this;
    }

    public virtual void NotifyAllObservers()
    {
        foreach (IObserver o in observers)
        {
            o.Update(state, nameof(o));
        }

        Console.WriteLine();
    }
}