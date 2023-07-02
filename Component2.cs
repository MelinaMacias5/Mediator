//Va a hacer la comunicacion con el componente 1
class Component2 : ComponenteBase
    {
        //Funciones encargadas de enviar y recibir mensajes
        public void DoC()
        {
            Console.WriteLine("El componente 2 hace C.");

            this._mediator.Notify(this, "C");
        }

        public void DoD()
        {
            Console.WriteLine("El componente 2 hace D.");

            this._mediator.Notify(this, "D");
        }
    }
    