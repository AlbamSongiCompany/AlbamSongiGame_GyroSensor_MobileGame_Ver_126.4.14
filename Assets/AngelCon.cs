using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class AngelCon : MonoBehaviour
{
    Rigidbody2D rb;
    private int charID;
    private float dt = 0;
    private int toggle = 0;
    private float move = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        charID = PlayerPrefs.GetInt("Charactor", 0);
        move = 0.01f;
    }

    // Update is called once per frame
    void Update()
    {
        if (dt > 1)
        {
            dt = 0;
        }
        toggle += 1;
        if (toggle < 300)
        {
            transform.Translate(new Vector3(-move, 0, 0));
            if (charID == 1)
            {
                transform.localScale = new Vector3(1, 1, 1);
            }
            if (charID == 2)
            {
                transform.localScale = new Vector3(1, 1, 1);
            }
            if (charID == 3)
            {
                transform.localScale = new Vector3(-0.75f, 0.75f, 1);
            }
            if (charID == 4)
            {
                transform.localScale = new Vector3(-1, 1, 1);
            }
        }
        else if (toggle < 600)
        {
            transform.Translate(new Vector3(move, 0, 0));
            if (charID == 1)
            {
                transform.localScale = new Vector3(-1, 1, 1);
            }
            if (charID == 2)
            {
                transform.localScale = new Vector3(-1, 1, 1);
            }
            if (charID == 3)
            {
                transform.localScale = new Vector3(0.75f, 0.75f, 1);
            }
            if (charID == 4)
            {
                transform.localScale = new Vector3(1, 1, 1);
            }
        }
        else
        {
            toggle = 1;
        }
    }
}
