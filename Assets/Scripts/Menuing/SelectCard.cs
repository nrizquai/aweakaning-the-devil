using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectCard : MonoBehaviour
{
    private PlayerController inputs;
    int x = 0;
    [SerializeField]int y = 0;
    [SerializeField] float timer = 0;
    float timerMax = 0.3f;
    public GameObject[] cardSlot;
    public GameObject[] firstLine;
    public GameObject[] secondLine;
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
            MoveLeft();
            MoveUp();
        }
    }

    public void MoveLeft()
    {
        if (inputs.UI.NavigateH.ReadValue<float>() > 0.5f)
            if (x < 4)
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
            if (y < 0)
            {
                y++;
                cardSlot = firstLine;
                gameObject.transform.position = cardSlot[x].transform.position;
                timer = timerMax;
            }
        if (inputs.UI.NavigateV.ReadValue<float>() < -0.5f)
            if (y > -1)
            {
                y--;
                cardSlot = secondLine;
                gameObject.transform.position = cardSlot[x].transform.position;
                timer = timerMax;
            }
    }
}
