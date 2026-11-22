using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UserManagerCon : MonoBehaviour
{
    //public GameObject warningpanel;
    public GameObject warningtext;
    public TMP_InputField nickname;
    string defaultName;
    //private int randomnick;
    // Start is called before the first frame update
    void Start()
    {
        if (nickname != null)
        {
            if (PlayerPrefs.HasKey("PlayerName"))
            {
                defaultName = PlayerPrefs.GetString("PlayerName");
                nickname.text = defaultName;
            }
        }
    }
    public void Go_GameResipi_New()
    {
        Debug.Log("OnConnect!!");
        SetPlayerName_New(nickname.text);
        //SceneManager.LoadScene("GameResipiSCN");
    }
    public void Go_GameResipi_Original()
    {
        Debug.Log("OnConnect!!");
        SetPlayerName_Original(nickname.text);
        //SceneManager.LoadScene("GameResipiSCN");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetPlayerName_New(string value)
    {
        //randomnick = PlayerPrefs.GetInt("RandomNickName", 0);
        /*if (string.IsNullOrEmpty(value))
        {
            if (randomnick == 0)
            {
                value = "Ghost " + Random.Range(0, 101);
                //return;
            }
            if (randomnick == 1)
            {
                value = "AlbamSonge " + Random.Range(0, 101);
            }
            if (randomnick == 2)
            {
                value = "Horor " + Random.Range(0, 101);
            }
            if (randomnick == 3)
            {
                value = "Yuna " + Random.Range(0, 101);
            }
        }*/
        if (string.IsNullOrEmpty(value))
        {
            OpenWarning("닉네임을 입력하세용!!");
            return;
        }
        else
        {
            PlayerPrefs.SetString("PlayerName", value);
            PlayFabRankingManager.Instance.Login_N(value, "GameResipiSCN", OpenWarning);
        }
    }
    public void SetPlayerName_Original(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            OpenWarning("닉네임을 입력하세용!!");
            return;
        }
        else
        {
            PlayerPrefs.SetString("PlayerName", value);
            PlayFabRankingManager.Instance.Login_O(value, "GameResipiSCN", OpenWarning);
        }
    }
    void OpenWarning(string msg)
    {
        warningtext.GetComponent<Text>().text = msg;
        warningtext.SetActive(true);
        StartCoroutine(WarningTextDelay());
    }
    void CloseWarning()
    {
        warningtext.SetActive(false);
    }
    IEnumerator WarningTextDelay()
    {
        yield return new WaitForSeconds(2.5f);
        warningtext.SetActive(false);
    }
}
