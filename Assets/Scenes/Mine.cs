using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mine : MonoBehaviour
{
    [SerializeField] GameObject PanelHead;
    [SerializeField] GameObject PanelName;
    [SerializeField] GameObject PanelSlogan;

    public InputField inputField1; // 第一个输入框
    public InputField inputField2; // 第二个输入框

    [SerializeField] Image head;
    public Text displayName; // 第一个显示文本的组件
    public Text displaySlogan; // 第二个显示文本的组件


    void Start()
    {
        PanelHead.SetActive(false);
        PanelName.SetActive(false);
        PanelSlogan.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //更新数据
        if (PanelHead.activeSelf)
        {
            head.sprite = GlobalStorage.instance.Head;
        }
        else if (PanelName.activeSelf)
        {
            displayName.text = GlobalStorage.instance.inputName;
        }
        else if (PanelSlogan.activeSelf)
        {
            displaySlogan.text = GlobalStorage.instance.inputSlogan;
        }
    }

    public void setHead()
    {
        Image buttonImage = GetComponent<Image>(); // 获取按钮的Image组件
        if (buttonImage != null && head != null)
        {
            head.sprite = buttonImage.sprite; // 将按钮的Sprite设置到目标图像
        }

        GlobalStorage.instance.Head = buttonImage.sprite;
    }

    public void setName()
    {
        displayName.text = inputField1.text;
        GlobalStorage.instance.inputName = inputField1.text; // 存储第一个输入框的内容
    }

    public void setSlogan()
    {
        displaySlogan.text = inputField2.text;
        GlobalStorage.instance.inputSlogan = inputField2.text; // 存储第一个输入框的内容
    }

    public void OpenPanelHead()
    {
        PanelHead.SetActive(true);
    }
    public void closePanelHead()
    {
        PanelHead.SetActive(false);
    }

    public void OpenPanelName()
    {
        PanelName.SetActive(true);
    }
    public void closePanelName()
    {
        PanelName.SetActive(false);
    }

    public void OpenPanelSlogan()
    {
        PanelSlogan.SetActive(true);
    }
    public void closePanelSlogan()
    {
        PanelSlogan.SetActive(false);
    }
}
