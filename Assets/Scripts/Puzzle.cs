using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle : MonoBehaviour
{

    public Door door;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Cube")
        {
            door.Move();
        }
    }

   
}
