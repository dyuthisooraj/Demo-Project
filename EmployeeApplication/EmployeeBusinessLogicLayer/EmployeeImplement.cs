using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeApplicationDal;
using EmployeeApplicationDomain;
using EmployeeBusinessLogicLayer.Interfaces;

namespace EmployeeBusinessLogicLayer
{
    public class EmployeeImplement : IEmployee
    {   
        private readonly EmployeeDBContext _dbobj;
        public EmployeeImplement(EmployeeDBContext _dboj)
        {
            _dbobj = _dboj;
        }
        public List<EmployeeRegistration> Delete()
        {
            throw new NotImplementedException();
        }

        public List<EmployeeRegistration> Edit()
        {
            throw new NotImplementedException();
        }
        
      
        public List<EmployeeRegistration> Get()
        {
            return _dbobj.Details.ToList();
        }

        public void Post(EmployeeRegistration emp1)
        {
            _dbobj.Details.Add(emp1);
            _dbobj.SaveChanges();
        }
    }
}
