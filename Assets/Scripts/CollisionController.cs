using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D Collision)
    {
        if (Collision.gameObject.name == "box")
        {
            Debug.Log("enter");
        }
    }
}
