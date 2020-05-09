using MvcEntidad;
using System.Collections.Generic;

namespace MvcContrato
{
    public interface ILogicaTercero
    {
        void AgregarTercero(Persona tercero);

        void EditarTercero(Persona tercero);

        void EliminarTercero(long id);

        List<Persona> ListarTercero();
    }
}
