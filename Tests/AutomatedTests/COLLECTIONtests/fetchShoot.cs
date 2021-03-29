using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class fetchShoot
    {
        mainController.CollectionGameController controller;
        int temp;
        // A Test behaves as an ordinary method
        [Test]
        public void fetchShootSimplePasses()
        {
            // Use the Assert class to test conditions
            temp = controller.actualGame(8);
            Assert.AreEqual(11, temp);
        }

    }
}
