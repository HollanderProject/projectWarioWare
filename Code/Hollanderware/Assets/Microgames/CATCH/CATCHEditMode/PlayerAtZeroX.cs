using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class PlayerAtZeroX : MonoBehaviour
    {
        // A Test behaves as an ordinary method
        [Test]
        public void PlayerAtZeroXSimplePasses()
        {
            Assert.IsTrue(MouseMovement.mousePosition.x == 0);
        }
    }
}
