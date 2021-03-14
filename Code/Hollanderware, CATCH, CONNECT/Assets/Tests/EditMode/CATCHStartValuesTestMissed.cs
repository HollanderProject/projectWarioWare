using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class StartValuesTestMissed
    {
        [UnityTest]
        public IEnumerator StartValuesTestMissedWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            Assert.AreEqual(FailScript.failScoreValue, 0);
            yield return null;
        }
    }
}
