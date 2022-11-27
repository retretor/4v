using System;

namespace OST_Labs
{
    enum ModelOperations
    {
        // Сохранение настроек
        SaveSettings,
        // Рабочий такт
        WorkingCycle,
        // Завершение сеанса
        EndOfSession
    }

    class Controller
    {
        public void Execute(ModelOperations operation, Model model)
        {
            if (model == null)
                throw new ArgumentNullException("Empty model");
            switch (operation)
            {
                case ModelOperations.SaveSettings:                  
                    model.SaveSettings();
                    break;
                case ModelOperations.WorkingCycle:
                    model.WorkingCycle();
                    break;
                case ModelOperations.EndOfSession:
                    model.Clear();
                    break;
                default:
                    throw new ArgumentException("Неизвестная операция: " + operation + "operation");
            }
        }
    }
}
