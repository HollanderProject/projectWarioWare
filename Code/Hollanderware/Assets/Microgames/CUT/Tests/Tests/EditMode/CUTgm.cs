using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class CUTgm
    {
        // Note: CUT and HERD use the same class to control the win/lose state of the game
        // A Test behaves as an ordinary method
        [Test]
        public void CUTInitialWinState()
        {
            // Use the Assert class to test conditions
            Assert.IsFalse(GameManagerHERD.playerWin);
        }
        [Test]
        public void CUTInitialLoseState()
        {
            // Use the Assert class to test conditions

            Assert.IsFalse(GameManagerHERD.playerLose);
        }
    }
}
