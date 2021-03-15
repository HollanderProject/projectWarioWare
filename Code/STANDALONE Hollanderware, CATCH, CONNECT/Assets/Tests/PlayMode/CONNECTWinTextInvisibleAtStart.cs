using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class CONNECTWinTextInvisibleAtStart
    {
        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator CONNECTWinTextInvisibleAtStartWithEnumeratorPasses()
        {
            yield return null;
            Assert.AreEqual(WinText.winText.color.a, new Color(1f, 1f, 1f, 0f));
        }
    }
}
