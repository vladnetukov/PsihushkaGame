using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberPerson : MonoBehaviour {

    private int numberPerson;
    public GameObject person1;
    public GameObject person2;
    public GameObject person3;
    public GameObject person4;

    // Use this for initialization
    void Start () {
        numberPerson = PlayerPrefs.GetInt("Персонаж");
	}
	
	// Update is called once per frame
	void Update () {
        if (numberPerson == 1)
        {
            person1.SetActive(true);
            person2.SetActive(false);
            person3.SetActive(false);
            person4.SetActive(false);
        }
        if (numberPerson == 2)
        {
            person1.SetActive(false);
            person2.SetActive(true);
            person3.SetActive(false);
            person4.SetActive(false);
        }
        if (numberPerson == 3)
        {
            person1.SetActive(false);
            person2.SetActive(false);
            person3.SetActive(true);
            person4.SetActive(false);
        }
        if (numberPerson == 4)
        {
            person1.SetActive(false);
            person2.SetActive(false);
            person3.SetActive(false);
            person4.SetActive(true);
        }
    }
}
