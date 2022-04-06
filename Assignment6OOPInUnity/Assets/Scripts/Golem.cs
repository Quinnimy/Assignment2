/*
 * Quinn Lamkin
 * Assignment 6 Video 
 * Enemy subclass used to show inheiretance
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golem : Enemy
{
    protected int damage;
    // Start is called before the first frame update
    protected override void Awake()
    {
        base.Awake();
        health = 120;
        GameManager.Instance.score+=2;
    }

    protected override void Attack(int amount)
    {
        Debug.Log("Golem Attacks");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void TakeDamage(int amount)
    {
        Debug.Log("You Took " + amount + " points of damage");
    }
}
