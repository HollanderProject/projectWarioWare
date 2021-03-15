using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class AnimalHerdedTests
    {
        [Test]
        public void SheepHerdedTest()
        {
            var gameObject = new GameObject();
            var sheep = gameObject.AddComponent<SheepMove>();
            sheep.rb = gameObject.AddComponent<Rigidbody2D>();
            // Set SheepisHerded to false
            SheepMove.SheepisHerded = false;

            // Call the stop sheep method, which triggers on collision with the inside fence.
            // This should set SheepisHerded to true
            sheep.StopSheep();
            Assert.IsTrue(SheepMove.SheepisHerded);

            // Setting value back to default value for other tests, since it is static
            SheepMove.SheepisHerded = false;
        }

        [Test]
        public void PigHerdedTest()
        {
            var gameObject = new GameObject();
            var pig = gameObject.AddComponent<PigMove>();
            pig.rb = gameObject.AddComponent<Rigidbody2D>();
            // Set PigisHerded to false
            PigMove.PigisHerded = false;

            // Call the StopPig() method, which triggers on collision with the inside fence.
            // This should set PigisHerded to true
            pig.StopPig();
            Assert.IsTrue(PigMove.PigisHerded);

            // Setting value back to false for other tests, since it is static
            PigMove.PigisHerded = false;
        }

        [Test]
        public void CowHerdedTest()
        {
            var gameObject = new GameObject();
            var cow = gameObject.AddComponent<CowMove>();
            cow.rb = gameObject.AddComponent<Rigidbody2D>();
            // Set CowisHerded to false
            CowMove.CowisHerded = false;

            // Call the StopCow() method, which triggers on collision with the inside fence.
            // This should set CowisHerded to true
            cow.StopCow();
            Assert.IsTrue(CowMove.CowisHerded);

            // Setting value back to false for other tests, since it is static
            CowMove.CowisHerded = false;
        }

    }
}
