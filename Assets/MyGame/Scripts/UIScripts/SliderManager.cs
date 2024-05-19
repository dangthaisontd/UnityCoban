using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Slider mySlider;
    void Start()
    {
        //mySlider = GetComponent<Slider>();
        Debug.Log(mySlider.minValue);
        Debug.Log(mySlider.maxValue);
        mySlider.value = 5;
    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log(mySlider.value);
    }
    public void OnValueChangeSlider()
    {
        Debug.Log("Da co su thay doi");
    }
}
