using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;

public class UTFPlayTest01
{
    // A Test behaves as an ordinary method
    [Test]
    public void UTFPlayTest01SimplePasses()
    {
        // Use the Assert class to test conditions
        var a = 1;
        var b = 2;
        var c = 3;

        var result = a + b;
        Assert.AreEqual(c, result);
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator UTFPlayTest01WithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        SceneManager.LoadScene("Victory");
        yield return new WaitForSeconds(1.0f);
        var uiScript = GameObject.Find("Canvas").GetComponent<VictoryCooseLevel>();
        uiScript.LoadMainMenu();
        yield return new WaitForSeconds(1.0f);
        Assert.AreEqual("Menu", SceneManager.GetActiveScene().name);
        yield return null;
    }
}
