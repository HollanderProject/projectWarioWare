using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class HERDgm
    {
        // A Test behaves as an ordinary method
        [Test]
        public void HERDInitialWinState()
        {
            // Use the Assert class to test conditions

            Assert.IsFalse(GameManagerHERD.playerWin);
        }
        [Test]
        public void HERDInitialLoseState()
        {
            // Use the Assert class to test conditions

            Assert.IsFalse(GameManagerHERD.playerLose);
        }
    }
}
