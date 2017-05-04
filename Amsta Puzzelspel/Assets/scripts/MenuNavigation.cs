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

    public static int SportLevel;
    public static int SportImageFull;

    public static int AnimalLevel;
    public static int AnimalImageFull;



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

        if (gameObject.name == "btn_Instellingen")
        {
            SceneManager.LoadScene("OptionsMenu");
        }
        if (gameObject.name == "btn_terug")
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

        // gekozen foto veranderd het level naar de juiste puzzelstukjes met bijbehorende volledige foto

        if (gameObject.name == "People 1")
        {
            
            PeopleLevel = 1;
            PeopleImageFull = 1;
            SceneManager.LoadScene("DifficultySelect");
        }

        if (gameObject.name == "People 2")
        { 
            PeopleLevel = 2;
            PeopleImageFull = 2;
            SceneManager.LoadScene("DifficultySelect");
            
        }

        if (gameObject.name == "People 3")
        {
            PeopleLevel = 3;
            PeopleImageFull = 3;
            SceneManager.LoadScene("DifficultySelect");

        }

        if (gameObject.name == "People 4")
        {
            PeopleLevel = 4;
            PeopleImageFull = 4;
            SceneManager.LoadScene("DifficultySelect");

        }

        if (gameObject.name == "People 5")
        {
            PeopleLevel = 5;
            PeopleImageFull = 5;
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

        
        if (gameObject.name == "Cars 1")
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

        if (gameObject.name == "Sports 1")
        {
            SportLevel = 1;
            SportImageFull = 1;
            SceneManager.LoadScene("DifficultySelect");
        }

        if (gameObject.name == "Sports 2")
        {
            SportLevel = 2;
            SportImageFull = 2;
            SceneManager.LoadScene("DifficultySelect");
        }

        if (gameObject.name == "Sports 3")
        {
            SportLevel = 3;
            SportImageFull = 3;
            SceneManager.LoadScene("DifficultySelect");
        }

        if (gameObject.name == "Sports 4")
        {
            SportLevel = 4;
            SportImageFull = 4;
            SceneManager.LoadScene("DifficultySelect");
        }

        if (gameObject.name == "Sports 5")
        {
            SportLevel = 5;
            SportImageFull = 5;
            SceneManager.LoadScene("DifficultySelect");
        }

        // gaat naar het juiste scherm van de gekozen categorie

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

        else if (gameObject.name == "btn_Sports")
        {
            SceneManager.LoadScene("SportsPuzzleSelect");
        }

        else if (gameObject.name == "btn_Animals")
        {
            SceneManager.LoadScene("AnimalsPuzzleSelect");
        }
    }
}
