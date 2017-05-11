using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveGameManager : MonoBehaviour {

    private static SaveGameManager instance;

    public List<SaveableObject> SaveableObjects { get; private set; }

    public static SaveGameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = GameObject.FindObjectOfType<SaveGameManager>();
            }
            return instance;
        }
    }

	// Use this for initialization
	void Awake ()
    {
		
	}

    public void Save()
    {

    }

    public void Load()
    {

    }

    public Vector3 StringToVector(string value)
    {
        return Vector3.zero;
    }
}
