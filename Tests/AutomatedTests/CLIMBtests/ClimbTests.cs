using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class ClimbTests : MonoBehaviour
{
    [Test]
    public void ClimbSuccess()
    {
        int hitBox = 1;
        int other = 1;
        bool win = false;
        bool fail = false;
        if(other == hitBox)
        {
            win = true;
        }
        Assert.IsTrue(win && !fail);
    }

    [Test]
    public void ClimbNeutral()
    {
        int hitBox = 2;
        int other = 1;
        bool win = false;
        bool fail = false;
        if(other == hitBox)
        {
            win = false;
            fail = false;
        }
        Assert.IsTrue(!win && !fail);
    }
    [Test]
    public void ClimbFail()
    {
        int hitBox = 2;
        int other = 2;
        bool win = false;
        bool fail = false;
        if(other == hitBox)
        {
            fail = true;
        }
        Assert.IsTrue(!win && fail);
    }
}
