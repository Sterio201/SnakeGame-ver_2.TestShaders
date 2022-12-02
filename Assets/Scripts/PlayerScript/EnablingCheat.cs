using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnablingCheat : MonoBehaviour
{
    [SerializeField] Dropdown dropdown;

    public void EnableInv()
    {
        CheatScriptPlayer.inv = !CheatScriptPlayer.inv;
        Debug.Log(CheatScriptPlayer.inv);
    }

    public void EnableSpeed()
    {
        switch (dropdown.value)
        {
            case 0:
                CheatScriptPlayer.speed = speed.no;
                break;
            case 1:
                CheatScriptPlayer.speed = speed.high;
                break;
            case 2:
                CheatScriptPlayer.speed = speed.low;
                break;
        }
    }
}