using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovePiece : MonoBehaviour {

    public string pieceStatus = "idle";

    public Transform edgeParticles;

    public KeyCode placePiece;
    public KeyCode returntoinv;

    public string checkPlacement = "";

    

    public Vector2 invPos;

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
            GameMaster.remainingPieces = 1;

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

      else if (MenuNavigation.PeopleLevel == 2)
        {
            GetComponent<SpriteRenderer>().sprite = PeopleImage2;
        }

        else if (MenuNavigation.PeopleLevel == 3)
        {
            GetComponent<SpriteRenderer>().sprite = PeopleImage3;
        }

        else if (MenuNavigation.PeopleLevel == 4)
        {
            GetComponent<SpriteRenderer>().sprite = PeopleImage4;
        }

        else if (MenuNavigation.PeopleLevel == 5)
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

         //RANDOMIZEN PUZZELSTUKJES OP HET HOUTEN BORD

      /*  if (gameObject.name == "A1") {
            x = Random.Range(-9, -5);
            y = Random.Range(5, -3);
            pos = new Vector2(x, y);
            transform.position = pos;
        } */



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


}
