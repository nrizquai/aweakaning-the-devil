using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;
using static UnityEngine.InputSystem.InputAction;

public class PControl : MonoBehaviour
{
    PlayerController inputs = null;
    Rigidbody2D player;
    Animator animWalk;
    [SerializeField]Vector2 pos = Vector2.zero;
    GameObject shootOrigine;

    Vector3 shootdirection;
    void Awake()
    {
        inputs = new PlayerController();
        //inputs.movement.LeftStick.started += Movement;
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
        //pos = Vector2.zero;
        player = this.GetComponent<Rigidbody2D>();
        animWalk = this.GetComponent<Animator>();
        shootOrigine = GameObject.FindGameObjectWithTag("OrigineShoot");
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        pos.x = inputs.movement.LeftStickLR.ReadValue<float>();
        pos.y = inputs.movement.LeftStickDU.ReadValue<float>();
        float velocity = 50 * Time.deltaTime;

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
            shootOrigine.transform.position = Vector3.right + transform.position;
            shootdirection = Vector3.right;
            animWalk.SetFloat("moveX", 1);
            animWalk.SetFloat("moveY", 0);
        }
        if(pos.x < 0)
        {
            pos.x = -velocity;
            shootOrigine.transform.position = Vector3.right * (-1) + transform.position;
            shootdirection = Vector3.right * (-1);
            animWalk.SetFloat("moveX", -1);
            animWalk.SetFloat("moveY", 0);
        }
        if(pos.y > 0)
        {
            pos.y = velocity;
            shootOrigine.transform.position = Vector3.up + transform.position;
            shootdirection = Vector3.up;
            animWalk.SetFloat("moveX", 0); 
            animWalk.SetFloat("moveY", 1);
        }
        if(pos.y < 0)
        {
            pos.y = -velocity;
            shootOrigine.transform.position = Vector3.up * (-1) + transform.position;
            shootdirection = Vector3.up * (-1);
            animWalk.SetFloat("moveX", 0); 
            animWalk.SetFloat("moveY", -1);
        }


        Vector2 nextpos = player.position + Vector2.right * pos.x + Vector2.up * pos.y;
        player.MovePosition(nextpos);
    }

    public Vector3 GetDirectionShoot()
    {
        return shootdirection;
    }
}
