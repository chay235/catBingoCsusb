using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catfeeding : MonoBehaviour
{
    void onCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "catfeed") Destroy(gameObject);
    }
}
