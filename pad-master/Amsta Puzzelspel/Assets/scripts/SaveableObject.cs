using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum ObjectType {Puzzelstuk, Score}

public abstract class SaveableObject : MonoBehaviour {

    protected string save;

    private ObjectType objectType;

	// Use this for initialization
	private void Start ()
    {
        SaveGameManager.Instance.SaveableObjects.Add(this);
	}

    public virtual void Save(int id)
    {

    }

    public virtual void Load(string[] values)
    {

    }  

    public void DestroySaveable()
    {

    }
	
}
