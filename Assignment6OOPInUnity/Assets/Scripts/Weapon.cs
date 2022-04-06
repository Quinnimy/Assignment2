/*
 * Quinn Lamkin
 * Assignment 6 Video 
 * weapon class to show object variables
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    public int damageBonus;

    public Enemy EnemyHoldingWeapon;

    private void Awake()
    {
        EnemyHoldingWeapon = gameObject.GetComponent<Enemy>();
    }

    protected void EnemyEatsWeapon(Enemy enemy)
    {
        Debug.Log("Enemy eats Weapon");
    }

    public void Recharge()
    {
        Debug.Log("Recharging weapon");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
