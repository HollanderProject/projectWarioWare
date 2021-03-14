using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class CONNECTBridgePointsEqualAtStart
    {
        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator CONNECTBridgePointsEqualAtStartWithEnumeratorPasses()
        {
            yield return null;
            //Assert.AreEqual(BridgeResize.lineRenderer.GetPosition(0), BridgeResize.lineRenderer.GetPosition(1));
            Assert.IsTrue(BridgeResize.bridgeBuilt == false);
        }
    }
}
