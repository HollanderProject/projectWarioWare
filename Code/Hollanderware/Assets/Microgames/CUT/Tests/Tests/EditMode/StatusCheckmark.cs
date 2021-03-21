using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;

namespace Tests
{
    public class StatusIconTest
    {
        public GameObject checkmark;
        //public SpriteRenderer checkmarkSprite = GameObject.Find("CheckSprite").GetComponent<SpriteRenderer>();
        // A Test behaves as an ordinary method
        [Test]
        public void IconInitialStates()
        {
            var gameObject = new GameObject();
            var spriteRend = gameObject.AddComponent<SpriteRenderer>();

            Assert.IsFalse(spriteRend.isVisible);
        }
    }
}
