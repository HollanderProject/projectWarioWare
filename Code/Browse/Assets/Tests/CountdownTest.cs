using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class CountdownTest
    {
        GameObject failText;
        GameObject winText;

        [Test]
        public void NoTimeLosing()
        {
            winText = new GameObject();
            failText = new GameObject();

            winText.SetActive(false);
            failText.SetActive(false);

            int time = 0;
            Debug.Log(winText.activeSelf);
            if(time <= 0 && !winText.activeSelf)
            {
                failText.SetActive(true);
            }

            Assert.IsTrue(failText.activeSelf);
        }
    }
}
