namespace In_out
{
    class Camioneta : Coche {
        private int KgCarga {get; set;}
        private int PlazasExtra {get;set;}

        public Camioneta(
            int kgcarga, 
            int plazasextra, 
            int ancho=3, 
            int largo=8, 
            int pp=1000, 
            int ruedas=4, 
            string motor="15 cilindros") : base(ancho, largo, pp, ruedas, motor) {
            this.KgCarga = kgcarga;
            this.PlazasExtra = plazasextra;
        }

        public void SayHi() {
            Console.WriteLine($"Hola, tengo {this.GetAncho} de ancho");
        }
    }
}