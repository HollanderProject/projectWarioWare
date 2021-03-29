using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class fetchPoke
    {
        mainController.CollectionGameController controller;
        int temp;
        // A Test behaves as an ordinary method
        [Test]
        public void fetchPokeSimplePasses()
        {
            // Use the Assert class to test conditions
            temp = controller.actualGame(7);
            Assert.AreEqual(10, temp);
        }

    }
}
