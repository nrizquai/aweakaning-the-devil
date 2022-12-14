using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;
using static UnityEngine.InputSystem.InputAction;

public class PControl : Entity
{
    PlayerController inputs = null;
    Rigidbody2D player;
    [SerializeField]Vector2 pos = Vector2.zero;

    bool lockDirection;

    GameObject shootOrigine;
    Vector3 shootdirection;
    float shootRotation;
    void Awake()
    {
        inputs = new PlayerController();
    }
    private void OnEnable()
    {
        inputs.movement.Enable();
    }

    private void OnDisable()
    {
        inputs.movement.Disable();
    }
    void Start()
    {
        player = this.GetComponent<Rigidbody2D>();
        animWalk = this.GetComponent<Animator>();
        shootOrigine = GameObject.FindGameObjectWithTag("OrigineShoot");
        GameManager.instance.originePlayerPos = transform.position;
        pv = 150;
        _speed = 30;
    }

    void Update()
    {
        timerSFX -= Time.deltaTime;
        inputs.movement.Lock.performed += ctx => Lock();
        inputs.movement.Lock.canceled += ctx => DeLock();
        inputs.movement.Pause.started += ctx => GameManager.instance.Pause();
        Movement();
        Death();
    }

    void Movement()
    {
        pos.x = inputs.movement.LeftStickLR.ReadValue<float>();
        pos.y = inputs.movement.LeftStickDU.ReadValue<float>();
        float velocity = _speed * Time.deltaTime;

        if (pos.x != 0 || pos.y != 0)
        {
            animWalk.SetBool("isWalking", true);
        }
        else
        {
            animWalk.SetBool("isWalking", false);
        }

        if(pos.x > 0)
        {
            pos.x = velocity;
            if (!lockDirection)
            {
                shootOrigine.transform.position = Vector3.right * 0.5f + transform.position;
                shootdirection = Vector3.right;
                shootRotation = -90;
                animWalk.SetFloat("moveX", 1);
                animWalk.SetFloat("moveY", 0);
            }
        }
        if(pos.x < 0)
        {
            pos.x = -velocity;
            if (!lockDirection)
            {
                shootOrigine.transform.position = Vector3.right * (-0.5f) + transform.position;
                shootdirection = Vector3.right * (-1);
                shootRotation = 90;
                animWalk.SetFloat("moveX", -1);
                animWalk.SetFloat("moveY", 0);
            }
        }
        if(pos.y > 0)
        {
            pos.y = velocity;
            if (!lockDirection)
            {
                shootOrigine.transform.position = Vector3.up + transform.position;
                shootdirection = Vector3.up;
                shootRotation = 0;
                animWalk.SetFloat("moveX", 0);
                animWalk.SetFloat("moveY", 1);
            }
        }
        if(pos.y < 0)
        {
            pos.y = -velocity;
            if (!lockDirection)
            {
                shootOrigine.transform.position = Vector3.up * (-1) + transform.position;
                shootdirection = Vector3.up * (-1);
                shootRotation = 180;
                animWalk.SetFloat("moveX", 0);
                animWalk.SetFloat("moveY", -1);
            }
        }


        Vector2 nextpos = player.position + Vector2.right * pos.x + Vector2.up * pos.y;
        player.MovePosition(nextpos);
    }

    public Vector3 GetDirectionShoot()
    {
        return shootdirection;
    }

    public float GetShootRotation()
    {
        return shootRotation;
    }

    public float GetHp()
    {
        return pv;
    }

    public void Lock()
    {
        lockDirection = true;
    }

    public void DeLock()
    {
        lockDirection = false;
    }

    public void DisableInputsPC()
    {
        inputs.Disable();
    }
    public void EnableInputsPC()
    {
        inputs.Enable();
    }

    public override void Death()
    {
        if (pv <= 0)
        {
            GameManager.instance.gameover.SetActive(true);
            GameManager.instance.inGameCanvas.SetActive(false);
            GameManager.instance.winLoseCanvas.SetActive(true);
            EventSystem.current.SetSelectedGameObject(null);
            EventSystem.current.SetSelectedGameObject(GameManager.instance.firstButtonWinLose);
            Destroy(gameObject);
        }
    }
}
