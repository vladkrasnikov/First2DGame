using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieSpace : MonoBehaviour
{
    public GameObject respawn;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            collision.transform.position = respawn.transform.position;
        }
    }
}
