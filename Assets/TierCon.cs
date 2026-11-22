using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TierCon : MonoBehaviour
{
    public Text Tier;
    public GameObject char1wd;
    public GameObject char1gls;
    public GameObject char1stn;
    public GameObject char1brz;
    public GameObject char1svr;
    public GameObject char1gd;
    public GameObject char1da;
    public GameObject char2wd;
    public GameObject char2gls;
    public GameObject char2stn;
    public GameObject char2brz;
    public GameObject char2svr;
    public GameObject char2gd;
    public GameObject char2da;
    public GameObject char3wd;
    public GameObject char3gls;
    public GameObject char3stn;
    public GameObject char3brz;
    public GameObject char3svr;
    public GameObject char3gd;
    public GameObject char3da;
    public GameObject char4wd;
    public GameObject char4gls;
    public GameObject char4stn;
    public GameObject char4brz;
    public GameObject char4svr;
    public GameObject char4gd;
    public GameObject char4da;
    private int mode;
    // Start is called before the first frame update
    void Start()
    {
        mode = PlayerPrefs.GetInt("Charactor", 0);
        int TPnt2 = PlayerPrefs.GetInt("TierPoint", 0);
        if (mode == 1)
        {
            if (TPnt2 <= 9)
            {
                char1wd.SetActive(true);
            }
            if (TPnt2 >= 10 && TPnt2 <= 15)
            {
                char1gls.SetActive(true);
            }
            if (TPnt2 >= 16 && TPnt2 <= 21)
            {
                char1stn.SetActive(true);
            }
            if (TPnt2 >= 22 && TPnt2 <= 27)
            {
                char1brz.SetActive(true);
            }
            if (TPnt2 >= 28 && TPnt2 <= 33)
            {
                char1svr.SetActive(true);
            }
            if (TPnt2 >= 34 && TPnt2 <= 39)
            {
                char1gd.SetActive(true);
            }
            if (TPnt2 >= 40 && TPnt2 <= 42)
            {
                char1da.SetActive(true);
            }
        }
        if (mode == 2)
        {
            if (TPnt2 <= 9)
            {
                char2wd.SetActive(true);
            }
            if (TPnt2 >= 10 && TPnt2 <= 15)
            {
                char2gls.SetActive(true);
            }
            if (TPnt2 >= 16 && TPnt2 <= 21)
            {
                char2stn.SetActive(true);
            }
            if (TPnt2 >= 22 && TPnt2 <= 27)
            {
                char2brz.SetActive(true);
            }
            if (TPnt2 >= 28 && TPnt2 <= 33)
            {
                char2svr.SetActive(true);
            }
            if (TPnt2 >= 34 && TPnt2 <= 39)
            {
                char2gd.SetActive(true);
            }
            if (TPnt2 >= 40 && TPnt2 <= 42)
            {
                char2da.SetActive(true);
            }
        }
        if (mode == 3)
        {
            if (TPnt2 <= 9)
            {
                char3wd.SetActive(true);
            }
            if (TPnt2 >= 10 && TPnt2 <= 15)
            {
                char3gls.SetActive(true);
            }
            if (TPnt2 >= 16 && TPnt2 <= 21)
            {
                char3stn.SetActive(true);
            }
            if (TPnt2 >= 22 && TPnt2 <= 27)
            {
                char3brz.SetActive(true);
            }
            if (TPnt2 >= 28 && TPnt2 <= 33)
            {
                char3svr.SetActive(true);
            }
            if (TPnt2 >= 34 && TPnt2 <= 39)
            {
                char3gd.SetActive(true);
            }
            if (TPnt2 >= 40 && TPnt2 <= 42)
            {
                char3da.SetActive(true);
            }
        }
        if (mode == 4)
        {
            if (TPnt2 <= 9)
            {
                char4wd.SetActive(true);
            }
            if (TPnt2 >= 10 && TPnt2 <= 15)
            {
                char4gls.SetActive(true);
            }
            if (TPnt2 >= 16 && TPnt2 <= 21)
            {
                char4stn.SetActive(true);
            }
            if (TPnt2 >= 22 && TPnt2 <= 27)
            {
                char4brz.SetActive(true);
            }
            if (TPnt2 >= 28 && TPnt2 <= 33)
            {
                char4svr.SetActive(true);
            }
            if (TPnt2 >= 34 && TPnt2 <= 39)
            {
                char4gd.SetActive(true);
            }
            if (TPnt2 >= 40 && TPnt2 <= 42)
            {
                char4da.SetActive(true);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        int TPnt1 = PlayerPrefs.GetInt("TierPoint", 0);
        if (TPnt1 <= 9)
        {
            Tier.text = "³ª¹«ÆÇ³Ú";
        }
        if (TPnt1 >= 10 && TPnt1 <= 15)
        {
            Tier.text = "À¯¸®ÆÇ³Ú";
        }
        if (TPnt1 >= 16 && TPnt1 <= 21)
        {
            Tier.text = "µ¹ÆÇ³Ú";
        }
        if (TPnt1 >= 22 && TPnt1 <= 27)
        {
            Tier.text = "Ã»µ¿ÆÇ³Ú";
        }
        if (TPnt1 >= 28 && TPnt1 <= 33)
        {
            Tier.text = "ÀºÆÇ³Ú";
        }
        if (TPnt1 >= 34 && TPnt1 <= 39)
        {
            Tier.text = "±ÝÆÇ³Ú";
        }
        if (TPnt1 >= 40 && TPnt1 <= 42)
        {
            Tier.text = "º¸¼®ÆÇ³Ú";
        }
    }
}
