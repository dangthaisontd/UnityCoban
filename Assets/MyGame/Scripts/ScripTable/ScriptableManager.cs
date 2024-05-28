using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScriptableManager : MonoBehaviour
{
    public Sword[] dataSwords;
    [SerializeField] private Image image;
    [SerializeField] private TextMeshProUGUI id;
    [SerializeField] private TextMeshProUGUI name;
    private void Start()
    {
        OnClickButton();
    }
    public void OnClickButton()
    {  
        Sword sword;
        sword = dataSwords[Random.Range(0,dataSwords.Length)];
        image.sprite = sword.icon;
        id.text = sword.id.ToString();
        name.text = sword.name.ToString();
    }
}
