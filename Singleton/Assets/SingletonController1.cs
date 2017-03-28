using UnityEngine;
using System.Collections;

public class SingletonController1 : MonoBehaviour {

    public static SingletonController1 instance;

    void Awake()
    {

        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }

    public void Show()
    {
        print("SingletonController1");
    }

}
