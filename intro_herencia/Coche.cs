namespace In_out
{
    class Coche {
        int Ruedas {get;set;}
        int Ancho {get;set;}
        int Largo {get;set;}
        string Motor {get;set;}
        int Peso {get;set;}
        int PesoPlataforma {get;set;}
        bool TieneAsientosCuero {get;set;}
        public Coche(
            int ancho=3, 
            int largo=8, 
            int pp=1000, 
            int ruedas=4, 
            string motor="15 cilindros"
            ) 
        {
            this.Ancho = ancho;
            this.Ruedas = ruedas;
            this.Largo = largo;
            this.Motor = motor;
            this.PesoPlataforma = pp;
            this.SetPeso();
        }
        public int GetRuedas() {return this.Ruedas;}
        public int GetAncho() {return this.Ancho;}
        public int GetLargo() {return this.Largo;}
        public string GetMotor() {return this.Motor;}
        public int GetPeso() {return this.Peso;}
        public int GetPesoPlataforma() {return this.PesoPlataforma;}
        public void SetRuedas(int ruedas) {this.Ruedas = ruedas;}
        public void SetAncho(int ancho) {this.Ancho = ancho;}
        public void SetLargo(int largo) {this.Largo = largo;}
        public void SetMotor(string motor) {this.Motor = motor;}
        public void SetPeso() {
            int PESOBASE = 500;
            int PesoTotal = PESOBASE + this.PesoPlataforma;

            if (this.TieneAsientosCuero) {
                PesoTotal += 30;
            }
        }
        public void SetPesoPlataforma(int pesoplataforma) {this.PesoPlataforma = pesoplataforma;}
        public void SetAsientosCuero(string asientoscuerostring="no", bool asientoscuerobool = false) {
            if (asientoscuerostring.ToLower().Equals("si") || asientoscuerobool) {
                this.TieneAsientosCuero = true; 
            }
            this.TieneAsientosCuero = false;
        }
        public string GetAsientosCuero() {
            if (this.TieneAsientosCuero) {
                return "El carro tiene asientos de cuero.";
            }
            return "El carro no tiene asientos de cuero";
        }
        public int GetPrecio() {
            int PRECIOBASE = 10000;
            int PrecioTotal = PRECIOBASE;
            if (this.TieneAsientosCuero) {
                PrecioTotal += 200;
            }

            return PrecioTotal;
        }
        public void Drive()
        {
            Console.WriteLine("RRRRRRRUMMMMM");
        }
        public string Describe()
        {
            string exit = $"Este carro tiene {this.Ruedas} ruedas, y su plataforma pesa {this.PesoPlataforma}. Sus dimensiones son {this.Ancho}x{this.Largo} m. Tiene el motor {this.Motor} y pesa {this.Peso} kg";
            Console.WriteLine(exit);
            return exit;
        }
    }

}