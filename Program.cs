internal class Program
{
    private static void Main(string[] args)
    {
         // El código del cliente.
            Component1 component1 = new Component1();
            Component2 component2 = new Component2();
            new MediatorConcreto(component1, component2);

            Console.WriteLine("El cliente activa la operación A.");
            component1.DoA();

            Console.WriteLine();

            Console.WriteLine("El cliente activa la operación D.");
            component2.DoD();
    }
}
