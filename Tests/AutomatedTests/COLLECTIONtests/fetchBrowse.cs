using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class fetchBrowse
    {
        mainController.CollectionGameController controller;
        int temp;
        // A Test behaves as an ordinary method
        [Test]
        public void fetchBrowseSimplePasses()
        {
            // Use the Assert class to test conditions
            temp = controller.actualGame(0);
            Assert.AreEqual(3, temp);
        }

    }
}
