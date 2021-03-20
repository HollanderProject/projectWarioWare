using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class HERD_Button
    {
        // A Test behaves as an ordinary method
        [Test]
        public void HERD_ButtonSimplePasses()
        {
            string scene = System.IO.Path.GetFileNameWithoutExtension(UnityEngine.SceneManagement.SceneUtility.GetScenePathByBuildIndex(PlayMicrogame.herd));

            Assert.AreEqual("HERD Scene", scene);
        }
    }
}
