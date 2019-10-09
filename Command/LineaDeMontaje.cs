using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class LineaDeMontaje
    {
        List<Tarea> _tareas = new List<Tarea>();

        public void AgregarTarea(Tarea t)
        {
            _tareas.Add(t);
        }

        public void IniciarProceso()
        {
            foreach (var t in _tareas)
                t.Ejecutar();
        }
    }
}
