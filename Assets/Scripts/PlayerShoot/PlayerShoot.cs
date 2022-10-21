using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject[] projectils;
    PlayerController inputs = null;
    GameObject shootOrigine;
    PControl playerControl;
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

    // Start is called before the first frame update
    void Start()
    {
        shootOrigine = GameObject.FindGameObjectWithTag("OrigineShoot");
        playerControl = GetComponent<PControl>();
    }

    // Update is called once per frame
    void Update()
    {
        inputs.movement.A.started += ctx => Shoot(GameManager.instance.indexA);
        inputs.movement.B.started += ctx => Shoot(GameManager.instance.indexB);
        inputs.movement.X.started += ctx => Shoot(GameManager.instance.indexX);
        inputs.movement.Y.started += ctx => Shoot(GameManager.instance.indexY);
    }

    public void Bille200(GameObject origine)
    {
        GameObject bille = Instantiate(projectils[0], origine.transform.position, origine.transform.rotation);
        bille.GetComponent<Rigidbody2D>().AddRelativeForce(playerControl.GetDirectionShoot() * bille.GetComponent<Bille200>().GetProjSpeed(), ForceMode2D.Impulse);
    }

    public void Shoot(int index)
    {
        switch (index)
        {
            case 0: Bille200(shootOrigine);
                break;
        }
    }
}
