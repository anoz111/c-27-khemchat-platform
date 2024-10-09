using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : Weapon
{
    private Rigidbody2D rb;
    private Vector2 force;

    public override void Move()
    {
        Debug.Log("Rock move with Rigidbody:force");
    }

    public override void OnHitWith(Character character)
    {
    }

    private void Start()
    {
        Damage = 40;
        Move();
    }
}
