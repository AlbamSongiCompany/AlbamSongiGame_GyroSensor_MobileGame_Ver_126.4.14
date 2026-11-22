using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickSet : MonoBehaviour
{
    public GameObject char1;
    public GameObject char2;
    public GameObject char3;
    public GameObject char4;
    private int mode;
    // Start is called before the first frame update
    void Start()
    {
        mode = PlayerPrefs.GetInt("Charactor", 0);
        if (mode == 1)
        {
            char1.SetActive(true);
        }
        if (mode == 2)
        {
            char2.SetActive(true);
        }
        if (mode == 3)
        {
            char3.SetActive(true);
        }
        if (mode == 4)
        {
            char4.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
