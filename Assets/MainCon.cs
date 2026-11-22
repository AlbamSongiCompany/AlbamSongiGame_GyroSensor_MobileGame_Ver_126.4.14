using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCon : MonoBehaviour
{
    Rigidbody2D rb;
    public float gotil = 0.2f; // °¨Áö ¹Î°¨µµ(°¡¼Óµµ ¼¾¼­)
    private int charID;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        charID = PlayerPrefs.GetInt("Charactor", 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Debug.Log("µÕµÕ");
            rb.AddForce(new Vector3(0, 2, 0), ForceMode2D.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.Space) && rb.velocity.y == 0)
        {
            //Debug.Log("ÄáÄá");
            rb.AddForce(new Vector3(0, 6, 0), ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //Debug.Log("¿ì·Î¹ÐÂø");
            transform.Translate(new Vector3(0.05f, 0, 0));
            if (charID == 1)
            {
                transform.localScale = new Vector3(-0.75f, 0.75f, 1);
            }
            if (charID == 2)
            {
                transform.localScale = new Vector3(-0.75f, 0.75f, 1);
            }
            if (charID == 3)
            {
                transform.localScale = new Vector3(4.5f, 4.5f, 1);
            }
            if (charID == 4)
            {
                transform.localScale = new Vector3(2.25f, 2.25f, 1);
            }
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //Debug.Log("ÁÂ·Î¹ÐÂø");
            transform.Translate(new Vector3(-0.05f, 0, 0));
            if (charID == 1)
            {
                transform.localScale = new Vector3(0.75f, 0.75f, 1);
            }
            if (charID == 2)
            {
                transform.localScale = new Vector3(0.75f, 0.75f, 1);
            }
            if (charID == 3)
            {
                transform.localScale = new Vector3(-4.5f, 4.5f, 1);
            }
            if (charID == 4)
            {
                transform.localScale = new Vector3(-2.25f, 2.25f, 1);
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            //Debug.Log("¿ì·Î¹ÐÂø");
            transform.Translate(new Vector3(0.05f, 0, 0));
            if (charID == 1)
            {
                transform.localScale = new Vector3(-0.75f, 0.75f, 1);
            }
            if (charID == 2)
            {
                transform.localScale = new Vector3(-0.75f, 0.75f, 1);
            }
            if (charID == 3)
            {
                transform.localScale = new Vector3(4.5f, 4.5f, 1);
            }
            if (charID == 4)
            {
                transform.localScale = new Vector3(2.25f, 2.25f, 1);
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            //Debug.Log("ÁÂ·Î¹ÐÂø");
            transform.Translate(new Vector3(-0.05f, 0, 0));
            if (charID == 1)
            {
                transform.localScale = new Vector3(0.75f, 0.75f, 1);
            }
            if (charID == 2)
            {
                transform.localScale = new Vector3(0.75f, 0.75f, 1);
            }
            if (charID == 3)
            {
                transform.localScale = new Vector3(-4.5f, 4.5f, 1);
            }
            if (charID == 4)
            {
                transform.localScale = new Vector3(-2.25f, 2.25f, 1);
            }
        }
        float goX = Input.acceleration.x;   // ÁÂ¿ì ±â¿ï±â: -1.0 ~ 1.0
        if (goX > gotil)
        {
            //Debug.Log("¿ì·Î¹ÐÂø");
            transform.Translate(new Vector3(0.1f, 0, 0));
            if (charID == 1)
            {
                transform.localScale = new Vector3(-0.75f, 0.75f, 1);
            }
            if (charID == 2)
            {
                transform.localScale = new Vector3(-0.75f, 0.75f, 1);
            }
            if (charID == 3)
            {
                transform.localScale = new Vector3(4.5f, 4.5f, 1);
            }
            if (charID == 4)
            {
                transform.localScale = new Vector3(2.25f, 2.25f, 1);
            }
        }
        if (goX < -gotil)
        {
            //Debug.Log("ÁÂ·Î¹ÐÂø");
            transform.Translate(new Vector3(-0.1f, 0, 0));
            if (charID == 1)
            {
                transform.localScale = new Vector3(0.75f, 0.75f, 1);
            }
            if (charID == 2)
            {
                transform.localScale = new Vector3(0.75f, 0.75f, 1);
            }
            if (charID == 3)
            {
                transform.localScale = new Vector3(-4.5f, 4.5f, 1);
            }
            if (charID == 4)
            {
                transform.localScale = new Vector3(-2.25f, 2.25f, 1);
            }
        }
    }
}
