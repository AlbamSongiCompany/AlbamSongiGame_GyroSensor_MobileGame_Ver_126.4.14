using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialCon : MonoBehaviour
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
            rb.AddForce(new Vector3(0, 2.5f, 0), ForceMode2D.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.Space) && rb.velocity.y == 0)
        {
            //Debug.Log("ÄáÄá");
            rb.AddForce(new Vector3(0, 7.5f, 0), ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //Debug.Log("¿ì·Î¹ÐÂø");
            transform.Translate(new Vector3(0.05f, 0, 0));
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
                transform.localScale = new Vector3(1, 1, 1);
            }
            if (charID == 4)
            {
                transform.localScale = new Vector3(0.5f, 0.5f, 1);
            }
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //Debug.Log("ÁÂ·Î¹ÐÂø");
            transform.Translate(new Vector3(-0.05f, 0, 0));
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
                transform.localScale = new Vector3(-1, 1, 1);
            }
            if (charID == 4)
            {
                transform.localScale = new Vector3(-0.5f, 0.5f, 1);
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            //Debug.Log("¿ì·Î¹ÐÂø");
            transform.Translate(new Vector3(0.05f, 0, 0));
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
                transform.localScale = new Vector3(1, 1, 1);
            }
            if (charID == 4)
            {
                transform.localScale = new Vector3(0.5f, 0.5f, 1);
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            //Debug.Log("ÁÂ·Î¹ÐÂø");
            transform.Translate(new Vector3(-0.05f, 0, 0));
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
                transform.localScale = new Vector3(-1, 1, 1);
            }
            if (charID == 4)
            {
                transform.localScale = new Vector3(-0.5f, 0.5f, 1);
            }
        }
        float goX = Input.acceleration.x;   // ÁÂ¿ì ±â¿ï±â: -1.0 ~ 1.0
        if (goX > gotil)
        {
            //Debug.Log("¿ì·Î¹ÐÂø");
            transform.Translate(new Vector3(0.1f, 0, 0));
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
                transform.localScale = new Vector3(1, 1, 1);
            }
            if (charID == 4)
            {
                transform.localScale = new Vector3(0.5f, 0.5f, 1);
            }
        }
        if (goX < -gotil)
        {
            //Debug.Log("ÁÂ·Î¹ÐÂø");
            transform.Translate(new Vector3(-0.1f, 0, 0));
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
                transform.localScale = new Vector3(-1, 1, 1);
            }
            if (charID == 4)
            {
                transform.localScale = new Vector3(-0.5f, 0.5f, 1);
            }
        }
        if (transform.position.y < -7.5f)
        {
            transform.position = new Vector3(-3.86f, 2.58f, 0);
        }
    }
}
