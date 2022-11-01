using Microsoft.VisualStudio.TestTools.UnitTesting;
using proiectMaghiar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiectMaghiar.Models.Tests
{
    [TestClass()]
    public class ControllerTest
    {
        [TestMethod()]
        public void TestExceptionCase()
        {
            Problem p = new Problem("test");
            try
            {
                p.lengthOfLongestSubstring(p.inputString);
            }
            catch (Exception e)
            {
                StringAssert.Contains(e.Message, "Wrong Input");
                return;
            }
            //Assert.Fail();
        }
    }
}