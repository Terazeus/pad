using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuNavigation : MonoBehaviour {

    public static int PeopleLevel;
    public static int PeopleImageFull;

    public static int CarLevel;
    public static int CarImageFull;

    public static int SeasonLevel;
    public static int SeasonImageFull;

   

    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update () {
		
	}

    //navigatie
    void OnMouseDown()
    {
    

        if (gameObject.name == "btn_Hoofdmenu")
        {
            SceneManager.LoadScene("MainMenu");
        }

        if (gameObject.name == "btn_PuzzelMaken")
        {
            SceneManager.LoadScene("UserSelect");
        }

        if (gameObject.name == "btn_Scorelijst")
        {
            SceneManager.LoadScene("HighScores");
        }

        // Selecteert het goede level en reset het aantal puzzelstukjes per moeilijkheidsgraad
        if (gameObject.name == "btn_Makkelijk" || gameObject.name == "img_MakkelijkPuzzelstukje")
        {
            SceneManager.LoadScene("EasyPuzzleLevel");
            
        }

        if (gameObject.name == "btn_Gemiddeld" || gameObject.name == "img_GemiddeldPuzzelstukje")
        {
            SceneManager.LoadScene("MediumPuzzleLevel");
           
        }

        if (gameObject.name == "btn_Moeilijk" || gameObject.name == "img_MoeilijkPuzzelstukje")
        {
            SceneManager.LoadScene("HardPuzzleLevel");
            
        }



        if (gameObject.name == "People 1")
        {
            
            PeopleLevel = 1;
            PeopleImageFull = 1;
            SceneManager.LoadScene("DifficultySelect");
        }

        else if (gameObject.name == "People 2")
        { 
            PeopleLevel = 2;
            PeopleImageFull = 2;
            SceneManager.LoadScene("DifficultySelect");
            
        }

        if (gameObject.name == "Seasons 1")
        {
          
            SeasonLevel = 1;
            SeasonImageFull = 1;
            SceneManager.LoadScene("DifficultySelect");
            
        }

        if (gameObject.name == "Seasons 2")
        {
            SeasonImageFull = 2;
            SeasonLevel = 2;            
            SceneManager.LoadScene("DifficultySelect");
        }
 
        if (gameObject.name == "Seasons 3")
        {
            SeasonLevel = 3;
            SeasonImageFull = 3;
            SceneManager.LoadScene("DifficultySelect");
        }

        if (gameObject.name == "Seasons 4")
        {
            SeasonLevel = 4;
            SeasonImageFull = 4;
            SceneManager.LoadScene("DifficultySelect");
        }

        if (gameObject.name == "Seasons 5")
        {
            SeasonLevel = 5;
            SeasonImageFull = 5;
            SceneManager.LoadScene("DifficultySelect");
        }

        if (gameObject.name == "Seasons 6")
        {
            SeasonLevel = 6;
            SeasonImageFull = 6;
            SceneManager.LoadScene("DifficultySelect");
        }

        if (gameObject.name == "Seasons 7")
        {
            SeasonLevel = 7;
            SeasonImageFull = 7;
            SceneManager.LoadScene("DifficultySelect");
        }

        if (gameObject.name == "Seasons 8")
        {
            SeasonLevel = 8;
            SeasonImageFull = 8;
            SceneManager.LoadScene("DifficultySelect");
        }

        if (gameObject.name == "Seasons 9")
        {
            SeasonLevel = 9;
            SeasonImageFull = 9;
            SceneManager.LoadScene("DifficultySelect");
        }

        if (gameObject.name == "Seasons 10")
        {
            SeasonLevel = 10;
            SeasonImageFull = 10;
            SceneManager.LoadScene("DifficultySelect");
        }

        
       else if (gameObject.name == "Cars 1")
        {
            CarLevel = 1;
            CarImageFull = 1;
            SceneManager.LoadScene("DifficultySelect");
        }

        if (gameObject.name == "Cars 2")
        {
            CarLevel = 2;
            CarImageFull = 2;
            SceneManager.LoadScene("DifficultySelect");
        }

        if (gameObject.name == "Cars 3")
        {
            CarLevel = 3;
            CarImageFull = 3;
            SceneManager.LoadScene("DifficultySelect");
        }

        if (gameObject.name == "Cars 4")
        {
            CarLevel = 4;
            CarImageFull = 4;
            SceneManager.LoadScene("DifficultySelect");
        }

        if (gameObject.name == "Cars 5")
        {
            CarLevel = 5;
            CarImageFull = 5;
            SceneManager.LoadScene("DifficultySelect");
        }


        if (gameObject.name == "Seasons 1")
        {
            SeasonLevel = 1;
            SeasonImageFull = 1;
            SceneManager.LoadScene("DifficultySelect");
        }

        if (gameObject.name == "Seasons 2")
        {
            SeasonLevel = 2;
            SeasonImageFull = 2;
            SceneManager.LoadScene("DifficultySelect");
        }

        if (gameObject.name == "Seasons 3")
        {
            SeasonLevel = 3;
            SeasonImageFull = 3;
            SceneManager.LoadScene("DifficultySelect");
        }

        if (gameObject.name == "Seasons 4")
        {
            SeasonLevel = 4;
            SeasonImageFull = 4;
            SceneManager.LoadScene("DifficultySelect");
        }

        if (gameObject.name == "Seasons 5")
        {
            SeasonLevel = 5;
            SeasonImageFull = 5;
            SceneManager.LoadScene("DifficultySelect");
        }

        if (gameObject.name == "Seasons 6")
        {
            SeasonLevel = 6;
            SeasonImageFull = 6;
            SceneManager.LoadScene("DifficultySelect");
        }

        if (gameObject.name == "Seasons 7")
        {
            SeasonLevel = 7;
            SeasonImageFull = 7;
            SceneManager.LoadScene("DifficultySelect");
        }

        if (gameObject.name == "Seasons 8")
        {
            SeasonLevel = 8;
            SeasonImageFull = 8;
            SceneManager.LoadScene("DifficultySelect");
        }

        if (gameObject.name == "Seasons 9")
        {
            SeasonLevel = 9;
            SeasonImageFull = 9;
            SceneManager.LoadScene("DifficultySelect");
        }

        if (gameObject.name == "Seasons 10")
        {
            SeasonLevel = 10;
            SeasonImageFull = 10;
            SceneManager.LoadScene("DifficultySelect");
        }       

        if (gameObject.name == "btn_People") {
            SceneManager.LoadScene("PeoplePuzzleSelect");
        }

       else if (gameObject.name == "btn_Cars")
        {
            SceneManager.LoadScene("CarsPuzzleSelect");
        }

       else if (gameObject.name == "btn_Seasons")
        {
            SceneManager.LoadScene("SeasonsPuzzleSelect");
        }







    }
}
