using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class RandomOrderTest
    {
        // Test that the RNG correctly picks a value in the range of 0 - 2
        [Test]
        public void RandomAnimalGenerator()
        {
            var gameObject = new GameObject();
            var random = gameObject.AddComponent<RandomAnimal>();

            // Call the function that randomizes the order of the animals
            random.RandomizeAnimals();
            // Assert that the randomize function returns a value between 0 and 2.
            Debug.Log(RandomAnimal.num);
            Assert.IsTrue(RandomAnimal.num == 0 || RandomAnimal.num == 1 || RandomAnimal.num == 2);
        }

        // Test that the number from the RNG correctly sets the starting variables of the game
        [Test]
        public void RandomAnimalInitialization()
        {
            var gameObject = new GameObject();
            var random = gameObject.AddComponent<RandomAnimal>();
            random.RandomizeAnimals();
            Debug.Log(RandomAnimal.num);

            // If the RNG picks sheep, Assert that the sheep is on and the pig/cow are off
            if (RandomAnimal.num == 0)
            {
                Debug.Log("Sheep picked from RNG.");
                Assert.IsTrue(RandomAnimal.sheepTurn);
            }

            // If the RNG picks pig, Assert that the pig is on and the sheep/cow are off
            else if (RandomAnimal.num == 1)
            {
                Debug.Log("Pig picked from RNG.");
                Assert.IsTrue(RandomAnimal.pigTurn);
            }

            // If the RNG picks cow, Assert that the cow is on and the sheep/pig are off
            else if (RandomAnimal.num == 2)
            {
                Debug.Log("Cow picked from RNG.");
                Assert.IsTrue(RandomAnimal.cowTurn);
            }
        }
    }
}
