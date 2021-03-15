using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class TimerTests
    {
        // Check the timer is configured properly on start-up
        [Test]
        public void TimerConfigTest()
        {
            var gameObject = new GameObject();
            var timer = gameObject.AddComponent<GraphicTimer>();

            // Validate that the startingTime length duration is 10f and currentTime is equal to 0f
            // at time of launch
            Assert.IsTrue(timer.startingTime == 10f && timer.currentTime == 0f);
        }
    }
}
