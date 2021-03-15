using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class GraphicTimerCheck
    {

        [Test]
        public void TimerIsInitalized()
        {
            var GameObject = new GameObject();
            var timer = GameObject.AddComponent<GraphicTimer>();

            Assert.IsTrue(timer.startingTime == 10f && timer.currentTime == 0f);
        }
    }
}
