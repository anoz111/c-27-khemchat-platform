using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShortcutManagement;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField]private int damage;
    public int Damage
    {
        get
        {
            return damage;
        }
        set
        {
            damage = value;
        }
    }

    protected string owner = "IShootable";
    public abstract void OnHitWith(Character character);
    public abstract void Move();
    public int GetShootDirection()
    {
        return 1;
    }
}
