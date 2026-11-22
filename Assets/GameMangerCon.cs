using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;

public class GameMangerCon : MonoBehaviour
{
    public static GameMangerCon Instance { get; private set; }
    public Text Score;
    public Text MoonCount;
    public Text StarCount;
    public Text TierPoint;
    public Text GetScore;
    private int Point = 0;
    private int Mcnt = 0;
    private int Scnt = 0;
    private int TPnt = 0;
    private int GPnt = 0;
    private int Cur_Stage;
    private int RankCharacterNum;
    private string RankCharacter;
    private int RankPoint;
    private string RankTier;
    private string defaultName;
    private int RankTierScore;
    private void Awake()
    {
        if(Instance!=null && Instance != this)
        {
            return;
        }
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        TPnt = PlayerPrefs.GetInt("TierPoint", 0);
        Cur_Stage = PlayerPrefs.GetInt("GameStage", 0);
        TierPoint.text = "판넬 포인트 : " + TPnt + " / 42";
        switch (Cur_Stage)
        {
            case 0:
                MoonCount.text = "~/3";
                StarCount.text = "~/1";
                break;
            case 1:
                MoonCount.text = "~/4";
                StarCount.text = "~/4";
                break;
            case 2:
                MoonCount.text = "~/10";
                StarCount.text = "~/6";
                break;
            case 3:
                MoonCount.text = "~/24";
                StarCount.text = "~/9";
                break;
            case 4:
                MoonCount.text = "~/63";
                StarCount.text = "~/23";
                break;
            case 5:
                MoonCount.text = "~/106";
                StarCount.text = "~/31";
                break;
            default:
                MoonCount.text = "~/3";
                StarCount.text = "~/1";
                break;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    /*public void Go_Restart()
    {
        PlayerPrefs.SetInt("GameStage", 0);
        Debug.Log("Stage : 0");
        SceneManager.LoadScene("GameSCNStage0");
    }*/
    public void Game_Exit()
    {
        Debug.Log("꼬시다 맛동산~~");
        Application.Quit();
    }
    public void Game_Exit_Save()
    {
        Debug.Log("꼬시다 맛동산~~");
        //defaultName = PlayerPrefs.GetString("PlayerName");
        RankCharacterNum = PlayerPrefs.GetInt("Charactor", 0);
        RankPoint = PlayerPrefs.GetInt("TierPoint", 0);
        /*if (RankCharacterNum == 1)
        {
            RankCharacter = "송이";
        }
        if (RankCharacterNum == 2)
        {
            RankCharacter = "알밤";
        }
        if (RankCharacterNum == 3)
        {
            RankCharacter = "고양이";
        }
        if (RankCharacterNum == 4)
        {
            RankCharacter = "아기달님";
        }*/

        if (RankPoint <= 9)
        {
            //RankTier = "나무";
            RankTierScore = 1;
        }
        if (RankPoint >= 10 && RankPoint <= 15)
        {
            //RankTier = "유리";
            RankTierScore = 2;
        }
        if (RankPoint >= 16 && RankPoint <= 21)
        {
            //RankTier = "돌";
            RankTierScore = 3;
        }
        if (RankPoint >= 22 && RankPoint <= 27)
        {
            //RankTier = "청동";
            RankTierScore = 4;
        }
        if (RankPoint >= 28 && RankPoint <= 33)
        {
            //RankTier = "은";
            RankTierScore = 5;
        }
        if (RankPoint >= 34 && RankPoint <= 39)
        {
            //RankTier = "금";
            RankTierScore = 6;
        }
        if (RankPoint >= 40 && RankPoint <= 42)
        {
            //RankTier = "보석";
            RankTierScore = 7;
        }
        //SaveManager.SetScore(defaultName, RankCharacter, RankPoint, RankTier);
        PlayFabRankingManager.Instance.SubmitScore(RankCharacterNum, RankPoint, RankTierScore);
        Application.Quit();
    }
    public void Go_Pick()
    {
        PlayerPrefs.SetInt("GameStage", 0);
        SceneManager.LoadScene("CharacterPickSCN");
    }
    public void Go_Pick_Save()
    {
        PlayerPrefs.SetInt("GameStage", 0);
        //defaultName = PlayerPrefs.GetString("PlayerName");
        RankCharacterNum = PlayerPrefs.GetInt("Charactor", 0);
        RankPoint = PlayerPrefs.GetInt("TierPoint", 0);
        /*if (RankCharacterNum == 1)
        {
            RankCharacter = "송이";
        }
        if (RankCharacterNum == 2)
        {
            RankCharacter = "알밤";
        }
        if (RankCharacterNum == 3)
        {
            RankCharacter = "고양이";
        }
        if (RankCharacterNum == 4)
        {
            RankCharacter = "아기달님";
        }*/

        if (RankPoint <= 9)
        {
            //RankTier = "나무";
            RankTierScore = 1;
        }
        if (RankPoint >= 10 && RankPoint <= 15)
        {
            //RankTier = "유리";
            RankTierScore = 2;
        }
        if (RankPoint >= 16 && RankPoint <= 21)
        {
            //RankTier = "돌";
            RankTierScore = 3;
        }
        if (RankPoint >= 22 && RankPoint <= 27)
        {
            //RankTier = "청동";
            RankTierScore = 4;
        }
        if (RankPoint >= 28 && RankPoint <= 33)
        {
            //RankTier = "은";
            RankTierScore = 5;
        }
        if (RankPoint >= 34 && RankPoint <= 39)
        {
            //RankTier = "금";
            RankTierScore = 6;
        }
        if (RankPoint >= 40 && RankPoint <= 42)
        {
            //RankTier = "보석";
            RankTierScore = 7;
        }
        //SaveManager.SetScore(defaultName, RankCharacter, RankPoint, RankTier);
        PlayFabRankingManager.Instance.SubmitScore(RankCharacterNum, RankPoint, RankTierScore);
        SceneManager.LoadScene("CharacterPickSCN");
    }
    public void Go_Login()
    {
        SceneManager.LoadScene("LoginSCN");
    }
    public void Go_GameResipi()
    {
        SceneManager.LoadScene("GameResipiSCN");
    }
    public void Go_ControllResipi()
    {
        SceneManager.LoadScene("ControllResipiSCN");
    }
    public void Go_TierResipi()
    {
        SceneManager.LoadScene("TierResipiSCN");
    }
    public void Go_Menu()
    {
        SceneManager.LoadScene("MenuSCN");
    }
    public void Go_MainScene()
    {
        int Reset = 0;
        Score.text = "점수 : " + Reset;
        MoonCount.text = " : " + Reset;
        StarCount.text = " : " + Reset;
        TPnt = PlayerPrefs.GetInt("TierPoint", 0);
        if (TPnt > 0)
        {
            TPnt -= 1;
        }
        PlayerPrefs.SetInt("TierPoint", TPnt);
        Debug.Log("웰컴투 쥬만지!! : " + TPnt);
        SceneManager.LoadScene("MainScene");
    }
    public void Add_Score(int Val)
    {
        Point += Val;
        Score.text = "점수 : " + Point;
        PlayerPrefs.SetInt("Score", Point);
    }
    public void Add_MoonCount(int val1)
    {
        Mcnt += val1;
        MoonCount.text = " : " + Mcnt;
    }
    public void Add_StarCount(int val2)
    {
        Scnt += val2;
        StarCount.text = " : " + Scnt;
    }
    public void Add_TierPoint(int val3)
    {
        TPnt += val3;
        TierPoint.text = "판넬 포인트 : " + TPnt;
    }
    public void Get_Score(int val4)
    {
        GPnt = val4;
        GetScore.text = "+" + GPnt + "점!!";
    }
    public void Goto_Stage()
    {
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
