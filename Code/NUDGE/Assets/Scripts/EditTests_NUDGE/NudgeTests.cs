using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class NudgeTests : MonoBehaviour
{
    [Test]
    public void NudgeSuccess()
    {
        int glassBox = 1;
        int other = 1;
        int nudgeCount = 0;
        if(other == glassBox)
        {
            nudgeCount++;
        }
        Assert.IsTrue(nudgeCount == 1);
    }

    [Test]
    public void NudgeFail()
    {
        int glassBox = 1;
        int other = 2;
        int nudgeCount = 0;
        if(other == glassBox)
        {
            nudgeCount++;
        }
        Assert.IsTrue(nudgeCount == 0);
    }

    [Test]
    public void GlassFall()
    {
        int glassBox = 1;
        int other = 1;
        int nudgeCount = 3;
        bool win = false;
        if(other == glassBox)
        {
            nudgeCount++;
        }
        if(nudgeCount >= 4)
        {
            win = true;
        }
        Assert.IsTrue(win);
    }
}
