using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia
{
    public interface IRepositorioPropietario
    {
        IEnumerable<Propietario> GetAllPropietarios();

        Propietario AddPropietario (Propietario propietario);

        Propietario UpdatePropietario (Propietario propietario);

        void DeletePropietario (int idPropietario);

        Propietario GetPropietario(int idPropietario);

        IEnumerable<Propietario> GetPropietarioFiltro(String nombre);
    }
}