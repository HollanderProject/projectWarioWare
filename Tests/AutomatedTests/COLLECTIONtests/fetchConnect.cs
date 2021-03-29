using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class fetchConnect
    {
        mainController.CollectionGameController controller;
        int temp;
        // A Test behaves as an ordinary method
        [Test]
        public void fetchConnectSimplePasses()
        {
            // Use the Assert class to test conditions
            temp = controller.actualGame(3);
            Assert.AreEqual(6, temp);
        }

    }
}
