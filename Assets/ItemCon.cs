using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCon : MonoBehaviour
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
                int Num = Random.Range(1, 3);   // 1~2Á¡
                //Debug.Log("¾ÆÀÌÅÛ¹ö¾ï!!");
                Debug.Log(Num + "Á¡È¹µæ!!");
                GameMangerCon.Instance.Get_Score(Num);
                GameMangerCon.Instance.Add_Score(Num);
                GameMangerCon.Instance.Add_MoonCount(1);
                asc.Play();
                GameObject.Destroy(gameObject, 0.1f);
            }
        }
        if (collision.tag == "Player1")
        {
            if (Touch == false)
            {
                Touch = true;
                int Num = Random.Range(2, 6);   // 2~5Á¡
                //Debug.Log("¾ÆÀÌÅÛ¹ö¾ï!!");
                Debug.Log(Num + "Á¡È¹µæ!!");
                GameMangerCon.Instance.Get_Score(Num);
                GameMangerCon.Instance.Add_Score(Num);
                GameMangerCon.Instance.Add_MoonCount(1);
                asc.Play();
                GameObject.Destroy(gameObject, 0.1f);
            }
        }
        if (collision.tag == "Player2")
        {
            if (Touch == false)
            {
                Touch = true;
                int Num = Random.Range(6, 11);  // 6~10Á¡
                //Debug.Log("¾ÆÀÌÅÛ¹ö¾ï!!");
                Debug.Log(Num + "Á¡È¹µæ!!");
                GameMangerCon.Instance.Get_Score(Num);
                GameMangerCon.Instance.Add_Score(Num);
                GameMangerCon.Instance.Add_MoonCount(1);
                asc.Play();
                GameObject.Destroy(gameObject, 0.1f);
            }
        }
        if (collision.tag == "Player3")
        {
            if (Touch == false)
            {
                Touch = true;
                int Num = Random.Range(11, 16);  // 11~15Á¡
                //Debug.Log("¾ÆÀÌÅÛ¹ö¾ï!!");
                Debug.Log(Num + "Á¡È¹µæ!!");
                GameMangerCon.Instance.Get_Score(Num);
                GameMangerCon.Instance.Add_Score(Num);
                GameMangerCon.Instance.Add_MoonCount(1);
                asc.Play();
                GameObject.Destroy(gameObject, 0.1f);
            }
        }
        if (collision.tag == "Player4")
        {
            if (Touch == false)
            {
                Touch = true;
                int Num = Random.Range(16, 21);   // 16~20Á¡
                //Debug.Log("¾ÆÀÌÅÛ¹ö¾ï!!");
                Debug.Log(Num + "Á¡È¹µæ!!");
                GameMangerCon.Instance.Get_Score(Num);
                GameMangerCon.Instance.Add_Score(Num);
                GameMangerCon.Instance.Add_MoonCount(1);
                asc.Play();
                GameObject.Destroy(gameObject, 0.1f);
            }
        }
        if (collision.tag == "Player5")
        {
            if (Touch == false)
            {
                Touch = true;
                int Num = Random.Range(21, 31);   // 21~30Á¡
                //Debug.Log("¾ÆÀÌÅÛ¹ö¾ï!!");
                Debug.Log(Num + "Á¡È¹µæ!!");
                GameMangerCon.Instance.Get_Score(Num);
                GameMangerCon.Instance.Add_Score(Num);
                GameMangerCon.Instance.Add_MoonCount(1);
                asc.Play();
                GameObject.Destroy(gameObject, 0.1f);
            }
        }
    }
}
