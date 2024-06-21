using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateController : MonoBehaviour
{
    public static GameStateController Instance { get; private set; }

    public bool leverOneOn = true;
    public bool leverTwoOn = true;
    public bool leverThreeOn = true;

    public bool buttonOneOn = true;
    public bool buttonTwoOn = true;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    private void Update()
    {

    }

    public bool IsMainLeverActive()
    {
        if (leverOneOn && leverTwoOn == false && leverThreeOn == false)
        {
            return true;
        }

        return false;
    }

    public bool IsButtonsCorrect()
    {
        if (buttonOneOn == false && buttonTwoOn)
        {
            return true;
        }

        return false;
    }
}
