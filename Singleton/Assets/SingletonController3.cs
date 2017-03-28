using UnityEngine;
using System.Collections;

public class SingletonController3 : MonoBehaviour {

    private static SingletonController3 instance = null;
    public static SingletonController3 Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<SingletonController3>();
                if (instance == null)
                {
                    GameObject go = new GameObject();
                    go.name = "SingletonController3";
                    instance = go.AddComponent<SingletonController3>();
                    DontDestroyOnLoad(go);
                }
            }

            return instance;
        }
    }
    void Awake()
    {

        if (instance == null)
        {
           
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void Show()
    {
        print("SingletonController3");
        
    }

}
