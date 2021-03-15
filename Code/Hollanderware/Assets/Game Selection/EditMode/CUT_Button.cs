using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class CUT_Button
    {
        // A Test behaves as an ordinary method
        [Test]
        public void CUT_ButtonSimplePasses()
        {
            string scene = System.IO.Path.GetFileNameWithoutExtension(UnityEngine.SceneManagement.SceneUtility.GetScenePathByBuildIndex(PlayMicrogame.cut));

            Assert.AreEqual("CUT Scene", scene);
        }
    }
}
