using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class SHOOT_Button
    {
        // A Test behaves as an ordinary method
        [Test]
        public void SHOOT_ButtonSimplePasses()
        {
            string scene = System.IO.Path.GetFileNameWithoutExtension(UnityEngine.SceneManagement.SceneUtility.GetScenePathByBuildIndex(PlayMicrogame.shoot));

            Assert.AreEqual("SHOOT Scene", scene);
        }
    }
}
