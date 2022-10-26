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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SelectButton()
    {
        textField.color = colorText;
        image.enabled = true;
    }

    public void DeselectButton()
    {
        textField.color = Color.white;
        image.enabled = false;
    }
}
