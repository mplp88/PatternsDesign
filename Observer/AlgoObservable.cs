using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    abstract class AlgoObservable
    {
        protected List<ObservadorDeContainers> _observers = new List<ObservadorDeContainers>();

        public void AgregarObservador(ObservadorDeContainers o)
        {
            _observers.Add(o);
        }

        public void QuitarObservador(ObservadorDeContainers o)
        {
            _observers.Remove(o);
        }

        protected void Notificar()
        {
            foreach (var observador in _observers)
            {
                observador.AnalizarContainer(this);
            }
        }
    }
}
