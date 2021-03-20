using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class CATCH_Button
    {
        // A Test behaves as an ordinary method
        [Test]
        public void CATCH_ButtonSimplePasses()
        {
            string scene = System.IO.Path.GetFileNameWithoutExtension(UnityEngine.SceneManagement.SceneUtility.GetScenePathByBuildIndex(PlayMicrogame.catchGame));

            Assert.AreEqual("CATCH Scene", scene);
        }
    }
}
