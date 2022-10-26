using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SelectCard : MonoBehaviour
{
    private PlayerController inputs;
    [SerializeField] int x = 0;
    [SerializeField]int y = 0;

    float timer = 0;
    float timerMax = 0.3f;
    bool onSelect = true;

    public GameObject[] cardSlot;
    public GameObject[] firstLine;
    public GameObject[] secondLine;

    public GameObject[] buttonSelected;

    int lastAPress = -1;
    int lastBPress = -1;
    int lastXPress = -1;
    int lastYPress = -1;
    private void Awake()
    {
        inputs = new PlayerController();
        cardSlot = firstLine;
    }
    private void OnEnable()
    {
        inputs.Enable();
    }

    private void OnDisable()
    {
        inputs.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            if (onSelect)
                MoveLeft();

            MoveUp();
        }

        if (onSelect)
        {
            inputs.UI.A.started += ctx =>
            {
                if (y == 0)
                {
                    if (x != lastAPress)
                        CardA(x);
                }
                else if (y == -1)
                {
                    if (x + 2 != lastAPress)
                    {
                        CardA(x + 2);
                    }
                }
            };

            inputs.UI.B.started += ctx =>
            {
                if (y == 0)
                {
                    if (x != lastBPress)
                        CardB(x);
                }
                else if (y == -1)
                {
                    if (x + 2 != lastBPress)
                    {
                        CardB(x + 2);
                    }
                }
            };

            inputs.UI.X.started += ctx =>
            {
                if (y == 0)
                {
                    if (x != lastXPress)
                        CardX(x);
                }
                else if (y == -1)
                {
                    if (x + 2 != lastXPress)
                    {
                        CardX(x + 2);
                    }
                }
            };

            inputs.UI.Y.started += ctx =>
            {
                if (y == 0)
                {
                    if (x != lastYPress)
                        CardY(x);
                }
                else if (y == -1)
                {
                    if (x + 2 != lastYPress)
                    {
                        CardY(x + 2);
                    }
                }
            };
        }
    }

    public void MoveLeft()
    {
        if (inputs.UI.NavigateH.ReadValue<float>() > 0.5f)
            if (x < 1)
            {
                x++;
                gameObject.transform.position = cardSlot[x].transform.position;
                timer = timerMax;
            }
        if (inputs.UI.NavigateH.ReadValue<float>() < -0.5f)
            if (x > 0)
            {
                x--;
                gameObject.transform.position = cardSlot[x].transform.position;
                timer = timerMax;
            }
    }

    public void MoveUp()
    {
        if (inputs.UI.NavigateV.ReadValue<float>() > 0.5f)
        {
            if (y < 0 && y == -1)
            {
                y++;
                cardSlot = firstLine;
                gameObject.transform.position = cardSlot[x].transform.position;
                timer = timerMax;
            }

            if (y < -1)
            {
                y++;
                GameManager.instance.DesactivateUI();
                onSelect = true;
                timer = timerMax;
            }
        }
            
        if (inputs.UI.NavigateV.ReadValue<float>() < -0.5f)
        {
            if (y == -1 && y > -2)
            {
                y--;
                GameManager.instance.ActivateUI();
                onSelect = false;
                timer = timerMax;
            }

            if (y > -1)
            {
                y--;
                cardSlot = secondLine;
                gameObject.transform.position = cardSlot[x].transform.position;
                timer = timerMax;
            }
        }
    }

    public void CardA(int index)
    {
        GameManager.instance.indexA = index;
        GameObject oldPos = GameObject.FindGameObjectWithTag("A");
        Destroy(oldPos);
        if (index == lastBPress)
        {
            oldPos = GameObject.FindGameObjectWithTag("B");
            Destroy(oldPos);
            GameManager.instance.indexB = -1;
            lastBPress = -1;
        }
        if (index == lastXPress)
        {
            oldPos = GameObject.FindGameObjectWithTag("X");
            Destroy(oldPos);
            GameManager.instance.indexX = -1;
            lastXPress = -1;
        }
        if (index == lastYPress)
        {
            oldPos = GameObject.FindGameObjectWithTag("Y");
            Destroy(oldPos);
            GameManager.instance.indexY = -1;
            lastYPress = -1;
        }
        Instantiate(buttonSelected[0], transform.position, transform.rotation);
        lastAPress = index;
    }
    public void CardB(int index)
    {
        GameManager.instance.indexB = index;
        GameObject oldPos = GameObject.FindGameObjectWithTag("B");
        Destroy(oldPos);
        if (index == lastAPress)
        {
            oldPos = GameObject.FindGameObjectWithTag("A");
            Destroy(oldPos);
            GameManager.instance.indexA = -1;
            lastAPress = -1;
        }
        if (index == lastXPress)
        {
            oldPos = GameObject.FindGameObjectWithTag("X");
            Destroy(oldPos);
            GameManager.instance.indexX = -1;
            lastXPress = -1;
        }
        if (index == lastYPress)
        {
            oldPos = GameObject.FindGameObjectWithTag("Y");
            Destroy(oldPos);
            GameManager.instance.indexY = -1;
            lastYPress = -1;
        }
        Instantiate(buttonSelected[1], transform.position, transform.rotation);
        lastBPress = index;
    }
    public void CardX(int index)
    {
        GameManager.instance.indexX = index;
        GameObject oldPos = GameObject.FindGameObjectWithTag("X");
        Destroy(oldPos);
        if (index == lastAPress)
        {
            oldPos = GameObject.FindGameObjectWithTag("A");
            Destroy(oldPos);
            GameManager.instance.indexA = -1;
            lastAPress = -1;
        }
        if (index == lastBPress)
        {
            oldPos = GameObject.FindGameObjectWithTag("B");
            Destroy(oldPos);
            GameManager.instance.indexB = -1;
            lastBPress = -1;
        }
        if (index == lastYPress)
        {
            oldPos = GameObject.FindGameObjectWithTag("Y");
            Destroy(oldPos);
            GameManager.instance.indexY = -1;
            lastYPress = -1;
        }
        Instantiate(buttonSelected[2], transform.position, transform.rotation);
        lastXPress = index;
    }
    public void CardY(int index)
    {
        GameManager.instance.indexY = index;
        GameObject oldPos = GameObject.FindGameObjectWithTag("Y");
        Destroy(oldPos);
        if (index == lastAPress)
        {
            oldPos = GameObject.FindGameObjectWithTag("A");
            Destroy(oldPos);
            GameManager.instance.indexA = -1;
            lastAPress = -1;
        }
        if (index == lastXPress)
        {
            oldPos = GameObject.FindGameObjectWithTag("X");
            Destroy(oldPos);
            GameManager.instance.indexX = -1;
            lastXPress = -1;
        }
        if (index == lastBPress)
        {
            oldPos = GameObject.FindGameObjectWithTag("B");
            Destroy(oldPos);
            GameManager.instance.indexB = -1;
            lastBPress = -1;
        }
        Instantiate(buttonSelected[3], transform.position, transform.rotation);
        lastYPress = index;
    }
}
