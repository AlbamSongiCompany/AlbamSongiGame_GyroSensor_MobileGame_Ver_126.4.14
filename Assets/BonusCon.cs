using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusCon : MonoBehaviour
{
    AudioSource asc;
    private bool Touch = false;
    // Start is called before the first frame update
    void Start()
    {
        asc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (Touch == false)
            {
                Touch = true;
                int Num = Random.Range(3, 11);   // 3~10Á¡
                //Debug.Log("¾ÆÀÌÅÛ¹ö¾ï!!");
                Debug.Log(Num + "Á¡È¹µæ!!");
                GameMangerCon.Instance.Get_Score(Num);
                GameMangerCon.Instance.Add_Score(Num);
                GameMangerCon.Instance.Add_StarCount(1);
                asc.Play();
                GameObject.Destroy(gameObject, 0.1f);
            }
        }
        if (collision.tag == "Player1")
        {
            if (Touch == false)
            {
                Touch = true;
                int Num = Random.Range(10, 21);   // 10~20Á¡
                //Debug.Log("¾ÆÀÌÅÛ¹ö¾ï!!");
                Debug.Log(Num + "Á¡È¹µæ!!");
                GameMangerCon.Instance.Get_Score(Num);
                GameMangerCon.Instance.Add_Score(Num);
                GameMangerCon.Instance.Add_StarCount(1);
                asc.Play();
                GameObject.Destroy(gameObject, 0.1f);
            }
        }
        if (collision.tag == "Player2")
        {
            if (Touch == false)
            {
                Touch = true;
                int Num = Random.Range(21, 51);   // 21~50Á¡
                //Debug.Log("¾ÆÀÌÅÛ¹ö¾ï!!");
                Debug.Log(Num + "Á¡È¹µæ!!");
                GameMangerCon.Instance.Get_Score(Num);
                GameMangerCon.Instance.Add_Score(Num);
                GameMangerCon.Instance.Add_StarCount(1);
                asc.Play();
                GameObject.Destroy(gameObject, 0.1f);
            }
        }
        if (collision.tag == "Player3")
        {
            if (Touch == false)
            {
                Touch = true;
                int Num = Random.Range(51, 101);   // 51~100Á¡
                //Debug.Log("¾ÆÀÌÅÛ¹ö¾ï!!");
                Debug.Log(Num + "Á¡È¹µæ!!");
                GameMangerCon.Instance.Get_Score(Num);
                GameMangerCon.Instance.Add_Score(Num);
                GameMangerCon.Instance.Add_StarCount(1);
                asc.Play();
                GameObject.Destroy(gameObject, 0.1f);
            }
        }
        if (collision.tag == "Player4")
        {
            if (Touch == false)
            {
                Touch = true;
                int Num = Random.Range(101, 201);   // 101~200Á¡
                //Debug.Log("¾ÆÀÌÅÛ¹ö¾ï!!");
                Debug.Log(Num + "Á¡È¹µæ!!");
                GameMangerCon.Instance.Get_Score(Num);
                GameMangerCon.Instance.Add_Score(Num);
                GameMangerCon.Instance.Add_StarCount(1);
                asc.Play();
                GameObject.Destroy(gameObject, 0.1f);
            }
        }
        if (collision.tag == "Player5")
        {
            if (Touch == false)
            {
                Touch = true;
                int Num = Random.Range(201, 501);   // 201~500Á¡
                //Debug.Log("¾ÆÀÌÅÛ¹ö¾ï!!");
                Debug.Log(Num + "Á¡È¹µæ!!");
                GameMangerCon.Instance.Get_Score(Num);
                GameMangerCon.Instance.Add_Score(Num);
                GameMangerCon.Instance.Add_StarCount(1);
                asc.Play();
                GameObject.Destroy(gameObject, 0.1f);
            }
        }
    }
}
