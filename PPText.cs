using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PPText : MonoBehaviour
{
    public string _name;
    void Update()
    {
        GetComponent<Text>().text=PlayerPrefs.GetInt(_name)+"";
    }
}
