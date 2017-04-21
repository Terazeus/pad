using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour {

    // aantal stukken die nog over zijn van de puzzel voor completion
    public static int remainingPieces = 0;


    // Use this for initialization
    void Start () {
       

    }
	
	// Update is called once per frame
	void Update () {


        if (remainingPieces > 0) {
            MovePiece.timeBonus -= Time.deltaTime;
        }



        if (remainingPieces == 0)
        {
            SceneManager.LoadScene("VictoryScreen");
            MenuNavigation.PeopleLevel = 0;
            MenuNavigation.SeasonLevel = 0;
            MenuNavigation.CarLevel = 0;

        }

    }
}
