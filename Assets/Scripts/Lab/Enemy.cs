using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    private int damageHit;
    public int DamageHit
    {
        get
        {
            return damageHit;
        }
        set
        {
            damageHit = value;
        }
    }

    public Animator anim;
    public Rigidbody2D rb;
    [SerializeField] private int health;
    private void Start()
    {
        Behavior();
    }

    public abstract void Behavior();
}
