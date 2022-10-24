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

    public int mobKill;

    public Sprite[] cards;
    public GameObject[] loseLevelButton;
    public GameObject loseLevelCanvas;

    GameObject player;
    PlayerShoot playerShoot;

    public GameObject[] Enemy;
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

    void Update()
    {
        if (mobKill == 5)
            SetupLoseLevel();

        if(SceneManager.GetActiveScene().buildIndex == 2)
        {
            player = FindObjectOfType<PControl>().gameObject;
            playerShoot = FindObjectOfType<PlayerShoot>();
        }
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

    public void SetupLoseLevel()
    {
        loseLevelCanvas.SetActive(true);
        player.GetComponent<PControl>().DisableInputsPC();
        playerShoot.DisableInputs();
        loseLevelButton[0].GetComponent<Image>().sprite = cards[indexA];
        loseLevelButton[1].GetComponent<Image>().sprite = cards[indexB];
        loseLevelButton[2].GetComponent<Image>().sprite = cards[indexX];
        loseLevelButton[3].GetComponent<Image>().sprite = cards[indexY];
        mobKill = 0;
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(loseLevelButton[0]);
    }

    public void GetLoseLevel(int indexTimer)
    {
        int index = -1;
        switch (indexTimer)
        {
            case 0 :
                index = indexA;
                break;
            case 1:
                index = indexB;
                break;
            case 2:
                index = indexX;
                break;
            case 3:
                index = indexY;
                break;
        }

        //playerShoot.IniateLoseLevel(index, indexTimer);
        if (playerShoot.IniateLoseLevel(index, indexTimer) > -1)
        {
            loseLevelCanvas.SetActive(false);
            player.GetComponent<PControl>().EnableInputsPC();
            playerShoot.EnableInputs();
            Vector3 position = new Vector3(Random.Range(-8.3f, 8.3f), Random.Range(-4.2f, 4.2f), 0);
            Instantiate(Enemy[0], position, transform.rotation);
            Instantiate(Enemy[0], position, transform.rotation);
            Instantiate(Enemy[0], position, transform.rotation);
            Instantiate(Enemy[1], position, transform.rotation);
            Instantiate(Enemy[1], position, transform.rotation);
        }
        else return;
    }
}
