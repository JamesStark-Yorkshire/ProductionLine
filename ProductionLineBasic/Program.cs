

using ProductionLineBasic.Classes;
using ProductionLineBasic.Enums;

namespace ProductionLineBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Machines
            Machine machineA = new Machine("Machine A");
            Machine machineB = new Machine("Machine B");
            Machine machineC = new Machine("Machine C");

            // Create Employees
            Employee manager = new Employee("Jose", "Manager");
            Employee technician = new Employee("Julian", "Technician");
            Employee clerk = new Employee("Ramon", "Clerk");

            Console.WriteLine("\n--- Registering Employees to Machines ---");

            // Register employees' interest in machines
            machineA.Attach(manager);
            machineA.Attach(technician);

            machineB.Attach(manager);
            machineB.Attach(clerk);

            machineC.Attach(manager);
            machineC.Attach(technician);
            machineC.Attach(clerk);

            Console.WriteLine("\n--- Simulating Machine State Changes ---");

            // Simulate state changes
            machineA.SetState(nameof(SubjectState.PRODUCING));
            machineB.SetState(nameof(SubjectState.PRODUCING));
            machineC.SetState(nameof(SubjectState.STARVED));

            machineA.SetState(nameof(SubjectState.IDLE));
            machineB.SetState(nameof(SubjectState.STARVED));
            machineC.SetState(nameof(SubjectState.PRODUCING));

            machineA.SetState(nameof(SubjectState.PRODUCING));
            machineB.SetState(nameof(SubjectState.IDLE));
            machineC.SetState(nameof(SubjectState.IDLE));

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}