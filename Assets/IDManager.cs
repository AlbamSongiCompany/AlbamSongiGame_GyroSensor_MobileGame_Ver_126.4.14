using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IDManager : MonoBehaviour
{
    public Text nickname;
    // Start is called before the first frame update
    void Start()
    {
        nickname.text = PlayerPrefs.GetString("PlayerName");
        nickname.text = "¿Ã∏ß : " + nickname.text;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
