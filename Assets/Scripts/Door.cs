using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
   

    public void Move()
    {
        transform.Translate(new Vector3(0,10,0));
    }
}
