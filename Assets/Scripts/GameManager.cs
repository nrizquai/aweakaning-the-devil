using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class GameManager : MonoBehaviour
{
    public static GameManager instance ;

    public GameObject mainMenu;
    public GameObject returnButton;
    public GameObject startButton;
    public GameObject startButtonSelect;
    public GameObject eventSystem;

    public int indexA = -1;
    public int indexB = -1;
    public int indexX = -1;
    public int indexY = -1;
    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
            Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        mainMenu.SetActive(false);
        returnButton.SetActive(true);
        startButtonSelect.SetActive(true);
        EventSystem.current.SetSelectedGameObject(null);
        SceneManager.LoadScene(1);
    }

    public void Tutorial()
    {
        SceneManager.LoadScene(3);
        returnButton.SetActive(true);
        mainMenu.SetActive(false);
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(returnButton);
    }

    public void Credit()
    {
        SceneManager.LoadScene(4);
        returnButton.SetActive(true);
        mainMenu.SetActive(false);
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(returnButton);
    }

    public void ReturnMainMenu()
    {
        SceneManager.LoadScene(0);
        returnButton.SetActive(false);
        startButtonSelect.SetActive(false);
        mainMenu.SetActive(true);
        eventSystem.SetActive(true);
        ResetIndexCard();
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(startButton);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void ActivateUI()
    {
        EventSystem.current.SetSelectedGameObject(returnButton);
    }
    public void DesactivateUI()
    {
        EventSystem.current.SetSelectedGameObject(null);
    }

    public void MainGameSwitch()
    {
        if(indexA > -1 && indexB > -1 && indexX > -1 && indexY > -1)
        {
            SceneManager.LoadScene(2);
            returnButton.SetActive(false);
            startButtonSelect.SetActive(false);
        }
    }

    public void ResetIndexCard()
    {
        indexA = -1;
        indexB = -1;
        indexX = -1;
        indexY = -1;
    }
}
