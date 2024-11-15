using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    public int maxHealth = 100;
    [SerializeField] private int health;
    public int Health
    {
        get
        {
            return health;
        }
        set
        {
            health = value;
        }
    }
    public HealthBar healthBar;
    public Animator anim;
    public Rigidbody2D rb;

    public virtual void Init(int newHealth)
    {
        Health = newHealth;
        healthBar.SetMaxHealth(newHealth);  

        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }
    public bool IsDead()
    {
        if (health <= 0)
        {
            Destroy(this.gameObject);
            return true;

        }
        else return false;
        
    }
    public void TakeDamage(int damage)
    {
        Health -= damage;
        Debug.Log($"Take Damage monkey Hp remaining : {Health}");
        IsDead();
        healthBar.SetHealth(Health);
    }

    void Start()
    {
        Health = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void Update()
    {
        
    }
}