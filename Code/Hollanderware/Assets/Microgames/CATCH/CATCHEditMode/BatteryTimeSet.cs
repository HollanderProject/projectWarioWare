using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class BatteryTimeSet
    {
        // A Test behaves as an ordinary method
        [Test]
        public void BatteryTimeSetSimplePasses()
        {
            GraphicTimerCATCH gtc = new GraphicTimerCATCH();
            Assert.IsNotNull(gtc.GetAllottedTime());
        }
    }
}
