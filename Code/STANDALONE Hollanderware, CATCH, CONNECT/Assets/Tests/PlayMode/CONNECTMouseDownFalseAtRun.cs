using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class CONNECTMouseDownFalseAtRun
    {
        [UnityTest]
        public IEnumerator CONNECTMouseDownFalseAtRunWithEnumeratorPasses()
        {
            yield return null;
            Assert.AreEqual(ClickDetector.mouseDown, false);
        }
    }
}
