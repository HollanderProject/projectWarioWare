using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    // Check if the button is acting as intended (default values are set and you actually go to the lose screen when the time comes)
    public class loseScreenActive
    {
        [UnityTest]
        public IEnumerator loseScreenActiveWithEnumeratorPasses()
        {
            yield return null;
            Assert.AreEqual(ButtonInteraction.noseClicks, 0);
            Assert.AreEqual(ButtonInteraction.clicksRequired, 10);
            
            // TODO: ADD THE LOSE CONDITION TEST
        }
    }
}
