using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class fetchOrganize
    {
        mainController.CollectionGameController controller;
        int temp;
        // A Test behaves as an ordinary method
        [Test]
        public void fetchOrganizeSimplePasses()
        {
            // Use the Assert class to test conditions
            temp = controller.actualGame(6);
            Assert.AreEqual(9, temp);
        }

    }
}
