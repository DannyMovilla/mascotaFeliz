using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MascotaFeliz.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace MascotaFeliz.App.Persistencia
{
    public class RepositorioMascota : IRepositorioMascota
    {
        private readonly AppContext _appContext;

        public RepositorioMascota(AppContext appContext)
        {
            _appContext = appContext;
        }

        public Mascota AddMascota(Mascota mascota)
        {
            var mascotaNuevo = _appContext.Mascotas.Add(mascota);
            _appContext.SaveChanges();
            return mascotaNuevo.Entity;
        }

        public Mascota UpdateMascota(Mascota mascota)
        {
            var mascotaEncontrado = _appContext.Mascotas.FirstOrDefault(d => d.Id == mascota.Id);
            if(mascotaEncontrado != null)
            {
                mascotaEncontrado.Nombre = mascota.Nombre;
                mascotaEncontrado.Color = mascota.Color;
                mascotaEncontrado.Especie = mascota.Especie;
                mascotaEncontrado.Raza = mascota.Raza;
                mascotaEncontrado.Propietario = mascota.Propietario;
                mascotaEncontrado.Veterinario = mascota.Veterinario;
                mascotaEncontrado.HistoriaClinica = mascota.HistoriaClinica;
                _appContext.SaveChanges();
            }
            return mascotaEncontrado;
        }

        public void DeleteMascota(int idMascota)
        {
            var mascotaEncontrado = _appContext.Mascotas.FirstOrDefault(d => d.Id == idMascota);
            if (mascotaEncontrado == null)
                return;
            _appContext.Mascotas.Remove(mascotaEncontrado);
            _appContext.SaveChanges();
        }

        public IEnumerable<Mascota> GetAllMascotas()
        {
            return GetAllMascotas_();
        }

        public IEnumerable<Mascota> GetMascotaFiltro(Mascota mascota)
        {
            var mascotas = GetAllMascotas();
            if (mascotas != null)
            {
                if(!String.IsNullOrEmpty(mascota.Nombre))
                {
                    mascotas = mascotas.Where(s => s.Nombre.Contains(mascota.Nombre));
                }
                if(mascota.Propietario.Id != 0)
                {
                    mascotas = mascotas.Where(s => null != s.Propietario && s.Propietario.Id == mascota.Propietario.Id);
                }
                if(mascota.Veterinario.Id != 0)
                {
                    mascotas = mascotas.Where(s => null != s.Veterinario && s.Veterinario.Id == mascota.Veterinario.Id);
                }
            }
            return mascotas;
        }

        public IEnumerable<Mascota> GetAllMascotas_()
        {
            return _appContext.Mascotas.Include("Propietario").Include("Veterinario").Include("HistoriaClinica");
        }

        public Mascota GetMascota(int idMascota)
        {
            return _appContext.Mascotas.Include("Propietario").Include("Veterinario").Include("HistoriaClinica").FirstOrDefault(d => d.Id == idMascota);
        }
    }
}