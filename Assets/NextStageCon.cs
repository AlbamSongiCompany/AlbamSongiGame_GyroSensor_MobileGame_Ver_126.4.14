using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextStageCon : MonoBehaviour
{
    private bool Touch = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Touch == false)
        {
            Touch = true;
            //Debug.Log("¼º°ø");
            int Cur_Stage = PlayerPrefs.GetInt("GameStage", 0);
            int Pnt = PlayerPrefs.GetInt("Score", 0);
            int TPnt = PlayerPrefs.GetInt("TierPoint", 0);
            Cur_Stage++;
            switch (Cur_Stage-1)
            {
                case 0:
                    if (Pnt >= 0 && Pnt <= 2)
                    {
                        Debug.Log("Point : " + 1);
                        TPnt += 1;
                    }
                    if (Pnt >= 3 && Pnt <= 5)
                    {
                        Debug.Log("Point : " + 2);
                        TPnt += 2;
                    }
                    if (Pnt >= 6 && Pnt <= 7)
                    {
                        Debug.Log("Point : " + 3);
                        TPnt += 3;
                    }
                    if (Pnt >= 8 && Pnt <= 9)
                    {
                        Debug.Log("Point : " + 4);
                        TPnt += 4;
                    }
                    if (Pnt >= 10 && Pnt <= 11)
                    {
                        Debug.Log("Point : " + 5);
                        TPnt += 5;
                    }
                    if (Pnt >= 12 && Pnt <= 13)
                    {
                        Debug.Log("Point : " + 6);
                        TPnt += 6;
                    }
                    if (Pnt >= 14 && Pnt <= 16)
                    {
                        Debug.Log("Point : " + 7);
                        TPnt += 7;
                    }
                    break;
                case 1:
                    if (Pnt >= 0 && Pnt <= 23)
                    {
                        Debug.Log("Point : " + 1);
                        TPnt += 1;
                    }
                    if (Pnt >= 24 && Pnt <= 47)
                    {
                        Debug.Log("Point : " + 2);
                        TPnt += 2;
                    }
                    if (Pnt >= 48 && Pnt <= 54)
                    {
                        Debug.Log("Point : " + 3);
                        TPnt += 3;
                    }
                    if (Pnt >= 55 && Pnt <= 62)
                    {
                        Debug.Log("Point : " + 4);
                        TPnt += 4;
                    }
                    if (Pnt >= 63 && Pnt <= 71)
                    {
                        Debug.Log("Point : " + 5);
                        TPnt += 5;
                    }
                    if (Pnt >= 72 && Pnt <= 80)
                    {
                        Debug.Log("Point : " + 6);
                        TPnt += 6;
                    }
                    if (Pnt >= 81 && Pnt <= 100)
                    {
                        Debug.Log("Point : " + 7);
                        TPnt += 7;
                    }
                    break;
                case 2:
                    if (Pnt >= 0 && Pnt <= 92)
                    {
                        Debug.Log("Point : " + 1);
                        TPnt += 1;
                    }
                    if (Pnt >= 93 && Pnt <= 185)
                    {
                        Debug.Log("Point : " + 2);
                        TPnt += 2;
                    }
                    if (Pnt >= 186 && Pnt <= 211)
                    {
                        Debug.Log("Point : " + 3);
                        TPnt += 3;
                    }
                    if (Pnt >= 212 && Pnt <= 238)
                    {
                        Debug.Log("Point : " + 4);
                        TPnt += 4;
                    }
                    if (Pnt >= 239 && Pnt <= 277)
                    {
                        Debug.Log("Point : " + 5);
                        TPnt += 5;
                    }
                    if (Pnt >= 278 && Pnt <= 319)
                    {
                        Debug.Log("Point : " + 6);
                        TPnt += 6;
                    }
                    if (Pnt >= 320 && Pnt <= 400)
                    {
                        Debug.Log("Point : " + 7);
                        TPnt += 7;
                    }
                    break;
                case 3:
                    if (Pnt >= 0 && Pnt <= 361)
                    {
                        Debug.Log("Point : " + 1);
                        TPnt += 1;
                    }
                    if (Pnt >= 362 && Pnt <= 722)
                    {
                        Debug.Log("Point : " + 2);
                        TPnt += 2;
                    }
                    if (Pnt >= 723 && Pnt <= 808)
                    {
                        Debug.Log("Point : " + 3);
                        TPnt += 3;
                    }
                    if (Pnt >= 809 && Pnt <= 894)
                    {
                        Debug.Log("Point : " + 4);
                        TPnt += 4;
                    }
                    if (Pnt >= 895 && Pnt <= 983)
                    {
                        Debug.Log("Point : " + 5);
                        TPnt += 5;
                    }
                    if (Pnt >= 984 && Pnt <= 1077)
                    {
                        Debug.Log("Point : " + 6);
                        TPnt += 6;
                    }
                    if (Pnt >= 1078 && Pnt <= 1260)
                    {
                        Debug.Log("Point : " + 7);
                        TPnt += 7;
                    }
                    break;
                case 4:
                    if (Pnt >= 0 && Pnt <= 1663)
                    {
                        Debug.Log("Point : " + 1);
                        TPnt += 1;
                    }
                    if (Pnt >= 1664 && Pnt <= 3330)
                    {
                        Debug.Log("Point : " + 2);
                        TPnt += 2;
                    }
                    if (Pnt >= 3331 && Pnt <= 3476)
                    {
                        Debug.Log("Point : " + 3);
                        TPnt += 3;
                    }
                    if (Pnt >= 3477 && Pnt <= 3680)
                    {
                        Debug.Log("Point : " + 4);
                        TPnt += 4;
                    }
                    if (Pnt >= 3681 && Pnt <= 3982)
                    {
                        Debug.Log("Point : " + 5);
                        TPnt += 5;
                    }
                    if (Pnt >= 3983 && Pnt <= 4604)
                    {
                        Debug.Log("Point : " + 6);
                        TPnt += 6;
                    }
                    if (Pnt >= 4605 && Pnt <= 5860)
                    {
                        Debug.Log("Point : " + 7);
                        TPnt += 7;
                    }
                    break;
            }
            Debug.Log("Clear ====> Stage " + (Cur_Stage-1));
            Debug.Log("Score : " +Pnt);
            Debug.Log("TierPoint : " + TPnt);
            PlayerPrefs.SetInt("GameStage", Cur_Stage);
            PlayerPrefs.SetInt("TierPoint", TPnt);
            SceneManager.LoadScene("NextStageSCN");
        }
    }
}
