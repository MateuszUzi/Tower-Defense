using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

    public static int Money = 400;
    public int startMoney = 400;

    void Start()
    {
        Money = startMoney;
    }

}
