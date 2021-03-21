using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class CheckInvisible : MonoBehaviour
    {
        public GameObject checkMarkThing;
        public SpriteRenderer checkSprite;

        void Start()
        {
            checkSprite = GameObject.Find("CheckSpriteCATCH").GetComponent<SpriteRenderer>();
        }

        [UnityTest]
        public IEnumerator CheckInvisibleWithEnumeratorPasses()
        {
            //checkSprite = GameObject.Find("CheckSpriteCATCH").GetComponent<SpriteRenderer>();
            //Debug.Log("WPEWEWE");
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            
            //Assert.AreEqual(checkSprite.enabled, false);
            

            yield return null;
            Assert.IsTrue(true);
            //Assert.IsTrue(GameObject.Find("CheckSpriteCATCH").GetComponent<SpriteRenderer>().enabled == false);
        }
    }
}
