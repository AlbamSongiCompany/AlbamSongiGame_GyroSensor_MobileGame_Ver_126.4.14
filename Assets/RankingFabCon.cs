using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RankingFabCon : MonoBehaviour
{
    public Text[] scoreUI;
    // Start is called before the first frame update
    void Start()
    {
        PlayFabRankingManager.Instance.GetTopScore(10, OnScoreLoaded);
    }
    void OnScoreLoaded(List<PlayFabRankingManager.RankingEntry> rankingList)
    {
        int i = 0;
        foreach (var x in rankingList)
        {
            if (i >= scoreUI.Length)
            {
                break;
            }
            if(x.charpick == 1)
            {
                if (x.tier == 1)
                {
                    scoreUI[i].text = (i + 1) + "등   " + x.display_Name + "   " + "송이" + "   " + x.score + "/42" + "   " + "나무";
                    i++;
                }
                if (x.tier == 2)
                {
                    scoreUI[i].text = (i + 1) + "등   " + x.display_Name + "   " + "송이" + "   " + x.score + "/42" + "   " + "유리";
                    i++;
                }
                if (x.tier == 3)
                {
                    scoreUI[i].text = (i + 1) + "등   " + x.display_Name + "   " + "송이" + "   " + x.score + "/42" + "   " + "돌";
                    i++;
                }
                if (x.tier == 4)
                {
                    scoreUI[i].text = (i + 1) + "등   " + x.display_Name + "   " + "송이" + "   " + x.score + "/42" + "   " + "청동";
                    i++;
                }
                if (x.tier == 5)
                {
                    scoreUI[i].text = (i + 1) + "등   " + x.display_Name + "   " + "송이" + "   " + x.score + "/42" + "   " + "은";
                    i++;
                }
                if (x.tier == 6)
                {
                    scoreUI[i].text = (i + 1) + "등   " + x.display_Name + "   " + "송이" + "   " + x.score + "/42" + "   " + "금";
                    i++;
                }
                if (x.tier == 7)
                {
                    scoreUI[i].text = (i + 1) + "등   " + x.display_Name + "   " + "송이" + "   " + x.score + "/42" + "   " + "보석";
                    i++;
                }
            }
            if (x.charpick == 2)
            {
                if (x.tier == 1)
                {
                    scoreUI[i].text = (i + 1) + "등   " + x.display_Name + "   " + "알밤" + "   " + x.score + "/42" + "   " + "나무";
                    i++;
                }
                if (x.tier == 2)
                {
                    scoreUI[i].text = (i + 1) + "등   " + x.display_Name + "   " + "알밤" + "   " + x.score + "/42" + "   " + "유리";
                    i++;
                }
                if (x.tier == 3)
                {
                    scoreUI[i].text = (i + 1) + "등   " + x.display_Name + "   " + "알밤" + "   " + x.score + "/42" + "   " + "돌";
                    i++;
                }
                if (x.tier == 4)
                {
                    scoreUI[i].text = (i + 1) + "등   " + x.display_Name + "   " + "알밤" + "   " + x.score + "/42" + "   " + "청동";
                    i++;
                }
                if (x.tier == 5)
                {
                    scoreUI[i].text = (i + 1) + "등   " + x.display_Name + "   " + "알밤" + "   " + x.score + "/42" + "   " + "은";
                    i++;
                }
                if (x.tier == 6)
                {
                    scoreUI[i].text = (i + 1) + "등   " + x.display_Name + "   " + "알밤" + "   " + x.score + "/42" + "   " + "금";
                    i++;
                }
                if (x.tier == 7)
                {
                    scoreUI[i].text = (i + 1) + "등   " + x.display_Name + "   " + "알밤" + "   " + x.score + "/42" + "   " + "보석";
                    i++;
                }
            }
            if (x.charpick == 3)
            {
                if (x.tier == 1)
                {
                    scoreUI[i].text = (i + 1) + "등   " + x.display_Name + "   " + "고양이" + "   " + x.score + "/42" + "   " + "나무";
                    i++;
                }
                if (x.tier == 2)
                {
                    scoreUI[i].text = (i + 1) + "등   " + x.display_Name + "   " + "고양이" + "   " + x.score + "/42" + "   " + "유리";
                    i++;
                }
                if (x.tier == 3)
                {
                    scoreUI[i].text = (i + 1) + "등   " + x.display_Name + "   " + "고양이" + "   " + x.score + "/42" + "   " + "돌";
                    i++;
                }
                if (x.tier == 4)
                {
                    scoreUI[i].text = (i + 1) + "등   " + x.display_Name + "   " + "고양이" + "   " + x.score + "/42" + "   " + "청동";
                    i++;
                }
                if (x.tier == 5)
                {
                    scoreUI[i].text = (i + 1) + "등   " + x.display_Name + "   " + "고양이" + "   " + x.score + "/42" + "   " + "은";
                    i++;
                }
                if (x.tier == 6)
                {
                    scoreUI[i].text = (i + 1) + "등   " + x.display_Name + "   " + "고양이" + "   " + x.score + "/42" + "   " + "금";
                    i++;
                }
                if (x.tier == 7)
                {
                    scoreUI[i].text = (i + 1) + "등   " + x.display_Name + "   " + "고양이" + "   " + x.score + "/42" + "   " + "보석";
                    i++;
                }
            }
            if (x.charpick == 4)
            {
                if (x.tier == 1)
                {
                    scoreUI[i].text = (i + 1) + "등   " + x.display_Name + "   " + "아기달님" + "   " + x.score + "/42" + "   " + "나무";
                    i++;
                }
                if (x.tier == 2)
                {
                    scoreUI[i].text = (i + 1) + "등   " + x.display_Name + "   " + "아기달님" + "   " + x.score + "/42" + "   " + "유리";
                    i++;
                }
                if (x.tier == 3)
                {
                    scoreUI[i].text = (i + 1) + "등   " + x.display_Name + "   " + "아기달님" + "   " + x.score + "/42" + "   " + "돌";
                    i++;
                }
                if (x.tier == 4)
                {
                    scoreUI[i].text = (i + 1) + "등   " + x.display_Name + "   " + "아기달님" + "   " + x.score + "/42" + "   " + "청동";
                    i++;
                }
                if (x.tier == 5)
                {
                    scoreUI[i].text = (i + 1) + "등   " + x.display_Name + "   " + "아기달님" + "   " + x.score + "/42" + "   " + "은";
                    i++;
                }
                if (x.tier == 6)
                {
                    scoreUI[i].text = (i + 1) + "등   " + x.display_Name + "   " + "아기달님" + "   " + x.score + "/42" + "   " + "금";
                    i++;
                }
                if (x.tier == 7)
                {
                    scoreUI[i].text = (i + 1) + "등   " + x.display_Name + "   " + "아기달님" + "   " + x.score + "/42" + "   " + "보석";
                    i++;
                }
            }
        }
    }
}
