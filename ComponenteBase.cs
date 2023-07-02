// El Componente Base proporciona la funcionalidad básica de almacenar
// una informacion, en instancia del mediador dentro de los objetos componentes.
using RefactoringGuru.DesignPatterns.Mediator.Conceptual;

class ComponenteBase
    {
        //Funciones para hacer validas las comunicaciones entre 
        // el Mediator y los componentes
        protected IMediator _mediator;

        public ComponenteBase(IMediator mediator = null)
        {
            this._mediator = mediator;
        }

        public void SetMediator(IMediator mediator)
        {
            this._mediator = mediator;
        }
    }