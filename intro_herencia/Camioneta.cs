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
            string motor="V6") : base(ancho, largo, pp, ruedas, motor) {
            this.KgCarga = kgcarga;
            this.PlazasExtra = plazasextra;
        }

        public int GetKgCarga() {return this.KgCarga;}
        public void SetKgCarga(int kgcarga) {this.KgCarga = kgcarga;}

        public int GetPlazasExtra() {return this.PlazasExtra;}
        public void SetPlazasExtra(int plazasextra) {this.PlazasExtra = plazasextra;}

        public void SayHi() {
            Console.WriteLine($"Hola, tengo {this.GetAncho} de ancho");
        }
    }
}