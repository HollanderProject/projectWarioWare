using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class fetchClimb
    {
        mainController.CollectionGameController controller;
        int temp;
        // A Test behaves as an ordinary method
        [Test]
        public void fetchClimbSimplePasses()
        {
            // Use the Assert class to test conditions
            temp = controller.actualGame(2);
            Assert.AreEqual(5, temp);
        }

    }
}
