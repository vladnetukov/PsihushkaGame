using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlatformController8 : MonoBehaviour {
    public float forceJump;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y < 0)
        {
            Controller8.instance.PersonRigid.velocity = Vector2.up * forceJump;
        }

    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.name == "DeadZone")
        {
            float RandX = Random.Range(-2.4f, 2.4f);
            float RandY = Random.Range(transform.position.y + 30f, transform.position.y + 31f);
            transform.position = new Vector3(RandX, RandY, 0);

        }
    }

}