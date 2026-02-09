using ProductionLineBackend.Classes;
using ProductionLineBasic.Classes;
using ProductionLineBasic.Enums;

namespace ProductionLineBackend;

// Class there store current machine status
public class Worker
{
    public static List<Machine> Machines;

    public static void Init()
    {
        Machines = new List<Machine>();
        Machines.Add(new Machine("Machine A"));
        Machines.Add(new Machine("Machine B"));
        Machines.Add(new Machine("Machine C"));
        
        Console.WriteLine("Machines are ready!");
    }

    public static void AttachMachineToDashboard(Dashboard dashboard)
    {
        Console.WriteLine("Machines attached to dashboard!");
        foreach (var machine in Machines)
        {
            machine.Attach(dashboard);
        }
    }

    public async static Task ChangeMachineStates()
    {
        Random rand = new Random();
        
        while (true)
        {
            Console.WriteLine("Randomisation In Progress");
            
            int randomNum = rand.Next(0, Machines.Count);
            var values = SubjectState.GetValues<SubjectState>();
            SubjectState randomState = values[rand.Next(0, values.Length)];

            var randomMachine = Machines[randomNum];

            randomMachine.SetState(randomState.ToString());

            await Task.Delay(5000);
        }
    }
}