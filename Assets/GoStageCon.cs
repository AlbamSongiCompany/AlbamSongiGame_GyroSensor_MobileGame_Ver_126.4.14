using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class GoStageCon : MonoBehaviour
{
    private int Cur_Stage;
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
            Cur_Stage = PlayerPrefs.GetInt("GameStage", 0);
            Debug.Log("Stage : " + Cur_Stage);
            switch (Cur_Stage)
            {
                case 0:
                    SceneManager.LoadScene("GameSCNStage0");
                    break;
                case 1:
                    SceneManager.LoadScene("GameSCNStage1");
                    break;
                case 2:
                    SceneManager.LoadScene("GameSCNStage2");
                    break;
                case 3:
                    SceneManager.LoadScene("GameSCNStage3");
                    break;
                case 4:
                    SceneManager.LoadScene("GameSCNStage4");
                    break;
                case 5:
                    SceneManager.LoadScene("GameSCNStage5");
                    break;
                default:
                    SceneManager.LoadScene("GameSCNStage0");
                    break;
            }
        }
    }
}
