using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;

public class UTFPlayTest_L
{
    // A Test behaves as an ordinary method
    [Test]
    public void UTFPlayTest_LSimplePasses()
    {
        // Use the Assert class to test conditions
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator UTFPlayTest_LWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        SceneManager.LoadScene("Level_1");
        yield return new WaitForSeconds(4.0f);
        Assert.AreEqual("Level_2", SceneManager.GetActiveScene().name);
        yield return null;
    }
}
