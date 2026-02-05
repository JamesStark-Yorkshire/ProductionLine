namespace ProductionLineBasic.Classes;

public class Employee(string name, string role) : Observer(name)
{
    public override void Update(string state, string from)
    {
        Console.WriteLine($"[NOTIFICATION] Employee's Name: {name} | Employee's Role: {role} | Machine's State: {state} | Machine's State: {from} ");
    }
    
}