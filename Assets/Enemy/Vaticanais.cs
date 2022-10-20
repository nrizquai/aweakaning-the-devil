using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vaticanais : MonoBehaviour
{ 
    [SerializeField] private float _speed;
    public Transform _target;
    void Awake()
    {
        _target = FindObjectOfType<PControl>().transform;

    }

    void Update()
    {
        follow();
    }
    public virtual void follow()
    {
        transform.position = Vector3.MoveTowards(transform.position, _target.position, _speed * Time.deltaTime);
    }
}