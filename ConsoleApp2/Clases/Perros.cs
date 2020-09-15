using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Perros
    {
        private string _NombrePerro;
        private string _Raza;
        private string _Dueño;
        private string _Comentarios;

        public Perros(string name, string raza, string dueño)
        {
            this._NombrePerro = name;
            this._Raza = raza;
            this._Dueño = dueño;
        }
        public string Nombre { get => _NombrePerro; set => _NombrePerro = value; }
        public string Raza { get => _Raza; set => _Raza = value; }
        public string Dueño { get => _Dueño; set => _Dueño = value; }

        public void NuevaVisita(string comentario)
        {
            this._Comentarios += ("\n" + comentario);  
        }


    }
}
