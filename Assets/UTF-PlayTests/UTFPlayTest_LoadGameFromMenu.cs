using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;

public class UTFPlayTest_LoadGameFromMenu
{
    // A Test behaves as an ordinary method
    [Test]
    public void UTFPlayTest_LoadGameFromMenuSimplePasses()
    {
        // Use the Assert class to test conditions
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator UTFPlayTest_LoadGameFromMenuWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        SceneManager.LoadScene("Menu");
        yield return new WaitForSeconds(1.0f);
        var uiScript = GameObject.Find("UI").GetComponent<ButtonBehavior>();
        uiScript.btnPlay_Click();
        yield return new WaitForSeconds(1.0f);
        Assert.AreEqual("Level_1", SceneManager.GetActiveScene().name);
        yield return null;
    }
}
