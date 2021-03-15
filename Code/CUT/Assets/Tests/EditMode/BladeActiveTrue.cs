using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class BladeActiveTrue
    {
        // A Test behaves as an ordinary method
        [Test]
        public void BladeActiveSetTrue()
        {
            var gameObject = new GameObject();
            var blade = gameObject.AddComponent<Scissors>();
            blade.circleCollider = gameObject.AddComponent<CircleCollider2D>();
            // Set the blade to inactive
            blade.isCutting = false;

            // Call the start cutting function, which is triggered by pressing the LMB
            blade.StartCutting();

            // Assert that the blade becomes active
            Assert.IsTrue(blade.isCutting);
        }
    }
}
