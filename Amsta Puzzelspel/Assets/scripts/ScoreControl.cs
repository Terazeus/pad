using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreControl : MonoBehaviour {

	// Use this for initialization
	void Start () {

        // Toegevoegd zodat de 'Score' altijd BOVEN de puzzelstukjes staat, als je die eroverheen zet
        // Misschien weglaten aangezien we toch naar Click-and-Drop gaan ipv Drag-and-Drop?
        GetComponent<Renderer>().sortingOrder = 15;
		
	}
	
	// Update is called once per frame
	void Update () {

        // Bonuspunten kunnen nooit lager zijn dan 0.        
        if (MovePiece.timeBonus <= 0) {
            MovePiece.timeBonus = 0;
            
        }
        //berekening om de totale score te tonen
        GetComponent<TextMesh>().text = "Score:" + Mathf.RoundToInt(MovePiece.totalScore + MovePiece.timeBonus).ToString();
		
	}
}
