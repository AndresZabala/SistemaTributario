using MvcDatos;
using MvcEntidad;
using System;

namespace MvcMapeo
{
    public class PersonaMapper
    {
        //Convertir una persona en Tercero
        public static Tercero MapearPersonaTercero(Persona p)
        {
            return new Tercero
            {
                Id = p.Id,
                Identificacion = p.NumeroDocumento,
                TipoIdentificacion = p.NumeroDocumento,
                Nombre = p.NumeroDocumento,
                Direccion = p.Direccion,
                Telefono = p.TelefonoContacto,
                EsProveedor = p.Proveedor,
                FechaCreacion = DateTime.Now
            };
        }

        //Convertir tercero en una persona
        public static Persona MapearTerceroPersona(Tercero t)
        {
            return new Persona
            {
                NumeroDocumento = t.Identificacion,
                TipoDocumento = t.TipoIdentificacion,
                NombreCompleto = t.Nombre,
                Direccion = t.Direccion,
                TelefonoContacto = t.Telefono,
                Proveedor = t.EsProveedor,
                Id = t.Id                
            };
        }

    }
}
