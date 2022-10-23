using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeKeyRoom5 : MonoBehaviour
{
    public GameObject Door1;
    public GameObject Door2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Door1.SetActive(false);
            Door2.SetActive(false);
            Destroy(this.gameObject);
        }
    }
}
