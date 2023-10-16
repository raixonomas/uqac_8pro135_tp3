using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    public Calculator()
    {

    }
    // Square function
    public int Square(int num)
    {
        return num * num;
    }

    // Adds two integers and returns the sum
    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    // Multiplies two integers and returns the result
    public int Multiply(int num1, int num2)
    {
        return num1 * num2;
    }

    // Subtracts smaller number from the bigger number
    public int Subtract(int num1, int num2)
    {
        if (num1 > num2)
        {
            return num1 - num2;
        }

        return num2 - num1;
    }

    // Performs division on two float variables
    public float Division(float num1, float num2)
    {
        return num1 / num2;
    }
}
