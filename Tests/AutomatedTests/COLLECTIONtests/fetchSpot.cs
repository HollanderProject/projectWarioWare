using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class fetchSpot
    {
        mainController.CollectionGameController controller;
        int temp;
        // A Test behaves as an ordinary method
        [Test]
        public void fetchSpotSimplePasses()
        {
            // Use the Assert class to test condition
						// 10 is passed if none of the other numebrs 0-9 are passed
            temp = controller.actualGame(10);
            Assert.AreEqual(13, temp);
        }

    }
}
