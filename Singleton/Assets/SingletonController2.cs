using UnityEngine;
using System.Collections;

public class SingletonController2 : MonoBehaviour {

    public static SingletonController2 instance;

    void Awake()
    {

        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void Show()
    {
        print("SingletonController2");
        
    }

}
