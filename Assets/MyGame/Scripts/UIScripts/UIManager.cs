using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI textCoin;
    [SerializeField]private TextMeshProUGUI textRound;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(UpdateValue());
    }
    // Update is called once per frame
    void Update()
    {
       // UpdateCoin();
       // UpdateRound();
    }
    void UpdateCoin()
    {
        int coin = GameManager.Instance.GetCoin();
        textCoin.text = coin.ToString();
    }
    void UpdateRound()
    {
        int round= GameManager.Instance.GetRound();
        textRound.text = round.ToString();
    }
    IEnumerator UpdateValue()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.5f);
            UpdateCoin();
            UpdateRound();
       }
    }
}
