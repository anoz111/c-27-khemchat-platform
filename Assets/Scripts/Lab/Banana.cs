using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class Banana : Weapon
{
    [SerializeField]private float Speed;
    public override void Move()
    {
        Debug.Log("Banana moves with constant speed using Transform");
    }

    public override void OnHitWith(Character character)
    {
    }

    private void Start()
    {
        Damage = 30;
        Speed = 4;
        Move();
    }
}
