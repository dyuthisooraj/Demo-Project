using HalcyonApparelsApplicationLayer.Interface;
using HalcyonApparelsDomainLayer.Entities;
using HalcyonApparelsInfrastructureLayer.DataLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalcyonApparelsInfrastructureLayer.InterfaceImplementation
{
    public class AccessoryImplement:IAccessory
    {
        private readonly AppDBContext _dbobj;
        public AccessoryImplement(AppDBContext _dboj)
        {
            _dbobj = _dboj;
        }
        public List<AccessoryDetails> Get()
        {
            return _dbobj.AccessoryDetails.ToList();
        }

        public void Post(AccessoryDetails accessory)
        {
            _dbobj.AccessoryDetails.Add(accessory);
            _dbobj.SaveChanges();
        }
    }
}
