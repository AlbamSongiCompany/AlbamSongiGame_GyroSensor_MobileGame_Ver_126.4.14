using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinshCon : MonoBehaviour
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
            int Pnt1 = PlayerPrefs.GetInt("Score", 0);
            int TPnt = PlayerPrefs.GetInt("TierPoint", 0);
            if (Pnt1 >= 0 && Pnt1 <= 4221)
            {
                Debug.Log("Point : " + 1);
                TPnt += 1;
            }
            if (Pnt1 >= 4222 && Pnt1 <= 8456)
            {
                Debug.Log("Point : " + 2);
                TPnt += 2;
            }
            if (Pnt1 >= 8457 && Pnt1 <= 9308)
            {
                Debug.Log("Point : " + 3);
                TPnt += 3;
            }
            if (Pnt1 >= 9309 && Pnt1 <= 10170)
            {
                Debug.Log("Point : " + 4);
                TPnt += 4;
            }
            if (Pnt1 >= 10171 && Pnt1 <= 12218)
            {
                Debug.Log("Point : " + 5);
                TPnt += 5;
            }
            if (Pnt1 >= 12219 && Pnt1 <= 14311)
            {
                Debug.Log("Point : " + 6);
                TPnt += 6;
            }
            if (Pnt1 >= 14312 && Pnt1 <= 18680)
            {
                Debug.Log("Point : " + 7);
                TPnt += 7;
            }
            Debug.Log("Clear ====> Stage 5");
            Debug.Log("Score : " + Pnt1);
            Debug.Log("TierPoint : " + TPnt);
            PlayerPrefs.SetInt("TierPoint", TPnt);
            SceneManager.LoadScene("FinshSCN");
        }
    }
}
