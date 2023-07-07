// using static In_out.Persona;

namespace In_out
{
    class UsoCoche
    {
        static void Main(String[] args)
        {
            
            Coche optra = new();
            optra.Describe();
            optra.Drive();

            Console.WriteLine(optra.GetPeso());
        }
    }
}
    