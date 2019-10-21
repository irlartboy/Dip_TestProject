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
        Assert.IsTrue(false, "NUnit Test Failed");
   }
    public IEnumerator SimpleUnityTestTools()
    {
        yield return new WaitForFixedUpdate();
        Assert.IsTrue(false, "Unity Test Failed")
    }
}
