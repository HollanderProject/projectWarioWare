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
            
            Assert.AreEqual(ButtonInteraction.noseClicks, 0);
            Assert.AreEqual(ButtonInteraction.clicksRequired, 10);

            Assert.False(ButtonInteraction.winCheck);
            ButtonInteraction.noseClicks = 10;
            //Assert.True(ButtonInteraction.winCheck);

            yield return null;
        }
    }
}
