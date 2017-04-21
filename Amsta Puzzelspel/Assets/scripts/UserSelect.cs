using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UserSelect : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {           

    }

    void OnMouseDown()
    {

        if (gameObject.name == "img_User1")
        {
            SceneManager.LoadScene("LevelSelect");
        }

        if (gameObject.name == "img_User2")
        {
            SceneManager.LoadScene("LevelSelect");
        }
    }
}
