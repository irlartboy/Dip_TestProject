using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;

public class SimpleTests
{
    [Test]
    public void NUnitTest()
    {
        Assert.IsTrue(true, "NUnit Test Failed");
    }

    [Test]
    public IEnumerator SimpleUnityTestTools()
    {
        yield return new WaitForFixedUpdate();
        Assert.IsTrue(true, "Unity Test Failed");
    }
}
