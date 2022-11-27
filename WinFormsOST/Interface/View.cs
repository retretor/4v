using System;

namespace OST_Labs
{
    abstract class View : IDisposable
    {
        public View(Model model, Controller controller)
        {
            Model = model;
            Controller = controller;
        }

        public readonly Model Model;

        private Controller Controller { get; set; }
        
        public void ReactToUserActions(ModelOperations modelOperation)
        {
            Controller.Execute(modelOperation, Model);
        }
        public void Dispose()
        {
            DataUnbind();
        }

        public abstract void DataBind();
        public abstract void DataUnbind();
    }
}
