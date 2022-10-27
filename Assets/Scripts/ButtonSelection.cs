using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ButtonSelection : MonoBehaviour
{
    [SerializeField] Color colorText;
    [SerializeField] Text textField;
    [SerializeField] Image image;

    public void SelectButton()
    {
        //textField.color = colorText;
        image.enabled = true;
    }

    public void DeselectButton()
    {
        //textField.color = Color.white;
        image.enabled = false;
    }
}
