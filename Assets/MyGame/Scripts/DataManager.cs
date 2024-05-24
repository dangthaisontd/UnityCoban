using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static int DataCoin
        {
        get => PlayerPrefs.GetInt(DataContainer.CoinId, 0);
        set=>PlayerPrefs.SetInt(DataContainer.CoinId,value);
        }
}
