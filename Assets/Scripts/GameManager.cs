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
    public Transform[] spawnPoint;
    public int winRound;

    public GameObject inGameCanvas;
    public Image hpUI;
    public Image[] cardsAmmo;

    public GameObject youWin;
    public GameObject gameover;
    public GameObject winLoseCanvas;
    public GameObject firstButtonWinLose;

    public Vector3 originePlayerPos;

    public GameObject pauseMenu;
    public GameObject firstButtonPause;
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
        {
            winRound++;
            if (winRound < 9)
                SetupLoseLevel();
            else
            {
                mobKill = 0;
                inGameCanvas.SetActive(false);
                youWin.SetActive(true);
                winLoseCanvas.SetActive(true);
                player.GetComponent<PControl>().DisableInputsPC();
                playerShoot.DisableInputs();
                EventSystem.current.SetSelectedGameObject(null);
                EventSystem.current.SetSelectedGameObject(firstButtonWinLose);
            }
        }
        

        if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            player = FindObjectOfType<PControl>().gameObject;
            playerShoot = FindObjectOfType<PlayerShoot>();
            HPUI();
            CardsUI();
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
        EventSystem.current.currentSelectedGameObject.GetComponent<ButtonSelection>().DeselectButton();
        returnButton.SetActive(true);
        mainMenu.SetActive(false);
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(returnButton);
    }

    public void Credit()
    {
        SceneManager.LoadScene(4);
        EventSystem.current.currentSelectedGameObject.GetComponent<ButtonSelection>().DeselectButton();
        returnButton.SetActive(true);
        mainMenu.SetActive(false);
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(returnButton);
    }

    public void ReturnMainMenu()
    {
        SceneManager.LoadScene(0);
        EventSystem.current.currentSelectedGameObject.GetComponent<ButtonSelection>().DeselectButton();
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
            EventSystem.current.currentSelectedGameObject.GetComponent<ButtonSelection>().DeselectButton();
            returnButton.SetActive(false);
            startButtonSelect.SetActive(false);
            inGameCanvas.SetActive(true);
            loseLevelCanvas.SetActive(true);
            loseLevelButton[0].GetComponent<Image>().sprite = cards[indexA];
            loseLevelButton[1].GetComponent<Image>().sprite = cards[indexB];
            loseLevelButton[2].GetComponent<Image>().sprite = cards[indexX];
            loseLevelButton[3].GetComponent<Image>().sprite = cards[indexY];
            EventSystem.current.SetSelectedGameObject(null);
            EventSystem.current.SetSelectedGameObject(loseLevelButton[0]);
            loseLevelCanvas.SetActive(false);
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
        mobKill = 0;
        player.transform.position = originePlayerPos;
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

        if (playerShoot.IniateLoseLevel(index, indexTimer) > -1)
        {
            loseLevelCanvas.SetActive(false);
            player.GetComponent<PControl>().EnableInputsPC();
            playerShoot.EnableInputs();
            for (int i = 0; i < 5; i++)
            {
                int randomEnemy = Random.Range(0, 2);
                GameObject pos = Instantiate(Enemy[randomEnemy], spawnPoint[i].position, spawnPoint[i].rotation);
            }
        }
        else return;
    }

    public void HPUI()
    {
        hpUI.fillAmount = player.GetComponent<PControl>().GetHp()/150;
    }

    public void CardsUI()
    {
        for (int i = 0; i < 4; i++)
        {
            cardsAmmo[i].fillAmount = playerShoot.GetAmmo(i)/playerShoot.GetAmmoMax(i);
        }
    }

    public void Pause()
    {
        inGameCanvas.SetActive(false);
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(firstButtonPause);
        pauseMenu.SetActive(true);
        player.GetComponent<PControl>().DisableInputsPC();
        playerShoot.DisableInputs();
        Time.timeScale = 0f;
    }

    public void UnPause()
    {
        EventSystem.current.currentSelectedGameObject.GetComponent<ButtonSelection>().DeselectButton();
        inGameCanvas.SetActive(true);
        pauseMenu.SetActive(false);
        player.GetComponent<PControl>().EnableInputsPC();
        playerShoot.EnableInputs();
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(loseLevelButton[0]);
        Time.timeScale = 1f;
    }

    public void PauseReset()
    {
        EventSystem.current.currentSelectedGameObject.GetComponent<ButtonSelection>().DeselectButton();
        pauseMenu.SetActive(false);
        winLoseCanvas.SetActive(false);
        returnButton.SetActive(true);
        startButtonSelect.SetActive(true);
        EventSystem.current.SetSelectedGameObject(null);
        SceneManager.LoadScene(1);
        mobKill = 0;
        winRound = 0;
        Time.timeScale = 1f;
    }

    public void MainMenuPause()
    {
        EventSystem.current.currentSelectedGameObject.GetComponent<ButtonSelection>().DeselectButton();
        pauseMenu.SetActive(false);
        winLoseCanvas.SetActive(false);
        mainMenu.SetActive(true);
        ResetIndexCard();
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(startButton);
        SceneManager.LoadScene(0);
        mobKill = 0;
        winRound = 0;
        Time.timeScale = 1f;
    }
}
