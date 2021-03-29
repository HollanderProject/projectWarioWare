using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class fetchNudge
    {
        mainController.CollectionGameController controller;
        int temp;
        // A Test behaves as an ordinary method
        [Test]
        public void fetchNudgeSimplePasses()
        {
            // Use the Assert class to test conditions
            temp = controller.actualGame(9);
            Assert.AreEqual(12, temp);
        }

    }
}
