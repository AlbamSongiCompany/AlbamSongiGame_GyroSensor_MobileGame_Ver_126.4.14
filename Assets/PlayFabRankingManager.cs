using PlayFab;
using PlayFab.ClientModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayFabRankingManager : MonoBehaviour
{
    public static PlayFabRankingManager Instance { get; private set; }
    private string cur_nickname;
    private string msg;
    private const string CHAR_NAME = "CharScore";
    private const string STAT_NAME = "HightScore";
    private const string TIER_NAME = "TierScore";
    private const string RANKING_NAME = "RankingData";
    public static int CachedMyScore { get; private set; } = 0;
    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject); // 씬이 바뀌어도 유지하고 싶다면
    }
    public class RankingEntry
    {
        public string playfab_ID;
        public string display_Name;
        public int charpick;
        public int score;
        public int tier;
        public int rank;
    }
    /*public void Login(string nickName)
    {
        cur_nickname = nickName;
        var request = new LoginWithCustomIDRequest
        {
            CustomId = nickName,
            CreateAccount = true
        };
        PlayFabClientAPI.LoginWithCustomID(request, OnLoginSuccess, OnLoginError);
    }*/
    //public void Login_kk(string nickName, string successScene, string failScene)
    public void Login_N(string nickName, string successScene, Action<string> onFail)
    {
        cur_nickname = nickName;
        var request = new LoginWithCustomIDRequest
        {
            CustomId = nickName,
            CreateAccount = true
        };
        //PlayFabClientAPI.LoginWithCustomID(request, OnLoginSuccess1, OnLoginError);
        PlayFabClientAPI.LoginWithCustomID(request,
            result =>
            {
                if (result.NewlyCreated)
                {
                    Debug.Log("왜죠? 왜 신규계정이 생성된거죠? ID : " + result.PlayFabId);
                    SetName(cur_nickname);
                    SceneManager.LoadScene(successScene);
                }
                else
                {
                    PlayFabClientAPI.ForgetAllCredentials();
                    Debug.Log("왜죠? 왜 이미 존재하는 닉넴 인거죠? ID : " + cur_nickname);
                    msg = "이미 닉네임이 있답니다ㅎㅎ.!!";
                    //SceneManager.LoadScene(failScene);
                    onFail?.Invoke(msg);
                }
            },
            error =>
            {
                OnLoginError(error);
                msg = "기달려 주세용.!!";
                //SceneManager.LoadScene(failScene);
                onFail?.Invoke(msg);
            });
    }
    public void Login_O(string nickName, string successScene, Action<string> onFail)
    {
        cur_nickname = nickName;
        var request = new LoginWithCustomIDRequest
        {
            CustomId = nickName,
            CreateAccount = false
        };
        //PlayFabClientAPI.LoginWithCustomID(request, OnLoginSuccess, OnLoginError1);
        PlayFabClientAPI.LoginWithCustomID(request,
            result =>
            {
                Debug.Log("왜죠? 왜 기존계정 로그인 성공인거죠? ID : " + result.PlayFabId);
                SetName(cur_nickname);
                SceneManager.LoadScene(successScene);
            },
            error =>
            {
                if (error.Error == PlayFabErrorCode.AccountNotFound)
                {
                    Debug.Log("왜죠? 왜 닉네임이 존재하지 않죠? ID : " + cur_nickname);
                    msg = "닉네임이 없어요.!!";
                }
                else
                {
                    OnLoginError(error);
                    msg = "기달려 주세용.!!";
                }
                //SceneManager.LoadScene(failScene);
                onFail?.Invoke(msg);
            });
    }
    /*void OnLoginSuccess(LoginResult result)
    {
        Debug.Log("왜죠? 왜 로그인 성공인거죠? ID : " + result.PlayFabId);
        SetName(cur_nickname);
    }
    void OnLoginSuccess1(LoginResult result)
    {
        if (result.NewlyCreated)
        {
            Debug.Log("왜죠? 왜 신규계정이 생성된거죠? ID : " + result.PlayFabId);
            SetName(cur_nickname);
        }
        else
        {
            Debug.Log("왜죠? 왜 이미 존재하는 닉넴 인거죠? ID : " + cur_nickname);
            PlayFabClientAPI.ForgetAllCredentials();
        }
    }*/
    void OnLoginError(PlayFabError error)
    {
        Debug.Log("왜죠? 왜 로그인 실패인거죠? ID : " + error.GenerateErrorReport());
    }
    /*void OnLoginError1(PlayFabError error)
    {
        if (error.Error == PlayFabErrorCode.AccountNotFound)
        {
            Debug.Log("왜죠? 왜 닉네임이 존재하지 않죠? ID : " + cur_nickname);
        }
        else
        {
            OnLoginError(error);
        }
    }*/
    public void SetName(string playername)
    {
        var request = new UpdateUserTitleDisplayNameRequest
        {
            DisplayName = playername
        };
        PlayFabClientAPI.UpdateUserTitleDisplayName(request, OnSetNameSuccess, OnLoginError);
    }
    private void OnSetNameSuccess(UpdateUserTitleDisplayNameResult result)
    {
        Debug.Log("왜죠? 왜 닉네임 저장 성공 인거죠? : " + result.DisplayName);
    }
    public void SubmitScore(int testchar, int testScore, int testtier)
    {
        //int scoreOffset = 9999;
        int rankingValue = (testScore * 100) + (testtier * 10) + testchar;
        var request = new UpdatePlayerStatisticsRequest
        {
            Statistics = new List<StatisticUpdate>
            {
                new StatisticUpdate
                {
                    StatisticName=CHAR_NAME,
                    Value=testchar
                },
                new StatisticUpdate
                {
                    StatisticName=STAT_NAME,
                    Value=testScore
                },
                new StatisticUpdate
                {
                    StatisticName=TIER_NAME,
                    Value=testtier
                },
                new StatisticUpdate
                {
                    StatisticName = RANKING_NAME,
                    Value = rankingValue
                }
            }
        };
        PlayFabClientAPI.UpdatePlayerStatistics(request, OnSendSuccess, OnLoginError);
    }
    private void OnSendSuccess(UpdatePlayerStatisticsResult result)
    {
        Debug.Log("왜죠? 왜 점수 저장 성공인거죠? : ");
    }
    public void GetScore()
    {
        var request = new GetPlayerStatisticsRequest
        {
            StatisticNames = new List<string> { CHAR_NAME, STAT_NAME, TIER_NAME },
        };
        PlayFabClientAPI.GetPlayerStatistics(request, OnGetScoreSuccess, OnLoginError);
    }
    private void OnGetScoreSuccess(GetPlayerStatisticsResult result)
    {
        if (result.Statistics.Count == 0)
        {
            Debug.Log("왜죠? 왜 아직 저장된 통계가 없는거죠?");
            return;
        }
        foreach (StatisticValue stat in result.Statistics)
        {
            Debug.Log("왜죠? 왜 내 점수 조회 해야하는거죠? : " + stat.StatisticName + "=" + stat.Value);
        }
    }
    public void GetTopScore(int count, Action<List<RankingEntry>> onComplete)
    {
        var request = new GetLeaderboardRequest
        {
            StatisticName = RANKING_NAME,
            StartPosition = 0,
            MaxResultsCount = count
        };
        PlayFabClientAPI.GetLeaderboard(request, result =>
        {
            List<RankingEntry> rankingList = new List<RankingEntry>();
            foreach (PlayerLeaderboardEntry entry in result.Leaderboard)
            {
                int rankingValue = entry.StatValue;
                int charpick = rankingValue % 10;
                int tier = (rankingValue / 10) % 10;
                int score = (rankingValue / 100);
                rankingList.Add(new RankingEntry
                {
                    playfab_ID = entry.PlayFabId,
                    display_Name = string.IsNullOrEmpty(entry.DisplayName) ? "머꼬?" : entry.DisplayName,
                    charpick = charpick,
                    score = score,
                    tier = tier,
                    rank = entry.Position + 1
                });
                Debug.Log($"{entry.Position + 1}위 - {entry.StatValue} - {charpick} - {entry.DisplayName} - {score} - {tier}");
            }
            onComplete?.Invoke(rankingList);
        }, OnLoginError);
    }
}
