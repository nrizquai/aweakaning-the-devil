using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Cards", menuName ="My game/Cards")]
public class Cards : ScriptableObject
{
    public float cooldown;
    public int ammo;
    public int speed;
    public int damage;
    public float atkSpeed;
    public float dispersion;
}
