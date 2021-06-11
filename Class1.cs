using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace pendientes
{
    class Pendientes
    {

	
        List<string> pendientes = new List<string>();

        public void push(string pendiente)
        {
            this.pendientes.Add(pendiente);
        }

        public string pop()
        {
            string value = this.pendientes[this.pendientes.Count - 1];
            this.pendientes.RemoveAt(this.pendientes.Count - 1);
            return value;
        }

        public string peek()
        {
            return this.pendientes[this.pendientes.Count - 1];
        }
    }
}
