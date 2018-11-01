using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntidadesCompartidas;

namespace Logica
{
    public interface ILogicaViaje
    {
        //BUSCAR

        Viaje Buscar(int pNumero);
              

        //ABM
        void Modificar(Viaje pViaje);

        void Eliminar(Viaje pViaje);

        void Agregar(Viaje pViaje);

        
        //  LISTAS
        
        List<ViajesNacionales> ListarViaje();
        List<ViajesInternacionales> Listar();
        
    }
}
