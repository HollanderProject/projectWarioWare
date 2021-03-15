using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class AnimalInitialStateTests
    {
        // Test that the "sheep" is not herded on startup
        [Test]
        public void SheepActive()
        {
            Assert.IsFalse(SheepMove.SheepisHerded);
        }
        // Test that the "pig" is not herded on startup
        [Test]
        public void PigActive()
        {
            Assert.IsFalse(PigMove.PigisHerded);
        }
        // Test that the "cow" is not herded on startup
        [Test]
        public void CowActive()
        {
            Assert.IsFalse(CowMove.CowisHerded);
        }
    }
}
