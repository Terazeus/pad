using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePuzzleImage : MonoBehaviour {

    // voor de eindfoto rechts in beeld
    public Sprite PeopleImage1Full;
    public Sprite PeopleImage2Full;

    public Sprite SeasonImage1Full;
    public Sprite SeasonImage2Full;
    public Sprite SeasonImage3Full;
    public Sprite SeasonImage4Full;
    public Sprite SeasonImage5Full;
    public Sprite SeasonImage6Full;
    public Sprite SeasonImage7Full;
    public Sprite SeasonImage8Full;
    public Sprite SeasonImage9Full;
    public Sprite SeasonImage10Full;

    public Sprite CarImage1Full;
    public Sprite CarImage2Full;
    public Sprite CarImage3Full;
    public Sprite CarImage4Full;
    public Sprite CarImage5Full;

    // Use this for initialization

    // veranderd de volledige foto naar de correcte foto ( de foto die rechts staat )
    // misschien handiger in arraylist
    void Start () {
        if (MenuNavigation.PeopleImageFull == 1)
        {
            GetComponent<SpriteRenderer>().sprite = PeopleImage1Full;
        }

        else if (MenuNavigation.PeopleImageFull == 2)
        {
            GetComponent<SpriteRenderer>().sprite = PeopleImage2Full;
        }

        else if (MenuNavigation.SeasonImageFull == 1)
        {
            GetComponent<SpriteRenderer>().sprite = SeasonImage1Full;
        }

        else if (MenuNavigation.SeasonImageFull == 2)
        {
            GetComponent<SpriteRenderer>().sprite = SeasonImage2Full;
        }

        else if (MenuNavigation.SeasonImageFull == 3)
        {
            GetComponent<SpriteRenderer>().sprite = SeasonImage3Full;
        }

        else if (MenuNavigation.SeasonImageFull == 4)
        {
            GetComponent<SpriteRenderer>().sprite = SeasonImage4Full;
        }

        else if (MenuNavigation.SeasonImageFull == 5)
        {
            GetComponent<SpriteRenderer>().sprite = SeasonImage5Full;
        }

        else if (MenuNavigation.SeasonImageFull == 6)
        {
            GetComponent<SpriteRenderer>().sprite = SeasonImage6Full;
        }

        else if (MenuNavigation.SeasonImageFull == 7)
        {
            GetComponent<SpriteRenderer>().sprite = SeasonImage7Full;
        }

        else if (MenuNavigation.SeasonImageFull == 8)
        {
            GetComponent<SpriteRenderer>().sprite = SeasonImage8Full;
        }

        else if (MenuNavigation.SeasonImageFull == 9)
        {
            GetComponent<SpriteRenderer>().sprite = SeasonImage9Full;
        }

        else if (MenuNavigation.SeasonImageFull == 10)
        {
            GetComponent<SpriteRenderer>().sprite = SeasonImage10Full;
        }

        else if (MenuNavigation.CarImageFull == 1)
        {
            GetComponent<SpriteRenderer>().sprite = CarImage1Full;

        }

        else if (MenuNavigation.CarImageFull == 2)
        {
            GetComponent<SpriteRenderer>().sprite = CarImage2Full;
        }

        else if (MenuNavigation.CarImageFull == 3)
        {
            GetComponent<SpriteRenderer>().sprite = CarImage3Full;
        }

        else if (MenuNavigation.CarImageFull == 4)
        {
            GetComponent<SpriteRenderer>().sprite = CarImage4Full;
        }

        else if (MenuNavigation.CarImageFull == 5)
        {
            GetComponent<SpriteRenderer>().sprite = CarImage5Full;
        }

        MenuNavigation.PeopleImageFull = 0;
        MenuNavigation.CarImageFull = 0;
        MenuNavigation.SeasonImageFull = 0;

  
    }
	
	// Update is called once per frame
	void Update () {

    }
}
