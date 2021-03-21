using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class TimerGivesPlayerEnoughTime
    {
        // A Test behaves as an ordinary method
        [Test]
        public void TimerGivesPlayerEnoughTimeSimplePasses()
        {
            GraphicTimerCATCH gtc = new GraphicTimerCATCH();
            Assert.IsTrue(gtc.GetAllottedTime() >= 10f);
        }
    }
}
