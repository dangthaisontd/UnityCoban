using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public float fuel = 0;
    public int roundNumber = 0;
    public int  coinNumber = 0;
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
    }
    public void SetFuel(float fuel)
    {
        this.fuel += fuel;
    }
    public void SetRound(int roundNumber)
    {
        this.roundNumber += roundNumber;
    }
    public void SetCoin(int coinNumber)
    {
        this.coinNumber += coinNumber;
    }
    public int GetCoin()
    {
        return coinNumber;
    }
    public int GetRound()
    {
        return roundNumber;
    }
}
