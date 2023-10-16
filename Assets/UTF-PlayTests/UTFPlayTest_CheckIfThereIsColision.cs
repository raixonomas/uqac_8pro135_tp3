using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;

public class UTFPlayTest_CheckIfThereIsColision
{
    // A Test behaves as an ordinary method
    [Test]
    public void UTFPlayTest_CheckIfThereIsColisionSimplePasses()
    {
        // Use the Assert class to test conditions
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator UTFPlayTest_CheckIfThereIsColisionWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        SceneManager.LoadScene("Level_2");
        yield return new WaitForSeconds(1.0f);
        var ballScript = GameObject.Find("Sphere").GetComponent<Ball>();
        yield return new WaitForSeconds(2.0f);
        Assert.GreaterOrEqual(ballScript.numberOfBounce, 1);
        yield return null;
    }
}
