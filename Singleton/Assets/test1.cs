using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class test1 : MonoBehaviour {

	// Use this for initialization
	void Start () {

        SingletonController1.instance.Show();
        SingletonController2.instance.Show();
        print(Singleton.Instance.name);
        Invoke("LoadNextScene", 5f);
    }
	
	private void LoadNextScene()
    {
        SceneManager.LoadScene("Scene3");
    }
}
