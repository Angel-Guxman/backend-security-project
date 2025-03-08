using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Enumerations
{
    public class Enums
    {
        public enum TypeExpenseCategory
        {
            INCOME, // Entrada - Ingresos
            EXPENSE, // Gastos - Egresos
        }

        public enum GoalStatus
        {
            IN_PROGRESS,
            COMPLETED,
        }

        public enum LogsClassification
        {
            FRONTEND,
            BACKEND,
        }
    }
}
