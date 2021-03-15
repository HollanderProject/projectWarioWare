using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class BladeCutActive
    {
        [UnityTest]
        public IEnumerator BladeCutActives()
        {
            // Use the Assert class to test conditions.
            var gameObject = new GameObject();
            var blade = gameObject.AddComponent<Scissors>();

            blade.isCutting = true;

            // Use yield to skip a frame.

            Assert.IsTrue(gameObject.activeSelf);
            yield return (null);
        }
    }
}
