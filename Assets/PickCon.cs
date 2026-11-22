using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PickCon : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void Character1()
    {
        Debug.Log("송이");
        PlayerPrefs.SetInt("Charactor", 1);
        SceneManager.LoadScene("MainScene");
    }
    public void Character2()
    {
        Debug.Log("알밤");
        PlayerPrefs.SetInt("Charactor", 2);
        SceneManager.LoadScene("MainScene");
    }
    public void Character3()
    {
        Debug.Log("고양이");
        PlayerPrefs.SetInt("Charactor", 3);
        SceneManager.LoadScene("MainScene");
    }
    public void Character4()
    {
        Debug.Log("아기달님");
        PlayerPrefs.SetInt("Charactor", 4);
        SceneManager.LoadScene("MainScene");
    }
}
