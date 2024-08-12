using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class YindaoMain : PanelManager
{
    
    private int clickCount;
    [SerializeField ] GameObject Panel1;
    [SerializeField ] GameObject Panel2;
    [SerializeField ] GameObject Panel3;


    void Start()
    {
        Panel1.SetActive(false);
        Panel2.SetActive(false);
        Panel3.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0)) // 检查左键点击
        {
        clickCount++; // 增加点击计数器
        if(clickCount==1){
            OpenPanel(Panel1);
        }else if(clickCount==2){
            OpenPanel(Panel1);
            OpenPanel(Panel2);
        }else if(clickCount==2){
            OpenPanel(Panel2);
            OpenPanel(Panel3);
        }else if(clickCount==3){
            OpenPanel(Panel3);

        }
        }
    }

    public void GoToYindaoDigitWind(){
        OpenPanel(Panel3);
        SceneManager.LoadScene("YindaoDigitWind");
    }
    }
   