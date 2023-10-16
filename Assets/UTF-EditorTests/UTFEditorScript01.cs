using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class UTFEditorScript01
{
    [UnityTest]
    public IEnumerator Add_TwoPositiveNumbers_ReturnsCorrectResult()
    {
        Calculator calculator = new Calculator();
        int result = calculator.Add(5, 3);
        Assert.AreEqual(8, result);
        yield return null;
    }

    [UnityTest]
    public IEnumerator Subtract_TwoNumbers_ReturnsCorrectResult()
    {
        Calculator calculator = new Calculator();
        int result = calculator.Subtract(10, 3);
        Assert.AreEqual(7, result);
        yield return null;
    }

    [UnityTest]
    public IEnumerator Multiply_TwoNumbers_ReturnsCorrectResult()
    {
        Calculator calculator = new Calculator();
        int result = calculator.Multiply(5, 4);
        Assert.AreEqual(20, result);
        yield return null;
    }

    [UnityTest]
    public IEnumerator Divide_ValidInput_ReturnsCorrectResult()
    {
        Calculator calculator = new Calculator();
        float result = calculator.Division(20, 4);
        Assert.AreEqual(5, result);
        yield return null;
    }

    [UnityTest]
    public IEnumerator Add_TwoPositiveNumbers_ReturnsWrongResult()
    {
        Calculator calculator = new Calculator();
        int result = calculator.Add(5, 3);
        Assert.AreNotEqual(7, result);
        yield return null;
    }
}
