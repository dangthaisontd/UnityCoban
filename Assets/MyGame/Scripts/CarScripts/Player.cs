using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float maxHealth = 100;
    public float fuelValue = 20;
    public float damageValue = 50;
    public int roundValue = 1;
    public int coinValue = 1;
    public GameObject explusionPrefabs;
    private  float currentHealth = 0;
    private bool isGate = false;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Fuel")
        {
            Destroy(other.gameObject);
            GameManager.Instance.SetFuel(fuelValue);
            InstantiateGame(other);
        }
        else if (other.tag == "Damage")
        {
            DamageHealth(damageValue);
            InstantiateGame(other);
            Destroy(other.gameObject);
           
        }
        else if (other.tag == "FinishGame")
        {
            if (isGate == true)
            {
                GameManager.Instance.SetRound(roundValue);
                isGate = false;
            }
        }
        else if(other.tag=="Coin")
        {
            GameManager.Instance.SetCoin(coinValue);
            Destroy(other.gameObject);
        }
        if(other.name=="Gate")
        {
            isGate = true;
        }
    }
    void InstantiateGame(Collider other)
    {
        Instantiate(explusionPrefabs, other.transform.position, Quaternion.identity);
    }
    private void DamageHealth(float health)
    {
        /* if (currentHealth > 0)
          {
              currentHealth -= health;
          }
         if(currentHealth<=0)
          {
              currentHealth = 0;
              Destroy(gameObject);
          }
        */
        if (currentHealth > 0)
        {
            currentHealth -= health;
        }
        else
        {
            currentHealth = 0;
            Destroy(gameObject);
        }
    }
    private void Update()
    {
      // transform.position = new Vector3(Mathf.Clamp(transform.position.x, -60f, 60f), 0, Mathf.Clamp(transform.position.z, -60f, 60f));
    }
}
