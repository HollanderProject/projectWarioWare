using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class BladeActiveFalse
    {
        [Test]
        public void BladeActiveSetFalse()
        {
            var gameObject = new GameObject();
            var blade = gameObject.AddComponent<Scissors>();
            blade.circleCollider = gameObject.AddComponent<CircleCollider2D>();
            // Set the blade to active
            blade.isCutting = true;

            // Call the stop cutting function, which is triggered by releasing the LMB
            blade.StopCutting();

            // Assert that the blade is no longer active
            Assert.IsFalse(blade.isCutting);
        }
    }
}
