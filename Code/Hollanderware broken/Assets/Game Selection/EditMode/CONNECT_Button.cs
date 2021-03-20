using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class CONNECT_Button
    {
        // A Test behaves as an ordinary method
        [Test]
        public void CONNECT_ButtonSimplePasses()
        {
            string scene = System.IO.Path.GetFileNameWithoutExtension(UnityEngine.SceneManagement.SceneUtility.GetScenePathByBuildIndex(PlayMicrogame.connect));

            Assert.AreEqual("CONNECT Scene", scene);
        }
    }
}
