using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class YindaoFinalMain : PanelManager
{
    
    private int clickCount;
    [SerializeField ] GameObject Panel1;
    [SerializeField ] GameObject Panel2;
    [SerializeField ] GameObject Panel3;
    [SerializeField ] GameObject Panel4;


    void Start()
    {
        Panel1.SetActive(false);
        Panel2.SetActive(false);
        Panel3.SetActive(false);
        Panel4.SetActive(false);

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
            OpenPanel(Panel4);
        }else if(clickCount==4){
            OpenPanel(Panel4);
            SceneManager.LoadScene("New Main");
        }
        }
    }


    }
   