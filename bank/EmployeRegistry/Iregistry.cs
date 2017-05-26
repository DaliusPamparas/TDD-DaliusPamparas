using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeRegistry
{
    interface Iregistry
    {
        List<Emploee> AllEmployees();
        void Fire(string ssn);
        void Hire(Emploee employee);
    }
}
