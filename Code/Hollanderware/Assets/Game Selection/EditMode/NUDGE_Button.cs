using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class NUDGE_Button
    {
        // A Test behaves as an ordinary method
        [Test]
        public void NUDGE_ButtonSimplePasses()
        {
            string scene = System.IO.Path.GetFileNameWithoutExtension(UnityEngine.SceneManagement.SceneUtility.GetScenePathByBuildIndex(PlayMicrogame.nudge));

            Assert.AreEqual("NUDGE Scene", scene);
        }
    }
}
