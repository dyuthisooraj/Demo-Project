using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace logger
{
    internal class Calculator
    {
       private Ilogger _logger;

        public Calculator(Ilogger logger)
        {
            _logger=logger;
        }

        public void Dividebyzero()
        {
            //try
            //{
            //    int zero = 0;
            //    int x = 10 / zero;
            //}

            //catch (Exception e)
            //{
            //    _logger.Info(Environment.NewLine + e.ToString());
            //}

            _logger.Info("error : divide by sero");

        }
    }
}
