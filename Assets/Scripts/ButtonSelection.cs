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
        AudioManager.instance.sfxSource[3].PlayOneShot(AudioManager.instance.sfx[7], 0.1f);
    }

    public void DeselectButton()
    {
        //textField.color = Color.white;
        image.enabled = false;
    }

    public void OnClick()
    {
        AudioManager.instance.sfxSource[3].PlayOneShot(AudioManager.instance.sfx[8], 0.1f);
    }

    public void Navigate()
    {
        AudioManager.instance.sfxSource[3].PlayOneShot(AudioManager.instance.sfx[7], 0.1f);
    }

}
