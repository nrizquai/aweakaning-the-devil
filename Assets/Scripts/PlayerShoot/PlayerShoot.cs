using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject[] projectils;
    PlayerController inputs = null;
    GameObject shootOrigine;
    PControl playerControl;

    [SerializeField] float[] timer;
    [SerializeField] float[] timerMax;
    [SerializeField] float[] CD;
    [SerializeField] float[] cdMax;
    [SerializeField] int[] ammo;
    [SerializeField] int[] ammoMax;

    [SerializeField] bool[] reloading;
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
        Initiate(GameManager.instance.indexA, 0);
        Initiate(GameManager.instance.indexB, 1);
        Initiate(GameManager.instance.indexX, 2);
        Initiate(GameManager.instance.indexY, 3);
    }

    // Update is called once per frame
    void Update()
    {
        timer[0] -= Time.deltaTime;
        timer[1] -= Time.deltaTime;
        timer[2] -= Time.deltaTime;
        timer[3] -= Time.deltaTime;

        if (ammo[0] > 0)
            if (timer[0] <= 0)
                if (inputs.movement.A.ReadValue<float>() == 1)
                    Shoot(GameManager.instance.indexA, 0);
        if (!reloading[0])
            if (ammo[0] == 0)
            {
                Invoke("ReloadA", cdMax[0]);
                reloading[0] = true;
            }

        if (ammo[1] > 0)
            if (timer[1] <= 0)
                if (inputs.movement.B.ReadValue<float>() == 1)
                    Shoot(GameManager.instance.indexB, 1);
        if (!reloading[1])
            if (ammo[1] == 0)
            {
                Invoke("ReloadB", cdMax[1]);
                reloading[1] = true;
            }

        if (ammo[2] > 0)
            if (timer[2] <= 0)
                if (inputs.movement.X.ReadValue<float>() == 1)
                    Shoot(GameManager.instance.indexX, 2);
        if (!reloading[2])
            if (ammo[2] == 0)
            {
                Invoke("ReloadX", cdMax[2]);
                reloading[2] = true;
            }

        if (ammo[3] > 0)
            if (timer[3] <= 0)
                if (inputs.movement.Y.ReadValue<float>() == 1)
                    Shoot(GameManager.instance.indexY, 3);
        if (!reloading[3])
            if (ammo[3] == 0)
            {
                Invoke("ReloadY", cdMax[3]);
                reloading[3] = true;
            }
    }

    public void Shoot(int index, int indexTimer)
    {
        switch (index)
        {
            case 0:
                Bille200(shootOrigine, indexTimer);
                break;
            case 1:
                PouleDeFeu(shootOrigine, indexTimer);
                break;
            case 2:
                Pompe(shootOrigine, indexTimer);
                break;
            case 3:
                Chaines(shootOrigine, indexTimer);
                break;
        }
    }

    public void Initiate(int index,int indexTimer)
    {
        switch (index)
        {
            case 0:
                InitiateBille200(indexTimer);
                break;
            case 1:
                InitiatePouleDeFeu(indexTimer);
                break;
            case 2:
                InitiatePompe(indexTimer);
                break;
            case 3:
                InitiateChaine(indexTimer);
                break;
        }
    }

    public void Bille200(GameObject origine, int indexTimer)
    {
        GameObject bille = Instantiate(projectils[0], origine.transform.position, origine.transform.rotation);
        bille.GetComponent<Rigidbody2D>().AddRelativeForce(playerControl.GetDirectionShoot() * bille.GetComponent<Bille200>().GetProjSpeed(), ForceMode2D.Impulse);

        ammo[indexTimer]--;
        timer[indexTimer] = timerMax[indexTimer];
    }

    public void PouleDeFeu(GameObject origine, int indexTimer)
    {
        GameObject poule = Instantiate(projectils[1], origine.transform.position, origine.transform.rotation);
        poule.GetComponent<Rigidbody2D>().AddRelativeForce(playerControl.GetDirectionShoot() * poule.GetComponent<PouleDeFeu>().GetProjSpeed(), ForceMode2D.Impulse);

        ammo[indexTimer]--;
        timer[indexTimer] = timerMax[indexTimer];
    }
    public void Pompe(GameObject origine, int indexTimer)
    {
        Quaternion rotation = Quaternion.Euler(0, 0, playerControl.GetShootRotation());
        Quaternion rotation1 = Quaternion.Euler(0, 0, 45);
        Quaternion rotation2 = Quaternion.Euler(0, 0, - 45);
        GameObject pompe = Instantiate(projectils[2], origine.transform.position, origine.transform.rotation);
        GameObject pompe2 = Instantiate(projectils[2], origine.transform.position, rotation1);
        GameObject pompe3 = Instantiate(projectils[2], origine.transform.position, rotation2);
        pompe.GetComponent<Rigidbody2D>().AddRelativeForce(playerControl.GetDirectionShoot() * pompe.GetComponent<Pompe>().GetProjSpeed(), ForceMode2D.Impulse);
        pompe2.GetComponent<Rigidbody2D>().AddRelativeForce(playerControl.GetDirectionShoot() * pompe.GetComponent<Pompe>().GetProjSpeed(), ForceMode2D.Impulse);
        pompe3.GetComponent<Rigidbody2D>().AddRelativeForce(playerControl.GetDirectionShoot() * pompe.GetComponent<Pompe>().GetProjSpeed(), ForceMode2D.Impulse);

        ammo[indexTimer]--;
        timer[indexTimer] = timerMax[indexTimer];
    }

    public void Chaines(GameObject origine, int indexTimer)
    {
        Quaternion rotation = Quaternion.Euler(0, 0, playerControl.GetShootRotation());
        Instantiate(projectils[3], origine.transform.position, rotation);

        ammo[indexTimer]--;
        timer[indexTimer] = timerMax[indexTimer];
    }

    public void ReloadA()
    {
        ammo[0]= ammoMax[0];
        reloading[0] = false;
    }

    public void ReloadB()
    {
        ammo[1] = ammoMax[1];
        reloading[1] = false;
    }
    public void ReloadX()
    {
        ammo[2] = ammoMax[2];
        reloading[2] = false;
    }
    public void ReloadY()
    {
        ammo[3] = ammoMax[3];
        reloading[3] = false;
    }

    public void InitiateBille200(int indexTimer)
    {
        timerMax[indexTimer] = projectils[0].GetComponent<Bille200>().GetTimerMax();
        cdMax[indexTimer] = projectils[0].GetComponent<Bille200>().GetCooldown();
        ammoMax[indexTimer] = projectils[0].GetComponent<Bille200>().GetAmmo();
        ammo[indexTimer] = ammoMax[indexTimer];
    }

    public void InitiatePouleDeFeu(int indexTimer)
    {
        timerMax[indexTimer] = projectils[1].GetComponent<PouleDeFeu>().GetTimerMax();
        cdMax[indexTimer] = projectils[1].GetComponent<PouleDeFeu>().GetCooldown();
        ammoMax[indexTimer] = projectils[1].GetComponent<PouleDeFeu>().GetAmmo();
        ammo[indexTimer] = ammoMax[indexTimer];
    }

    public void InitiatePompe(int indexTimer)
    {
        timerMax[indexTimer] = projectils[2].GetComponent<Pompe>().GetTimerMax();
        cdMax[indexTimer] = projectils[2].GetComponent<Pompe>().GetCooldown();
        ammoMax[indexTimer] = projectils[2].GetComponent<Pompe>().GetAmmo();
        ammo[indexTimer] = ammoMax[indexTimer];
    }

    public void InitiateChaine(int indexTimer)
    {
        timerMax[indexTimer] = projectils[3].GetComponent<Chaines>().GetTimerMax();
        cdMax[indexTimer] = projectils[3].GetComponent<Chaines>().GetCooldown();
        ammoMax[indexTimer] = projectils[3].GetComponent<Chaines>().GetAmmo();
        ammo[indexTimer] = ammoMax[indexTimer];
    }

    public void DisableInputs()
    {
        inputs.Disable();
    }
}
