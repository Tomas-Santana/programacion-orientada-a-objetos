// using static In_out.Persona;

namespace In_out
{
    class UsoCoche
    {
        static void Main(String[] args)
        {
            Coche corvette = new Coche(largo: 5, ancho: 4, motor: "V8", ruedas: 4, pp: 1000);
            Coche challenger = new Coche(largo: 4, ancho: 4, motor: "V6", ruedas: 4, pp: 1000);
            Coche miata = new Coche(largo: 6, ancho: 5, motor: "V12", ruedas: 4, pp: 1500);
            Coche terios = new Coche(largo: 8, ancho: 6, motor: "V8", ruedas: 4, pp: 2000);
            Coche sportage = new Coche(largo: 5, ancho: 3, motor: "V6", ruedas: 4, pp: 1000);


            Camioneta camioneta1 = new Camioneta(largo: 8, ancho: 4, motor: "V8", ruedas: 4, kgcarga: 1000, plazasextra: 2, pp: 2000);
            Camioneta camioneta2 = new Camioneta(largo: 9, ancho: 4, motor: "V6", ruedas: 4, kgcarga: 1000, plazasextra: 2, pp: 2000);
            Camioneta camioneta3 = new Camioneta(largo: 10, ancho: 4, motor: "V8", ruedas: 4, kgcarga: 1000, plazasextra: 2, pp: 3000);
            Camioneta camioneta4 = new Camioneta(largo: 9, ancho: 4, motor: "V6", ruedas: 4, kgcarga: 1000, plazasextra: 2, pp: 4500);
            Camioneta camioneta5 = new Camioneta(largo: 8, ancho: 4, motor: "V8", ruedas: 4, kgcarga: 1000, plazasextra: 2, pp: 2500);


        }
    }
}
    