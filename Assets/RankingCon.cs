using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RankingCon : MonoBehaviour
{
    public Text[] point;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("RankingCon");
        List<UserScore> top = SaveManager.GetTopScores(10);
        int i = 0;
        foreach (UserScore x in top)
        {
            Debug.Log(x.id + " : " + x.ch + "-" +x.point + " - " + x.tier);
            point[i++].text = i + "µî | " + x.id + " | " + x.ch + " | " + x.point + "/42" + " | " + x.tier;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
