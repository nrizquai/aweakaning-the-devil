using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    [SerializeField] Color colorText;
    [SerializeField] Color colorTextOrigin;
    [SerializeField] Color colorImage;
    [SerializeField] Text textField;
    [SerializeField] Image button;

    void Start()
    {
        colorTextOrigin = textField.color;
    }


    void Update()
    {
        if(GameManager.instance.indexA != -1 && GameManager.instance.indexB != -1 && GameManager.instance.indexX != -1 && GameManager.instance.indexY != -1)
        {
            textField.color = colorText;
            button.color = Color.white;
        }
        else
        {
            button.color = colorImage;
            textField.color = colorTextOrigin;
        }
    }
}
