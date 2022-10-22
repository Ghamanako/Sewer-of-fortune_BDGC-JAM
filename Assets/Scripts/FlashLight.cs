using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour
{
    public GameObject On;
    public GameObject Off;

    bool IsOn;

    // Start is called before the first frame update
    void Start()
    {
        On.SetActive(false);
        Off.SetActive(true);
        IsOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            if (IsOn)
            {
                On.SetActive(false);
                Off.SetActive(true);
            }
            if (!IsOn)
            {
                On.SetActive(true);
                Off.SetActive(false);
            }

            IsOn = !IsOn;
        }
    }
}
