using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class ReservaVehiculo
    {

        public int idReserva { get; set; }
        public String Placa { get; set; }
        public string idCliente { get; set; }
        public int montoReserva { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechafinal { get; set; }
        public DateTime fechaReserva { get; set; }

        public ReservaVehiculo(int idReserva, string placa, string idCliente, DateTime fechaReserva, DateTime fechaInicio, DateTime fechafinal, int montoReserva)
        {
            this.idReserva = idReserva;
            Placa = placa;
            this.idCliente = idCliente;
            this.montoReserva = montoReserva;
            this.fechaReserva = fechaReserva;
            this.fechafinal = fechafinal;
            this.fechaInicio = fechaInicio; ;

        }

        public ReservaVehiculo()
        {
           
        }
    }



    
}
