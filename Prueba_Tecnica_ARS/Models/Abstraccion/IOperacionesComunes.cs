using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba_Tecnica_ARS.Models.Abstraccion
{
    interface IOperacionesComunes
    {
        void Insertar();
        void Actualizar();
        void SwitchActivar(int id);
    }
}
