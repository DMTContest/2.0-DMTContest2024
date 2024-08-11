using System.Collections;
using System.Collections.Generic;
using TMPro;
using System;
using UnityEngine.UI;
using System.Data;
using UnityEngine;

public class FinalClass : MonoBehaviour
{   
    [SerializeField]private Text JS;
    [SerializeField]private Text MS;
    [SerializeField]private Text HS;
    [SerializeField]private Text JR;
    [SerializeField]private Text JW;
    [SerializeField]private Text MR;
    [SerializeField]private Text MW;
    [SerializeField]private Text HR;
    [SerializeField]private Text HW;
    [SerializeField]private Text GameDateNow;
    [SerializeField]private Text FinalScore;


    // Start is called before the first frame update
    void Start()
    {
        JS.text = "+"+(AG2Instance.Jcorrect*10 - (AG2Instance.JWR1 +AG2Instance.JWR2 +AG2Instance.JWR3)*4).ToString();
        MS.text = "+"+(AG2Instance.Mcorrect*10 - (AG2Instance.MWR1 +AG2Instance.MWR2 +AG2Instance.MWR3)*6).ToString();
        HS.text = "+"+(AG2Instance.Hcorrect*10 - (AG2Instance.HWR1 +AG2Instance.HWR2 +AG2Instance.HWR3 + AG2Instance.HWR3)*8).ToString();
        JR.text = AG2Instance.Jcorrect.ToString();
        MR.text = AG2Instance.Mcorrect.ToString();
        HR.text = AG2Instance.Hcorrect.ToString();  
        JW.text = (AG2Instance.JWR1+AG2Instance.JWR2+AG2Instance.JWR3).ToString();
        MW.text = (AG2Instance.MWR1+AG2Instance.MWR2+AG2Instance.MWR3).ToString();
        HW.text = (AG2Instance.HWR1+AG2Instance.HWR2+AG2Instance.HWR3+AG2Instance.HWR4).ToString();  
        GameDateNow.text = DateTime.Now.ToString();
        FinalScore.text = 
        (AG2Instance.Jcorrect*10 - (AG2Instance.JWR1+AG2Instance.JWR2+AG2Instance.JWR3)*4+ AG2Instance.Mcorrect*10 - (AG2Instance.MWR1+AG2Instance.MWR2+AG2Instance.MWR3)*6+ AG2Instance.Hcorrect*10 - (AG2Instance.HWR1+AG2Instance.HWR2+AG2Instance.HWR3+AG2Instance.HWR4)*8).ToString();
    }   

    // Update is called once per frame
    void Update()
    {
        
    }
}
