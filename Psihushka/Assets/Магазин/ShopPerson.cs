using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopPerson : MonoBehaviour {

    public GameObject tick1;
    public GameObject tick2;
    public GameObject tick3;
    public GameObject tick4;
    private int NumberPerson;

    void Start()
    {
        NumberPerson = PlayerPrefs.GetInt("Персонаж");
    }

    void Update()
    {
        if (NumberPerson == 1)
        {
            tick1.SetActive(true);
            tick2.SetActive(false);
            tick3.SetActive(false);
            tick4.SetActive(false);
        }
        if (NumberPerson == 2)
        {
            tick1.SetActive(false);
            tick2.SetActive(true);
            tick3.SetActive(false);
            tick4.SetActive(false);
        }
        if (NumberPerson == 3)
        {
            tick1.SetActive(false);
            tick2.SetActive(false);
            tick3.SetActive(true);
            tick4.SetActive(false);      
        }
        if (NumberPerson == 4)
        {
            tick1.SetActive(false);
            tick2.SetActive(false);
            tick3.SetActive(false);
            tick4.SetActive(true);
        }
    }

    public void Person1()
    {
        NumberPerson = 1;
        PlayerPrefs.SetInt("Персонаж", NumberPerson);
    }

    public void Person2()
    {
        NumberPerson = 2;
        PlayerPrefs.SetInt("Персонаж", NumberPerson);
    }
    public void Person3()
    {
        NumberPerson = 3;
        PlayerPrefs.SetInt("Персонаж", NumberPerson);
    }
    public void Person4()
    {
        NumberPerson = 4;
        PlayerPrefs.SetInt("Персонаж", NumberPerson);
    }
}
