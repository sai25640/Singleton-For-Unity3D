using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class test2 : MonoBehaviour {

	// Use this for initialization
	void Start () {

        SingletonController1.instance.Show();
        SingletonController2.instance.Show();
    }
	
}
