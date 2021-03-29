using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class fetchHerd
    {
        mainController.CollectionGameController controller;
        int temp;
        // A Test behaves as an ordinary method
        [Test]
        public void fetchHerdSimplePasses()
        {
            // Use the Assert class to test conditions
            temp = controller.actualGame(5);
            Assert.AreEqual(8, temp);
        }

    }
}
