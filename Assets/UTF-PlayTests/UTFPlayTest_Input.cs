using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;

public class UTFPlayTest_Input : InputTestFixture
{
    private Keyboard keyboard;
    private GameObject ball;

    [SetUp]
    public override void Setup()
    {
        base.Setup();
        

        keyboard = InputSystem.AddDevice<Keyboard>();
    }

    [UnityTest]
    public IEnumerator UTFPlayTest_InputWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        SceneManager.LoadScene("Level_3");
        yield return new WaitForSeconds(1.0f);
        ball = GameObject.Find("Sphere");
        Vector3 position = ball.transform.position;
        Press(keyboard.upArrowKey);
        yield return new WaitForSeconds(1.0f);
        Assert.AreNotEqual(position, ball.transform.position);
        yield return null;
    }
}
