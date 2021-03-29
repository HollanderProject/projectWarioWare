using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class fetchCatch
    {
        mainController.CollectionGameController controller;
        int temp;
        // A Test behaves as an ordinary method
        [Test]
        public void fetchCatchSimplePasses()
        {
            // Use the Assert class to test conditions
            temp = controller.actualGame(1);
            Assert.AreEqual(4, temp);
        }

    }
}
