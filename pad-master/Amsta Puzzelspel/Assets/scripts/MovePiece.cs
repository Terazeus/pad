﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovePiece : MonoBehaviour {

    public string pieceStatus = "idle";

    public Transform edgeParticles;

    public KeyCode placePiece;
    public KeyCode returntoinv;

    public string checkPlacement = "";

    public float yDiff;

    public Vector2 invPos;

    public float edgeRadius;

    
    // voor de puzzelstukjes in de goede categorie
    //public Sprite stage2Image;

    public Sprite PeopleImage1;
    public Sprite PeopleImage2;
    public Sprite PeopleImage3;
    public Sprite PeopleImage4;
    public Sprite PeopleImage5;

    public Sprite SeasonsImage1;
    public Sprite SeasonsImage2;
    public Sprite SeasonsImage3;
    public Sprite SeasonsImage4;
    public Sprite SeasonsImage5;

    public Sprite CarsImage1;
    public Sprite CarsImage2;
    public Sprite CarsImage3;
    public Sprite CarsImage4;
    public Sprite CarsImage5;

    public Sprite SportsImage1;
    public Sprite SportsImage2;
    public Sprite SportsImage3;
    public Sprite SportsImage4;
    public Sprite SportsImage5;

    public Sprite AnimalsImage1;
    public Sprite AnimalsImage2;
    public Sprite AnimalsImage3;
    public Sprite AnimalsImage4;
    public Sprite AnimalsImage5;

    float x, y;
    Vector2 pos;


    // voor de score
    public static int totalScore;
    // scorebonus die aftelt
    public static float timeBonus;


        

	// Use this for initialization

        // veranderd de puzzels aan de hand van de levels
	void Start () {
        timeBonus = 150f;
        totalScore = 0;

        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;



        if (sceneName == "EasyPuzzleLevel")
        {
            GameMaster.remainingPieces = 9;

        }
        else if (sceneName == "MediumPuzzleLevel")
        {
            GameMaster.remainingPieces = 16;
        }
        else if (sceneName == "HardPuzzleLevel")
        {
            GameMaster.remainingPieces = 25;
        }

        //veranderd de puzzelstukjes naar de goede foto       

        if (MenuNavigation.PeopleLevel == 1)
        {
            GetComponent<SpriteRenderer>().sprite = PeopleImage1;
        }

       if (MenuNavigation.PeopleLevel == 2)
        {
            GetComponent<SpriteRenderer>().sprite = PeopleImage2;
        }


        if (MenuNavigation.PeopleLevel == 3)
        {
            GetComponent<SpriteRenderer>().sprite = PeopleImage3;
        }


        if (MenuNavigation.PeopleLevel == 4)
        {
            GetComponent<SpriteRenderer>().sprite = PeopleImage4;
        }


        if (MenuNavigation.PeopleLevel == 5)
        {
            GetComponent<SpriteRenderer>().sprite = PeopleImage5;
        }

        if (MenuNavigation.SeasonLevel == 1)
        {
            GetComponent<SpriteRenderer>().sprite = SeasonsImage1;
        }

        if (MenuNavigation.SeasonLevel == 2)
        {
            GetComponent<SpriteRenderer>().sprite = SeasonsImage2;
        }

        if (MenuNavigation.SeasonLevel == 3)
        {
            GetComponent<SpriteRenderer>().sprite = SeasonsImage3;
        }

        if (MenuNavigation.SeasonLevel == 4)
        {
            GetComponent<SpriteRenderer>().sprite = SeasonsImage4;
        }

        if (MenuNavigation.SeasonLevel == 5)
        {
            GetComponent<SpriteRenderer>().sprite = SeasonsImage5;
        }

        else if (MenuNavigation.CarLevel == 1)
        {
            GetComponent<SpriteRenderer>().sprite = CarsImage1;
        }

        else if (MenuNavigation.CarLevel == 2)
        {
            GetComponent<SpriteRenderer>().sprite = CarsImage2;
        }

        else if (MenuNavigation.CarLevel == 3)
        {
            GetComponent<SpriteRenderer>().sprite = CarsImage3;
        }

        else if (MenuNavigation.CarLevel == 4)
        {
            GetComponent<SpriteRenderer>().sprite = CarsImage4;
        }

        else if (MenuNavigation.CarLevel == 5 )
        {
            GetComponent<SpriteRenderer>().sprite = CarsImage5;
        }

        if (MenuNavigation.SportLevel == 1)
        {
            GetComponent<SpriteRenderer>().sprite = SportsImage1;
        }

        if (MenuNavigation.SportLevel == 2)
        {
            GetComponent<SpriteRenderer>().sprite = SportsImage2;
        }

        if (MenuNavigation.SportLevel == 3)
        {
            GetComponent<SpriteRenderer>().sprite = SportsImage3;
        }

        if (MenuNavigation.SportLevel == 4)
        {
            GetComponent<SpriteRenderer>().sprite = SportsImage4;
        }

        if (MenuNavigation.SportLevel == 5)
        {
            GetComponent<SpriteRenderer>().sprite = SportsImage5;
        }

        if (MenuNavigation.AnimalLevel == 1)
        {
            GetComponent<SpriteRenderer>().sprite = AnimalsImage1;
        }


        if (MenuNavigation.AnimalLevel == 2)
        {
            GetComponent<SpriteRenderer>().sprite = AnimalsImage2;
        }


        if (MenuNavigation.AnimalLevel == 3)
        {
            GetComponent<SpriteRenderer>().sprite = AnimalsImage3;
        }


        if (MenuNavigation.AnimalLevel == 4)
        {
            GetComponent<SpriteRenderer>().sprite = AnimalsImage4;
        }


        if (MenuNavigation.AnimalLevel == 5)
        {
            GetComponent<SpriteRenderer>().sprite = AnimalsImage5;
        }

        //RANDOMIZEN PUZZELSTUKJES OP HET HOUTEN BORD


        if (gameObject.name == "A1") {
            x = Random.Range(-9, -5);
            y = Random.Range(5, -7);
            pos = new Vector2(x, y);
            transform.position = pos;
            edgeRadius = 2;
        }

        if (gameObject.name == "A2")
        {
            x = Random.Range(-9, -5);
            y = Random.Range(5, -7);
            pos = new Vector2(x, y);
            transform.position = pos;
            edgeRadius = 2;
        }

        if (gameObject.name == "A3")
        {
            x = Random.Range(-9, -5);
            y = Random.Range(5, -7);
            pos = new Vector2(x, y);
            transform.position = pos;
            
        }

        if (gameObject.name == "A4")
        {
            x = Random.Range(-9, -5);
            y = Random.Range(5, -7);
            pos = new Vector2(x, y);
            transform.position = pos;
            
        }


        if (gameObject.name == "A5")
        {
            x = Random.Range(-9, -5);
            y = Random.Range(5, -7);
            pos = new Vector2(x, y);
            transform.position = pos;
            
        }
        
       if (gameObject.name == "B1")
        {
            x = Random.Range(-9, -5);
            y = Random.Range(5, -7);
            pos = new Vector2(x, y);
            transform.position = pos;
        }

        if (gameObject.name == "B2")
        {
            x = Random.Range(-9, -5);
            y = Random.Range(5, -7);
            pos = new Vector2(x, y);
            transform.position = pos;
        }

        if (gameObject.name == "B3")
        {
            x = Random.Range(-9, -5);
            y = Random.Range(5, -7);
            pos = new Vector2(x, y);
            transform.position = pos;
        }

        if (gameObject.name == "B4")
        {
            x = Random.Range(-9, -5);
            y = Random.Range(5, -7);
            pos = new Vector2(x, y);
            transform.position = pos;
        }

        if (gameObject.name == "B5")
        {
            x = Random.Range(-9, -5);
            y = Random.Range(5, -7);
            pos = new Vector2(x, y);
            transform.position = pos;
        }

        if (gameObject.name == "C1")
        {
            x = Random.Range(-9, -5);
            y = Random.Range(5, -7);
            pos = new Vector2(x, y);
            transform.position = pos;
        }

        if (gameObject.name == "C2")
        {
            x = Random.Range(-9, -5);
            y = Random.Range(5, -7);
            pos = new Vector2(x, y);
            transform.position = pos;
        }

        if (gameObject.name == "C3")
        {
            x = Random.Range(-9, -5);
            y = Random.Range(5, -7);
            pos = new Vector2(x, y);
            transform.position = pos;
        }

        if (gameObject.name == "C4")
        {
            x = Random.Range(-9, -5);
            y = Random.Range(5, -7);
            pos = new Vector2(x, y);
            transform.position = pos;
        }

        if (gameObject.name == "C5")
        {
            x = Random.Range(-9, -5);
            y = Random.Range(5, -7);
            pos = new Vector2(x, y);
            transform.position = pos;
        }

        if (gameObject.name == "D1")
        {
            x = Random.Range(-9, -5);
            y = Random.Range(5, -7);
            pos = new Vector2(x, y);
            transform.position = pos;
        }

        if (gameObject.name == "D2")
        {
            x = Random.Range(-9, -5);
            y = Random.Range(5, -7);
            pos = new Vector2(x, y);
            transform.position = pos;
        }

        if (gameObject.name == "D3")
        {
            x = Random.Range(-9, -5);
            y = Random.Range(5, -7);
            pos = new Vector2(x, y);
            transform.position = pos;
        }

        if (gameObject.name == "D4")
        {
            x = Random.Range(-9, -5);
            y = Random.Range(5, -7);
            pos = new Vector2(x, y);
            transform.position = pos;
        }

        if (gameObject.name == "D5")
        {
            x = Random.Range(-9, -5);
            y = Random.Range(5, -7);
            pos = new Vector2(x, y);
            transform.position = pos;
        }

        if (gameObject.name == "E1")
        {
            x = Random.Range(-9, -5);
            y = Random.Range(5, -7);
            pos = new Vector2(x, y);
            transform.position = pos;
        }

        if (gameObject.name == "E2")
        {
            x = Random.Range(-9, -5);
            y = Random.Range(5, -7);
            pos = new Vector2(x, y);
            transform.position = pos;
        }

        if (gameObject.name == "E3")
        {
            x = Random.Range(-9, -5);
            y = Random.Range(5, -7);
            pos = new Vector2(x, y);
            transform.position = pos;
        }

        if (gameObject.name == "E4")
        {
            x = Random.Range(-9, -5);
            y = Random.Range(5, -7);
            pos = new Vector2(x, y);
            transform.position = pos;
        }

        if (gameObject.name == "E5")
        {
            x = Random.Range(-9, -5);
            y = Random.Range(5, -7);
            pos = new Vector2(x, y);
            transform.position = pos;
        }
        

        
    }
	
	// Update is called once per frame
	void Update () {



        //invControl();

        if (pieceStatus == "pickedup")
        {
            //pakt de x en  y coords van de muis
            Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            //converteert de muiscoords naar de camera-unit
            Vector2 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            //wordt aan object toegevoegd
            transform.position = objPosition;

            GetComponent<PolygonCollider2D>().enabled = false;
        }

        if ((Input.GetKeyDown(placePiece)) && (pieceStatus == "pickedup"))
        {
            checkPlacement = "y";
        }

	}

    void OnTriggerStay2D(Collider2D other) {

        // socket moet gelijk zijn aan de naam van puzzelstukje
        // hierdoor komt het puzzelstuk op de goede plek te staan en locked het niet op een ander stuk

        
        if ((other.gameObject.name == gameObject.name) && (checkPlacement == "y"))
        {
            other.GetComponent<BoxCollider2D>().enabled = false;
            GetComponent<BoxCollider2D>().enabled = false;
            GetComponent<PolygonCollider2D>().enabled = false;
            GetComponent<Renderer>().sortingOrder = 0;
            transform.position = other.gameObject.transform.position;
            pieceStatus = "locked";
            Instantiate(edgeParticles, other.gameObject.transform.position, edgeParticles.rotation);
            checkPlacement = "n";
            GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
            //TODO: nog groene rand om puzzelstukje heen
            // geluid?

            //als gebruiker een stuk goed plaatst, score + 10
            totalScore += 10;
            GameMaster.remainingPieces -= 1;




        }
        if ((other.gameObject.name != gameObject.name) && (checkPlacement == "y"))
        {
            GetComponent<SpriteRenderer>().color = new Color(1, 1, 1,.5f);
            checkPlacement = "n";

            //als gebruiker een stuk fout plaatst, score - 2
            totalScore -= 2;
        }


    }

    void OnMouseDown() {
        pieceStatus = "pickedup";
        checkPlacement = "n";
        GetComponent<Renderer>().sortingOrder = 10;

        //Zodra je het stukje "oppakt", veranderd de grootte naar 2x
        gameObject.transform.localScale = new Vector3(1, 1,0);

        // zet het puzzelstuk terug
        invPos = transform.position;
    }







      /*void invControl() {
           //als je omhoog scrollt
           if ((Input.GetAxis("Mouse ScrollWheel") > 0) && (pieceStatus != "locked")) {
               transform.position = new Vector2(-11, transform.position.y - 3);
               yDiff -= 3;
           }
           //als je omlaag scrollt
           if ((Input.GetAxis("Mouse ScrollWheel") < 0) && (pieceStatus != "locked"))
           {
               transform.position = new Vector2(-11, transform.position.y + 3);
               yDiff += 3;
           }

           if ((Input.GetKeyDown (returntoinv)) && (pieceStatus == "pickedup"))
           {
               transform.position = new Vector2(-11, invPos.y + yDiff);

               //Veranderd de grootte weer naar klein-formaat als je hem terugzet
               gameObject.transform.localScale = new Vector3(0.5f, 0.5f, 0);

               pieceStatus = ""; 
           }
           
       } 
    }*/
}
