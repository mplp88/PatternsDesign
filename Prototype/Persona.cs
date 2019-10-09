using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Persona : IClonable<Persona>
    {
        public string Apellido { get; set; }

        public string Nombre { get; set; }

        public string Domicilio{ get; set; }

        public Persona Clone()
        {
            Persona p = new Persona();

            foreach (PropertyInfo propertyInfo in this.GetType().GetProperties())
            {
                p.GetType().GetProperty(propertyInfo.Name).SetValue(p, propertyInfo.GetValue(this));
            }

            return p;
        }
        
    }
}
