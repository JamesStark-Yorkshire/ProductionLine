namespace ProductionLineBasic.Interface;

public interface IObserver
{
    public void Update(string state, string from);
}