using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RankPanelCon : MonoBehaviour
{
    public GameObject ranking;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Go_Main_Button()
    {
        ranking.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
         Debug.Log("Ranking");
         ranking.SetActive(true);
    }
}
