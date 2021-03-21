using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class TimerTest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void startingTime()
        {
            // Use the Assert class to test conditions
            //GraphicTimerHERD timer = new GraphicTimerHERD();
            var gameObject = new GameObject();
            var timer = gameObject.AddComponent<GraphicTimerHERD>();

            Assert.IsTrue(timer.startingTime == 10f);
        }

        [Test]
        public void currentTime()
        {
            // Use the Assert class to test conditions
            //GraphicTimerHERD timer = new GraphicTimerHERD();
            var gameObject = new GameObject();
            var timer = gameObject.AddComponent<GraphicTimerHERD>();

            Assert.IsTrue(timer.currentTime == 0f);
        }
    }
}
