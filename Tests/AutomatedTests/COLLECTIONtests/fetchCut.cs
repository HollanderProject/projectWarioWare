using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class fetchCut
    {
        mainController.CollectionGameController controller;
        int temp;
        // A Test behaves as an ordinary method
        [Test]
        public void fetchCutSimplePasses()
        {
            // Use the Assert class to test conditions
            temp = controller.actualGame(4);
            Assert.AreEqual(7, temp);
        }

    }
}
