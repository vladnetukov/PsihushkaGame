using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller7 : MonoBehaviour {

    public static Controller7 instance;
    float horizontal;
    public Rigidbody2D PersonRigid;
    public GameObject deathScreen;
    public GameObject finishScreen;
    // Use this for initialization
    void Start()
    {

        if (instance == null)
        {
            instance = this;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {


        if (Application.platform == RuntimePlatform.Android)
        {
            horizontal = Input.acceleration.x;
        }
        if (Input.acceleration.x < -0.2)
        {
            //gameObject.GetComponent<SpriteRenderer>().flipX = false;
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
        if (Input.acceleration.x > 0.2)
        {
            //gameObject.GetComponent<SpriteRenderer>().flipX = true;
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        PersonRigid.velocity = new Vector2(Input.acceleration.x * 10f, PersonRigid.velocity.y);

    }



    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name == "DeadZone2")
        {
            if (!deathScreen.activeSelf)
            {
                deathScreen.SetActive(true);
                PersonRigid.velocity = new Vector3(0, 0, 0);

            }
        }
        if (collision.collider.name == "Finish7")
        {
            if (!finishScreen.activeSelf)
            {
                Time.timeScale = 0f;
                finishScreen.SetActive(true);


            }
        }

    }


}
