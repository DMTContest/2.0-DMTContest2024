using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTransBack : MonoBehaviour
{
[SerializeField]private Text RecordScore;

    void Start()
    {
        RecordScore.text = "得分：" + AG2Instance.RecordScore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
