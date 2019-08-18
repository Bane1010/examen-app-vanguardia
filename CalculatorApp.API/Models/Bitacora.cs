using System;

namespace BitacoraApp.API.Models
{
    
public class Bitacora{
    public int Id {get; set;}
    public  string NombreCliente { get; set;}
    public string Direccion { get; set; }
    public string Telefono {get; set;}
    public string NombreEquipo { get; set;}
    public string Descripcion {get; set;}
    public string Observacione {get; set;}
    public DateTime FechaIngreso {get; set;}
    public DateTime FechaEntrega {get; set;}
}

}