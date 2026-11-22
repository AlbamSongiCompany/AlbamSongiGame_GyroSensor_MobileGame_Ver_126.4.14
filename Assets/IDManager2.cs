using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class IDManager2 : MonoBehaviour
{
    public TextMesh ID1;
    public TextMesh ID2;
    public TextMesh ID3;
    public TextMesh ID4;
    // Start is called before the first frame update
    void Start()
    {
        ID1.text = PlayerPrefs.GetString("PlayerName");
        ID2.text = PlayerPrefs.GetString("PlayerName");
        ID3.text = PlayerPrefs.GetString("PlayerName");
        ID4.text = PlayerPrefs.GetString("PlayerName");
        ID1.text = ID1.text;
        ID2.text = ID2.text;
        ID3.text = ID3.text;
        ID4.text = ID4.text;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
