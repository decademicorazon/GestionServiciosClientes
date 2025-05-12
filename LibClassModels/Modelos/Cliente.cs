using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LibClassModels.Modelos
{
    public interface ICliente
    {
         public int Id { get; set; }
       public string Nombre { get; set; }
        public string Apellido { get; set; }

        decimal CalcularMontoTotal(decimal precioOriginal);
        decimal AplicarDescuento(decimal precioOriginal);


    }


    public class Cliente : ICliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public virtual string TipoCliente => "Normal";

        public List<Servicios>? ServiciosContratados { get; set; } = new List<Servicios>();

        public virtual decimal CalcularMontoTotal(decimal precioOriginal)
        {
          
            return ServiciosContratados.Sum(s => s.Precio);
        }
        public virtual decimal AplicarDescuento(decimal precioOriginal)
        {
            return precioOriginal;
        }
    }
    public class ClienteFrecuente : Cliente
    {
       // public decimal Descuento { get; set; }

        public override string TipoCliente => "Frecuente";

        public override decimal CalcularMontoTotal(decimal precioOriginal)
        {
           
          
            return precioOriginal * 0.25m; 
        }
        public override decimal AplicarDescuento(decimal precioOriginal)
        {
            return precioOriginal-(precioOriginal * 0.25m);
        }
    }

    public class ClienteOperativo : Cliente
    {
        public override string TipoCliente => "Operativo";


        public override decimal CalcularMontoTotal(decimal precioOriginal)
        {
            
            return precioOriginal * 0.10m;
        }
        public override decimal AplicarDescuento(decimal precioOriginal)
        {
            return precioOriginal-(precioOriginal * 0.10m);
        }
    }



}

