using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePuzzleImage : MonoBehaviour {

    // voor de eindfoto rechts in beeld
    public Sprite PeopleImage1Full, PeopleImage2Full, PeopleImage3Full, PeopleImage4Full, PeopleImage5Full;
    public Sprite SeasonImage1Full, SeasonImage2Full, SeasonImage3Full, SeasonImage4Full, SeasonImage5Full;
    public Sprite CarImage1Full, CarImage2Full, CarImage3Full, CarImage4Full, CarImage5Full;
    public Sprite SportImage1Full, SportImage2Full, SportImage3Full, SportImage4Full, SportImage5Full;
    public Sprite AnimalImage1Full, AnimalImage2Full, AnimalImage3Full, AnimalImage4Full, AnimalImage5Full;


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

        else if (MenuNavigation.PeopleImageFull == 3)
        {
            GetComponent<SpriteRenderer>().sprite = PeopleImage3Full;
        }

        else if (MenuNavigation.PeopleImageFull == 4)
        {
            GetComponent<SpriteRenderer>().sprite = PeopleImage4Full;
        }

        else if (MenuNavigation.PeopleImageFull == 5)
        {
            GetComponent<SpriteRenderer>().sprite = PeopleImage5Full;
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

        else if (MenuNavigation.SportImageFull == 1)
        {
            GetComponent<SpriteRenderer>().sprite = SportImage1Full;
        }

        else if (MenuNavigation.SportImageFull == 2)
        {
            GetComponent<SpriteRenderer>().sprite = SportImage2Full;
        }

        else if (MenuNavigation.SportImageFull == 3)
        {
            GetComponent<SpriteRenderer>().sprite = SportImage3Full;
        }

        else if (MenuNavigation.SportImageFull == 4)
        {
            GetComponent<SpriteRenderer>().sprite = SportImage4Full;
        }

        else if (MenuNavigation.SportImageFull == 5)
        {
            GetComponent<SpriteRenderer>().sprite = SportImage5Full;
        }

        else if (MenuNavigation.AnimalImageFull == 1)
        {
            GetComponent<SpriteRenderer>().sprite = AnimalImage1Full;
        }

        else if (MenuNavigation.AnimalImageFull == 2)
        {
            GetComponent<SpriteRenderer>().sprite = AnimalImage2Full;
        }

        else if (MenuNavigation.AnimalImageFull == 3)
        {
            GetComponent<SpriteRenderer>().sprite = AnimalImage3Full;
        }

        else if (MenuNavigation.AnimalImageFull == 4)
        {
            GetComponent<SpriteRenderer>().sprite = AnimalImage4Full;
        }

        else if (MenuNavigation.AnimalImageFull == 5)
        {
            GetComponent<SpriteRenderer>().sprite = AnimalImage5Full;
        }

        MenuNavigation.PeopleImageFull = 0;
        MenuNavigation.CarImageFull = 0;
        MenuNavigation.SeasonImageFull = 0;
        MenuNavigation.SportImageFull = 0;
        MenuNavigation.AnimalImageFull = 0;


    }
	
	// Update is called once per frame
	void Update () {

    }
}
