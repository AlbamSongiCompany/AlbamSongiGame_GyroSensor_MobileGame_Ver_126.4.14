using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCon : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start=====>");
        PlayerPrefs.SetInt("GameStage", 0);
        PlayerPrefs.SetInt("TierPoint", 0);
        PlayerPrefs.SetInt("RandomNickName", Random.Range(0, 4));
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
