using Microsoft.VisualStudio.TestTools.UnitTesting;
using humains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace humains.Tests
{
    [TestClass()]
    public class ToolsTests
    {
        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void divisionTest()
        {
            int i = 10;
            int y = 0;
            


            double result = Tools.division(i, y);

            
        }
    }
}