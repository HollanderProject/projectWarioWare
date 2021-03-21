using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class StatusIconTests
    {
        // A Test behaves as an ordinary method
        [Test]
        public void IconInitialStates()
        {
            // Use the Assert class to test conditions
            var gameObject = new GameObject();
            var spriteRend = gameObject.AddComponent<SpriteRenderer>();

            Assert.IsFalse(spriteRend.isVisible);
        }
    }
}
