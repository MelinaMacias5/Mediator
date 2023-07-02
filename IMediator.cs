using System;

namespace RefactoringGuru.DesignPatterns.Mediator.Conceptual
{
    //La interfaz Mediator declara un método utilizado por los componentes 
    // para notificar al mediador sobre varios eventos. 
    //El Mediador puede reaccionar ante estos eventos 
    //y pasar la ejecución a otros componentes.
    
    public interface IMediator
    {
        void Notify(object sender, string ev);
    }
    
}