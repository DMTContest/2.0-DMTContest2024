using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class YindaoDigitWind : PanelManager
{
    
    private int clickCount;
    [SerializeField ] GameObject Panel1;
    [SerializeField ] GameObject Panel2;
    public Text displayName; // 第一个显示文本的组件
    public Text displaySlogan; // 第二个显示文本的组件
    [SerializeField] Image head;



    void Start()
    {
        Panel1.SetActive(true);
        Panel2.SetActive(false);

        displayName.text = GlobalStorage.instance.inputName; // 设置第一个文本
        displaySlogan.text = GlobalStorage.instance.inputSlogan; // 设置第二个文本
        head.sprite = GlobalStorage.HeadImage;

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
            
        }
    }

    public void GoToYindaoDigitWind(){
         OpenPanel(Panel2);
        SceneManager.LoadScene("YindaoBook");
    }
    }
   