using MvcContrato;
using MvcDatos;
using MvcEntidad;
using MvcMapeo;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MvcNegocio
{
    public class LogicaTercero : ILogicaTercero
    {
        TributariaEntities BD; //Instancia del Contexto de la BD


        //Constructor
        public LogicaTercero()
        {
            BD = new TributariaEntities();
        }

        //Aqui se pueden hacer las correspondientes validaciones
        //Como por ejemplo si ya existe un tercero etc. 
        //La capada de negocio es la encargada de verificar toda la complejidad de las validaciones de los datos
        public void AgregarTercero(Persona tercero)
        {
            var terceroMapeado = PersonaMapper.MapearPersonaTercero(tercero);
            BD.Tercero.Add(terceroMapeado);
            BD.SaveChanges();
        }

        public void EditarTercero(Persona tercero)
        {
            var terceroMapeado = PersonaMapper.MapearPersonaTercero(tercero);
            var TerceroEditar = BD.Tercero.Find(terceroMapeado.Id);
            TerceroEditar = terceroMapeado;
            BD.SaveChanges();
        }

        public void EliminarTercero(long id)
        {
            var TerceroEliminar = BD.Tercero.Find(id);
            BD.Tercero.Remove(TerceroEliminar);
            BD.SaveChanges();
        }

        public List<Persona> ListarTercero()
        {
            var terceros = BD.Tercero.ToList();
            var personas = new List<Persona>();
            terceros.ForEach(t =>
            {
                personas.Add(PersonaMapper.MapearTerceroPersona(t));
            });

            return personas;
        }
    }
}
