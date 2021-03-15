using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class AnimalUpdateTests
    {
        // A Test behaves as an ordinary method
        [Test]
        public void SheepUpdateTest()
        {
            var gameObject = new GameObject();
            var sheep = gameObject.AddComponent<SheepMove>();
            sheep.rb = gameObject.AddComponent<Rigidbody2D>();
            sheep.SheepBaaAudio = gameObject.AddComponent<AudioSource>();


            // Initialize the Sheep's turnFlag and rb simulation to false
            sheep.turnFlag = false;
            sheep.rb.simulated = false;

            // Call UpdateSheep() method
            sheep.UpdateSheep();

            // Assert that there is an audio clip to play upon update, the turn flag is changed to true,
            // and the rigidbody is turned on so the animal can move
            Assert.IsNotNull(sheep.SheepBaaAudio);
            Assert.IsTrue(sheep.turnFlag);
            Assert.IsTrue(sheep.rb.simulated);
        }

        [Test]
        public void PigUpdateTest()
        {
            var gameObject = new GameObject();
            var pig = gameObject.AddComponent<PigMove>();
            pig.rb = gameObject.AddComponent<Rigidbody2D>();
            pig.PigOinkAudio = gameObject.AddComponent<AudioSource>();

            // Initialize the Pig's turnFlag and rb simulation to false
            pig.turnFlag = false;
            pig.rb.simulated = false;

            // Call UpdatePig() method
            pig.UpdatePig();

            // Assert that there is an audio clip to play upon update, the turn flag is changed to true,
            // and the rigidbody is turned on so the animal can move
            Assert.IsNotNull(pig.PigOinkAudio);
            Assert.IsTrue(pig.turnFlag);
            Assert.IsTrue(pig.rb.simulated);
        }

        [Test]
        public void CowUpdateTest()
        {
            var gameObject = new GameObject();
            var cow = gameObject.AddComponent<CowMove>();
            cow.rb = gameObject.AddComponent<Rigidbody2D>();
            cow.CowMooAudio = gameObject.AddComponent<AudioSource>();

            // Initialize the Cow's turnFlag and rb simulation to false
            cow.turnFlag = false;
            cow.rb.simulated = false;

            // Call UpdateCow() method
            cow.UpdateCow();

            // Assert that there is an audio clip to play upon update, the turn flag is changed to true,
            // and the rigidbody is turned on so the animal can move
            Assert.IsNotNull(cow.CowMooAudio);
            Assert.IsTrue(cow.turnFlag);
            Assert.IsTrue(cow.rb.simulated);
        }
    }
}
