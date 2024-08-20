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
    [SerializeField] Image head;
    public Text displayName; // 第一个显示文本的组件
    public Text displaySlogan; // 第二个显示文本的组件


    void Start()
    {
        Panel1.SetActive(true);
        Panel2.SetActive(false);
        Panel3.SetActive(false);
       
            // 检查是否存储了头像
            if (GlobalStorage.HeadImage != null)
            {
                head.sprite = GlobalStorage.HeadImage;
            }
            else
            {
                //Debug.Log("未找到头像图像。");
            }
        displayName.text = GlobalStorage.instance.inputName; // 设置第一个文本
        displaySlogan.text = GlobalStorage.instance.inputSlogan; // 设置第二个文本

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 检查左键点击
        {
        clickCount++; // 增加点击计数器
        if(clickCount==1){
                OpenPanel(Panel1);
                OpenPanel(Panel2);
            }
            else if(clickCount==2){
                OpenPanel(Panel2);
                OpenPanel(Panel3);
            }
            
            
        }
    }

    public void GoToYindaoDigitWind(){

        OpenPanel(Panel3);

        SceneManager.LoadScene("YindaoDigitWind");
    }
    }
   