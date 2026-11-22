using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CharactorCon : MonoBehaviour
{
    Rigidbody2D rb;
    public float gotil = 0.2f; // °¨Áö ¹Î°¨µµ(°¡¼Óµµ ¼¾¼­)
    private int charID;
    public Text TierPoint;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        charID = PlayerPrefs.GetInt("Charactor",0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Debug.Log("µÕµÕ");
            rb.AddForce(new Vector3(0, 2.5f, 0), ForceMode2D.Impulse);
        }
        if(Input.GetKeyDown(KeyCode.Space) && rb.velocity.y == 0)
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
            int TPnt = PlayerPrefs.GetInt("TierPoint", 0);
            int Cur_Stage1 = PlayerPrefs.GetInt("GameStage", 0);
            switch (Cur_Stage1)
            {
                case 0:
                    break;
                case 1:
                    if (TPnt >= 1)
                    {
                        Debug.Log("Point : " + -1);
                        TPnt -= 1;
                    }
                        break;
                case 2:
                    if (TPnt >= 1)
                    {
                        Debug.Log("Point : " + -1);
                        TPnt -= 1;
                    }
                    break;
                case 3:
                    if (TPnt >= 2)
                    {
                        Debug.Log("Point : " + -2);
                        TPnt -= 2;
                    }
                    break;
                case 4:
                    if (TPnt >= 2)
                    {
                        Debug.Log("Point : " + -2);
                        TPnt -= 2;
                    }
                    break;
                case 5:
                    if (TPnt >= 3)
                    {
                        Debug.Log("Point : " + -3);
                        TPnt -= 3;
                    }
                    break;
                default:
                    break;
            }
            Debug.Log("TierPoint : " + TPnt);
            PlayerPrefs.SetInt("TierPoint", TPnt);
            TierPoint.text = "ÆÇ³Ú Æ÷ÀÎÆ® : " + TPnt + " / 42";
            transform.position = new Vector3(-3.86f, 2.58f, 0);
            //SceneManager.LoadScene("GameOverSCN");
        }
    }
}
