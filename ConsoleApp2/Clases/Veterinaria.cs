using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Veterinaria
    {
        private string _VetNombre;
        private string _Direccion;
        private List<Veterinarios> _Veterinarios;
        private List<Perros> _Perros;
        public Veterinaria(string name, string dire)

        {
            this._VetNombre = name;
            this._Direccion = dire;
            this._Veterinarios = new List<Veterinarios>();
            this._Perros = new List<Perros>();
        }

        public string VetNombre { get => _VetNombre; set => _VetNombre = value; }

        public string Direccion { get => _Direccion; set => _Direccion = value; }

        public string GetName()
        {
            return _VetNombre;
        }

        public string GetListaVet()
        {
            string Listado = null;
            foreach (Veterinarios veterinario in _Veterinarios)
            {
                Listado += (veterinario.Nombre + " - ");
                Listado += (veterinario.Estado + " - ");
                Listado += (veterinario.Horario + "\n");
            }
            return Listado;
        }
        public string GetListaPerros()
        {
            string Listado = null;
            foreach (Perros perro in _Perros)
            {
                Listado += (perro.Nombre + " - ");
                Listado += (perro.Raza + " - ");
                Listado += (perro.Dueño + "\n");
            }
            return Listado;
        }
    }
}
