namespace ProductionLineBasic.Interface;

public interface ISubject
{
    public ISubject SetState(String s);
    public ISubject Attach(IObserver o);
    public void NotifyAllObservers();
}