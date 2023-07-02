// Los componentes concretos implementan varias funciones, no dependen de
// otros componentes. Tampoco dependen de ningún mediador concreto
// clases.
class Component1 : ComponenteBase
    {
        //Funciones para emitir mensajes que pasara al mediator y posterior al destinatario
        public void DoA()
        {
            Console.WriteLine("El componente 2 hace A.");

            this._mediator.Notify(this, "A");
        }

        public void DoB()
        {
            Console.WriteLine("El componente 2 hace B.");

            this._mediator.Notify(this, "B");
        }
    }