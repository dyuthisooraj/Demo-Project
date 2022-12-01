using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeApplicationDomain;

namespace EmployeeBusinessLogicLayer.Interfaces
{
    public interface IEmployee
    {
        List <EmployeeRegistration> Get();

        void Post(EmployeeRegistration emp1) ;

        List<EmployeeRegistration> Edit();

        List<EmployeeRegistration> Delete();


    }
}
