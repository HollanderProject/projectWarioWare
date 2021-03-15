using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class LifeCounter_Test : MonoBehaviour
{

    [Test]
    public void LifeLost()
    {
        bool failTextActive = true;
        bool failed = false;

        if(failTextActive && !failed)
        {
            failed = true;
        }
        Assert.IsTrue(failed);
    }

    [Test]
    public void LifeAlreadyLost()
    {
        bool failTextActive = true;
        bool failed = true;

        if(failTextActive && !failed)
        {
            failed = false;
        }
        Assert.IsTrue(failed);
    }

    [Test]
    public void LifeNotLost()
    {
        bool failTextActive = false;
        bool failed = false;

        if(failTextActive && !failed)
        {
            failed = true;
        }
        Assert.IsTrue(!failed);
    }
}
