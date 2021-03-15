﻿using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class CLIMB_Button
    {
        // A Test behaves as an ordinary method
        [Test]
        public void CLIMB_ButtonSimplePasses()
        {
            string scene = System.IO.Path.GetFileNameWithoutExtension(UnityEngine.SceneManagement.SceneUtility.GetScenePathByBuildIndex(PlayMicrogame.climb));

            Assert.AreEqual("CLIMB Scene", scene);
        }
    }
}
