using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjercicioTecnico.Models
{
    public class ClienteViewModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Pais { get; set; }
        public string TipoEntidad { get; set; }

        public ClienteViewModel() { }
        public ClienteViewModel(Cliente model, string pais, string tipoEntidad)
        {
            Id = model.Id;
            Nombre = model.Nombre;
            Pais = pais;
            TipoEntidad = tipoEntidad;
        }
    }
}
