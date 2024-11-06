using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : Weapon
{
    Rigidbody2D rb2d;
    Vector2 force;

    public override void Move()
    {
        rb2d.AddForce(force);
       // Debug.Log("Rock move with Rigidbody:force");
    }

    public override void OnHitWith(Character character)
    {
        if (character is Player)
        {
            character.TakeDamage(this.Damage);
        }
        //Console.WriteLine($"{this.name}: Overriding OnHitWith(Character) ");
    }

    public void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        force = new Vector2(GetShootDirection() * 10,100);
        Damage = 20;
        Move();
    }
    void Update()
    {

    }

}
