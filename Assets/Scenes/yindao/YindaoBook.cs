using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class YindaoBook : PanelManager
{
    private int clickCount;
    [SerializeField] GameObject Panel1;
    [SerializeField] GameObject Panel2;
    [SerializeField] GameObject Panel3;
    [SerializeField] GameObject Panel4;
    [SerializeField] GameObject Panel5;
    [SerializeField] GameObject Panel6;
    [SerializeField] GameObject Panel7;
    [SerializeField] GameObject Panel8;

    private int Btn_clickCount = 2;

    void Start()
    {
        // 初始化时关闭所有面板
        CloseAllPanels();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 检查左键点击
        {
            clickCount++; // 增加点击计数器

            // 根据 clickCount 的值来决定显示哪些面板
            if (clickCount == 1)
            {
                OpenPanel(Panel1);
                OpenPanel(Panel2);
            }
            else if (clickCount == 2)
            {
                OpenPanel(Panel2);
                OpenPanel(Panel3);
                // 重置 clickCount
                clickCount = 10083;
                Btn_clickCount = 3;
            }
            else if (Btn_clickCount == 3)
            {
                OpenPanel(Panel3);
                OpenPanel(Panel4);
                Btn_clickCount++;
            }
            else if (Btn_clickCount == 4)
            {
                OpenPanel(Panel4);
                OpenPanel(Panel5);
                Btn_clickCount++;
            }
            else if (Btn_clickCount == 5)
            {
                OpenPanel(Panel5);
                OpenPanel(Panel6);
                Btn_clickCount++;
            }
            else if (Btn_clickCount == 6)
            {
                OpenPanel(Panel6);
                OpenPanel(Panel7);
                Btn_clickCount++;
            }
            else if (Btn_clickCount == 7)
            {
                OpenPanel(Panel7);
                OpenPanel(Panel8);
                Btn_clickCount++;
            }
            else if (Btn_clickCount == 8)
            {
                OpenPanel(Panel8);
                SceneManager.LoadScene("MG11");
            }
        }
    }

    public void Btn_onClickCount()
    {
        Btn_clickCount++;
    }

    private void CloseAllPanels()
    {
        Panel1.SetActive(true);
        Panel2.SetActive(false);
        Panel3.SetActive(false);
        Panel4.SetActive(false);
        Panel5.SetActive(false);
        Panel6.SetActive(false);
        Panel7.SetActive(false);
        Panel8.SetActive(false);
    }

}