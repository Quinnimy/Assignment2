/*
 * Quinn Lamkin
 * Assignment 6 Video 
 * singleton class generic data tye
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : Singleton<T>
{
    private static T instance;

    public static T Instance
    {
        get { return instance; }
    }

    public static bool isInitialized
    {
        get { return instance != null; }
    }

    private void Awake()
    {
        if(instance != null)
        {
            Debug.LogError("[Singleton] trying to instantiate second duplicate of class");
            
        }
        else
        {
            instance = (T)this;
        }
    }

    protected virtual void OnDestroy()
    {
        //iff obj is destroyed create another
        if ( instance ==this)
        {
            instance = null;
        }
    }
}
