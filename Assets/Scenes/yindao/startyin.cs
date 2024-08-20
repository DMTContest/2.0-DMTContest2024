using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class startyin : PanelManager
{
    
    private int clickCount;
    [SerializeField ] GameObject Panel1;
    [SerializeField ] GameObject Panel2;
    [SerializeField ] GameObject Panel3;
    [SerializeField ] GameObject Panel4;
    [SerializeField ] GameObject Paneltip1;
    [SerializeField ] GameObject Paneltip2;
    [SerializeField ] GameObject Panel7;
    [SerializeField ] GameObject Panel8;
    public Text displayName; // 第一个显示文本的组件


    void Start()
    {
        Panel1.SetActive(true);
        Panel2.SetActive(false);
        Panel3.SetActive(false);
        Panel4.SetActive(false);
        Paneltip1.SetActive(false);
        Paneltip2.SetActive(false);
        Panel7.SetActive(false);
        Panel8.SetActive(false);
        EventSystem.current.SetSelectedGameObject(inputField1.gameObject);

    }

    // Update is called once per frame
    void Update()
    {

        if (Paneltip2.activeSelf==true && Input.GetMouseButtonDown(0)) // 检查左键点击
        {
            HandleClick();
        }
        if (Input.GetMouseButtonDown(0)) // 检查左键点击
        {
        clickCount++; // 增加点击计数器
            if (clickCount == 1)
            {
                OpenPanel(Panel1);
                OpenPanel(Panel2);
            }
            else if (clickCount == 2)
            {
                OpenPanel(Panel2);
                OpenPanel(Panel3);
            }
            else if (clickCount == 3)
            {
                OpenPanel(Panel3);
                OpenPanel(Panel4);
            }
            else if (clickCount == 4)
            {
                OpenPanel(Panel4);
                OpenPanel(Paneltip1);

            }
            else if (clickCount == 111)
            {
                OpenPanel(Panel7);
                OpenPanel(Panel8);
            }else if(clickCount == 112) {
                // 切换到场景3之前先保存输入数据
                FindObjectOfType<InputHandler>().StoreInputData();
                SceneManager.LoadScene("YindaoMain");
            }
        }
    
    }

    [SerializeField]private Image Btn_8_Image; // 用于更改Sprite的Image组件
    [SerializeField] private Sprite chosenSprite; // 选择状态下的Sprite
    [SerializeField]private Image Btn_ch8_Image; // 用于更改Sprite的Image组件
    [SerializeField] private Sprite ch8chosenSprite; // 选择状态下的Sprite

    public void ChooseBtn_8(){
        Btn_8_Image.sprite = chosenSprite;
    }

    public void ChooseBtn_ch8(){
        Btn_ch8_Image.sprite = ch8chosenSprite;
    }

    public void GoBackto4(){
        OpenPanel(Paneltip1);
        OpenPanel(Panel4);
    }

    public void Nextto6(){
        OpenPanel(Paneltip1);
        OpenPanel(Paneltip2);
    }

    public InputField inputField1;
    public InputField inputField2;


    private void HandleClick()
    {
        // 获取鼠标点击的位置
        Vector2 mousePosition = Input.mousePosition;

        // 检查鼠标点击是否在 inputField1 上
        if (RectTransformUtility.RectangleContainsScreenPoint(inputField1.GetComponent<RectTransform>(), mousePosition))
        {
            SelectInputField(inputField1);
        }
        // 检查鼠标点击是否在 inputField2 上
        else if (RectTransformUtility.RectangleContainsScreenPoint(inputField2.GetComponent<RectTransform>(), mousePosition))
        {
            SelectInputField(inputField2);
        }
    }

    private void SelectInputField(InputField inputField)
    {
        // 使所选的 Input Field 成为当前聚焦的对象
        EventSystem.current.SetSelectedGameObject(inputField.gameObject);
    }

        public void OnSubmit(string text)
    {
        // 当按下回车键时，调用此方法
        Debug.Log("Submitted Text: " + text);
        // 在这里处理提交的文本
    }
    
    public void GoBackto5(){
        OpenPanel(Paneltip2);
        OpenPanel(Paneltip1);
    }

    public void Nextto7(){
        OpenPanel(Paneltip2);

        displayName.text = "欢迎你!\n" + inputField1.text + "!"; // 设置第一个文本

        OpenPanel(Panel7);
        clickCount = 110;
    }
}
