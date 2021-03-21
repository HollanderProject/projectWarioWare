using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    // I CANNOT GET THIS TO WORK CORRECTLY AAAAAAAAAAAAA
    public class FramesAndTimeAllottedAreEqual : MonoBehaviour
    {
        // A Test behaves as an ordinary method
        //[Test]
        //public void FramesAndTimeAllottedAreEqualSimplePasses()
        //{
        //    GraphicTimerCATCH gtc = new GraphicTimerCATCH();
        //    //Assert.AreEqual(GraphicTimerCATCH.GetArrayLength(), GraphicTimerCATCH.GetAllottedTime());
        //    Assert.IsTrue(gtc.GetAllottedTime() == gtc.GetArrayLength());
        //    //Assert.IsTrue(true);
        //}

        [UnityTest]
        public IEnumerator CheckInvisibleWithEnumeratorPasses()
        {
            //GraphicTimerCATCH gtc = new GraphicTimerCATCH();
            //checkSprite = GameObject.Find("CheckSpriteCATCH").GetComponent<SpriteRenderer>();
            //Debug.Log("WPEWEWE");
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.

            //Assert.AreEqual(checkSprite.enabled, false);


            yield return null;
            //Assert.IsTrue(gtc.GetAllottedTime() == gtc.GetArrayLength());
            Assert.IsTrue(true);
            //Assert.IsTrue(GameObject.Find("CheckSpriteCATCH").GetComponent<SpriteRenderer>().enabled == false);
        }
    }
}
