using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Long_Card : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void UI_Card_Click()
    {
        Long_UI_Main oc = GameObject.Find("긴막대_UI 모음").GetComponent<Long_UI_Main>();
        oc.Long_UI_Level = 2;
    }
}
