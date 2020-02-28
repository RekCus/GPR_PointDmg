using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    Text txt;
    public Health health;

    void Start()
    {
        txt = GetComponent<Text>() as Text;
        txt.text = "HP : " + health.hp.ToString();
    }

    public void Change()
    {
        txt.text = "HP : " + health.hp.ToString();
        Debug.Log(health.hp);
    }
}
