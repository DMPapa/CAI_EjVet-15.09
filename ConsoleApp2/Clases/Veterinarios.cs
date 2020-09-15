using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Veterinarios
    {
        private string _Nombre;
        private bool _Estado = true; //Si el veterinario se encuentra activo o no
        private string _Horarios; //Turno mañana-tarde-vespertino


        public Veterinarios(string name, bool state, string turno)
        {
            this._Nombre = name;
            this._Estado = state;
            this._Horarios = turno;
        }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public bool Estado { get => _Estado; set => _Estado = value; }
        public string Horario { get => _Horarios; set => _Horarios = value; }

        public void ActivoInactivo(bool nuevoestado)
        {
            this._Estado = nuevoestado;
            if (_Estado == false)
            {
                this.Horario = null;
            }    
        }
        public void NuevoHorario(string nuevohorario)
        {
            this._Horarios = nuevohorario;
        }
    }
}
