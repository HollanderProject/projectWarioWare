using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class ChangeChannelTest
    {

        [Test]
        public void TVInitalized()
        {
            var gameObject = new GameObject();
            var TV = gameObject.AddComponent<ChangeChannel>();

            Assert.IsTrue(TV.currentChannel == 0f);
            Assert.IsTrue(TV.minStayOnChannel == 2f);
        }

        public void RandomizeRangeCheck()
        {
            var gameObject = new GameObject();
            var TV = gameObject.AddComponent<ChangeChannel>();

            TV.RandomizeWinChannel();

            Assert.IsTrue(TV.winChannel >= 5 || TV.winChannel <= 8);

        }
    }
}
