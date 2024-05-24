using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    //Public
    #region Singleton
    public static GameManager Instance
    {
        get => instance;
    }
    private static GameManager instance;
    #endregion
    //private
    #region Variable
    public UnityEvent<int> CoinEvent;
    public UnityEvent<int> RoundEvent;
    public UnityEvent<float> FuelEvent;
    private float fuel = 0;
    private int roundNumber = 0;
    private  int  coinNumber = 0;

    
    #endregion
    // Start is called before the first frame update
    private void Awake()
    {
        if(instance != null)
        {
            DestroyImmediate(instance);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        
        if(CoinEvent==null)
        {
            CoinEvent = new UnityEvent<int>();
        }
        if(RoundEvent==null)
        {
            RoundEvent = new UnityEvent<int>(); 
        }
        if (FuelEvent==null)
        {
            FuelEvent = new UnityEvent<float>();
        }
        coinNumber = DataManager.DataCoin;
    }
    public void SetFuel(float fuel)
    {
        this.fuel += fuel;
        FuelEvent?.Invoke(this.fuel);
    }
    public void SetRound(int roundNumber)
    {
        this.roundNumber += roundNumber;
        RoundEvent?.Invoke(this.roundNumber);
        
    }
    public void SetCoin(int coinNumber)
    {
        this.coinNumber += coinNumber;
        CoinEvent?.Invoke(this.coinNumber);
        DataManager.DataCoin = this.coinNumber;
    }
}
