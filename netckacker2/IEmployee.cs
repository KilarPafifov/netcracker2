using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netckracker2
{
    interface IEmployee
    {
        void increaseSalary(int value);

        /**
         * @return Имя сотрудника
         */
        String getFirstName();

        /**
         * Устанавливает имя сотрудника
         * @param firstName Новое имя
         */
        void setFirstName(String firstName);

        /**
         * @return Фамилия сотрудника
         */
        String getLastName();

        /**
         * Устанавливает фамилию сотрудника
         * @param lastName Новая фамилия
         */
        void setLastName(String lastName);

        /**
         * @return Имя и затем фамилия сотрудника, разделенные символом " " (пробел)
         */
        String getFullName();

        /**
         * Устанавливает Менеджера сотрудника.
         * @param manager Сотрудник, являющийся менеджером данного сотрудника.
         * НЕ следует предполагать, что менеджер является экземпляром класса EmployeeImpl.
         */
        void setManager(IEmployee manager);

        /**
         * @return Имя и фамилия Менеджера, разделенные символом " " (пробел).
         * Если Менеджер не задан, возвращает строку "No manager".
         */
        String getManagerName();

        /**
         * Возвращает Менеджера верхнего уровня, т.е. вершину иерархии сотрудников,
         *   в которую входит данный сотрудник.
         * Если над данным сотрудником нет ни одного менеджера, возвращает данного сотрудника.
         * Замечание: поскольку менеджер, установленный методом {@link #setManager(Employee)},
         *   может быть экзепляром другого класса, при поиске топ-менеджера нельзя обращаться
         *   к полям класса EmployeeImpl. Более того, поскольку в интерфейсе Employee не объявлено
         *   метода getManager(), поиск топ-менеджера невозможно организовать в виде цикла.
         *   Вместо этого нужно использовать рекурсию (и это "более объектно-ориентированно").
         */
        IEmployee getTopManager();
    }
}
