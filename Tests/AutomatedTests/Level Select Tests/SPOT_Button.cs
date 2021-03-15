using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class SPOT_Button
    {
        // A Test behaves as an ordinary method
        [Test]
        public void SPOT_ButtonSimplePasses()
        {
            string scene = System.IO.Path.GetFileNameWithoutExtension(UnityEngine.SceneManagement.SceneUtility.GetScenePathByBuildIndex(PlayMicrogame.spot));

            Assert.AreEqual("SPOT Scene (Placeholder)", scene);
        }
    }
}
