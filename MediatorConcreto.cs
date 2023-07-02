// Los mediadores concretos implementan un comportamiento cooperativo 
// coordinando varios componentes.
   using RefactoringGuru.DesignPatterns.Mediator.Conceptual;
   //Aqui es donde los componentes van a enviar los mensajes
   //y uno vez aprobado  este mensaje se va a enviar al destinatario.
    class MediatorConcreto : IMediator
    {
        private Component1 _component1;

        private Component2 _component2;

        public MediatorConcreto(Component1 component1, Component2 component2)
        {
            this._component1 = component1;
            this._component1.SetMediator(this);
            this._component2 = component2;
            this._component2.SetMediator(this);
        }

    public override bool Equals(object obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

// Funciones para realizar las validaciones 
    public void Notify(object sender, string ev)
    
        { 
            //Se envia el mensaje a el destinatario correspondiente
            if (ev == "A")
            { 
                Console.WriteLine("El mediador reacciona en A y desencadena las siguientes operaciones:");
                this._component2.DoC();
            }
            //El destinatario recibe el mensaje
            if (ev == "D")
            {
                Console.WriteLine("El mediador reacciona en D y desencadena las siguientes operaciones:");
                this._component1.DoB();
                this._component2.DoC();
            }
        }

    public override string ToString()
    {
        return base.ToString();
    }
}