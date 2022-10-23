using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PouleDeFeu : Projectile
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Destroy", card.dispersion);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
