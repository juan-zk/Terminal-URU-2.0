using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntidadesCompartidas;
using Persistencia;

namespace Logica
{
    internal class LogicaViaje : ILogicaViaje
    {
        //singleton
        private static LogicaViaje _instancia = null;
        private LogicaViaje() { }
        public static LogicaViaje GetInstancia()
        {
            if (_instancia == null)
                _instancia = new LogicaViaje();
            return _instancia;
        }

        //BUSCAR

        public Viaje Buscar(int pNumero)
        {
            Viaje v;
            v = FabricaPersistencia.GetPersistenciaViajeInternacional().Buscar(pNumero);

            if (v==null)
                v = FabricaPersistencia.GetPersistenciaViajeNacional().BuscarViaje(pNumero);

            return v;
        }

        // ABM

        public void Modificar(Viaje pViaje)
        {
            List<Viaje> viajes = new List<Viaje>();
            viajes.AddRange(Listar());
            TimeSpan dif;

            if (pViaje._FechaArribo <= pViaje._FechaPartida)
            {
                throw new Exception("La fecha de arribo debe ser posterior a la fecha de partida");
            }
            foreach (Viaje vi in viajes)
            {
                if (vi._NumViaje != pViaje._NumViaje && vi._Ter._Codigo == pViaje._Ter._Codigo && vi._FechaPartida.Date == pViaje._FechaPartida.Date)
                {
                    dif = vi._FechaPartida.TimeOfDay.Subtract(pViaje._FechaPartida.TimeOfDay);
                    if (dif.TotalHours < 2 && dif.TotalHours > -2)
                        throw new Exception("No puede haber un viaje al mismo destino con la misma hora de salida, al menos 2 hrs de diferencia.");
                }
            }
            if (pViaje is ViajesInternacionales)
                FabricaPersistencia.GetPersistenciaViajeInternacional().Modificar((ViajesInternacionales)pViaje);
            else
                FabricaPersistencia.GetPersistenciaViajeNacional().ModificarViaje((ViajesNacionales)pViaje);
        }

        public void Eliminar(Viaje pViaje)
        {
            if (pViaje is ViajesInternacionales)
                FabricaPersistencia.GetPersistenciaViajeInternacional().Eliminar((ViajesInternacionales)pViaje);
            else
                FabricaPersistencia.GetPersistenciaViajeNacional().EliminarViaje((ViajesNacionales)pViaje);
        }

        public void Agregar(Viaje pViaje)
        {

            List<Viaje> viajes = new List<Viaje>();
            viajes.AddRange(Listar());
            TimeSpan dif;
            if (pViaje._FechaArribo < DateTime.Now || pViaje._FechaPartida < DateTime.Now)
            {
                throw new Exception("La fecha de arribo y de partida deben ser posteriores a la fecha actual");
            }
            if (pViaje._FechaArribo <= pViaje._FechaPartida)
            {
                throw new Exception("La fecha de arribo debe ser posterior a la fecha de partida");
            }
            foreach (Viaje vi in viajes)
            {
                if (vi._Ter._Codigo == pViaje._Ter._Codigo && vi._FechaPartida.Date == pViaje._FechaPartida.Date)
                {
                    dif = vi._FechaPartida.TimeOfDay.Subtract(pViaje._FechaPartida.TimeOfDay);
                    if (dif.TotalHours < 2 && dif.TotalHours > -2)
                        throw new Exception("No puede haber un viaje al mismo destino con la misma hora de salida, al menos 2 hrs de diferencia.");
                }
            }
            if (pViaje is ViajesInternacionales)
                FabricaPersistencia.GetPersistenciaViajeInternacional().Agregar((ViajesInternacionales)pViaje);
            else
                FabricaPersistencia.GetPersistenciaViajeNacional().AgregarViaje((ViajesNacionales)pViaje);
        }

        
        // LISTAS

        public List<Viaje> Listar()
        {
            List<Viaje> viajes = new List<Viaje>();
            viajes.AddRange(FabricaPersistencia.GetPersistenciaViajeInternacional().Listar());
            viajes.AddRange(FabricaPersistencia.GetPersistenciaViajeNacional().ListarViaje());
            return viajes;
        }

    }
}
