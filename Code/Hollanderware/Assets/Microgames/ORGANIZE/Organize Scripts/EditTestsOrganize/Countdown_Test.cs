using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class Countdown
    {
        public GameObject failText;
        public GameObject winText;

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

        [Test]
        public void NoTimeWinning()
        {
            winText = new GameObject();
            failText = new GameObject();
            winText.SetActive(true);
            failText.SetActive(false);
            int time = 0;
            Debug.Log(winText.activeSelf);
            if(time <= 0 && !winText.activeSelf)
            {
                failText.SetActive(true);
            }
        Assert.IsTrue(!failText.activeSelf);
        }

        [Test]
        public void OneSecondLosing()
        {
            winText = new GameObject();
            failText = new GameObject();
            winText.SetActive(false);
            failText.SetActive(false);
            int time = 1;
            Debug.Log(winText.activeSelf);
            if(time <= 0 && !winText.activeSelf)
            {
                failText.SetActive(true);
            }
        Assert.IsTrue(!failText.activeSelf);
        }

        [Test]
        public void OneSecondWinning()
        {
            winText = new GameObject();
            failText = new GameObject();
            winText.SetActive(true);
            failText.SetActive(false);
            int time = 1;
            Debug.Log(winText.activeSelf);
            if(time <= 0 && !winText.activeSelf)
            {
                failText.SetActive(true);
            }
        Assert.IsTrue(!failText.activeSelf);
        }
        
    }
}
