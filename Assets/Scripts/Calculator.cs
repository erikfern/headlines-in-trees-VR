using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator : MonoBehaviour
{

    public static int indigenous;
    public static int environment;
    public static int economic;
    public static int depth;
    public static int balance;

    // Start is called before the first frame update
    void Start()
    {
        indigenous = 0;
        environment = 0;
        economic = 0;
        depth = 0;
        balance = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CalculateI(int value)
    {
        if (shareButton.counter <= 1 )
        {
            indigenous = indigenous + value;
            Debug.Log(indigenous);
        } else
        {
            indigenous = ((indigenous + value) / 200) * 100;
            Debug.Log(indigenous);
        }
    }

    void CalculateEn(int value)
    {
        if (shareButton.counter <= 1)
        {
            environment = environment + value;
        }
        else
        {
            environment = ((environment + value) / 200) * 100;
        }
    }

    void CalculateEc(int value)
    {
        if (shareButton.counter <= 1)
        {
            economic = economic + value;
        }
        else
        {
            economic = ((economic + value) / 200) * 100;
        }
    }

    void CalculateD(int value)
    {
        if (shareButton.counter <= 1)
        {
            depth = depth + value;
        }
        else
        {
            depth = ((depth + value) / 200) * 100;
        }
    }

    void CalculateB(int value)
    {
        if (shareButton.counter <= 1)
        {
            balance = balance + value;
        }
        else
        {
            balance = ((balance + value) / 200) * 100;
        }
    }
}
