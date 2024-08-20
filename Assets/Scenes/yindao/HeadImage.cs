using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HeadImage : MonoBehaviour
{
    [SerializeField] private int number;

    private bool isChoose = false;
    private HeadImage Btn1; 
    private HeadImage Btn2; 
    private HeadImage Btn3; 
    private HeadImage Btn4; 
    private HeadImage Btn5; 
    private HeadImage Btn6; 
    private HeadImage Btn7; 
    private HeadImage Btn8; 


    [SerializeField] private Sprite chosenSprite; // 选择状态下的Sprite
    [SerializeField] private Sprite unchosenSprite; // 未选择状态下的Sprite

    private Image buttonImage; // 用于更改Sprite的Image组件

    private Image BtnImage1; 
    private Image BtnImage2;
    private Image BtnImage3;
    private Image BtnImage4;
    private Image BtnImage5;
    private Image BtnImage6;
    private Image BtnImage7;
    private Image BtnImage8;

    public  Sprite HeadImageToGlobalStorage;

    /*private void Update()
    {
        if (Btn1.isChoose)
        {
            Btn1.HeadImageToGlobalStorage = buttonImage.sprite;
        }
        else if (Btn2.isChoose)
        {
            Btn1.HeadImageToGlobalStorage = buttonImage.sprite;

        }
        else if (Btn3.isChoose)
        {
            Btn1.HeadImageToGlobalStorage = buttonImage.sprite;

        }
        else if (Btn4.isChoose)
        {
            Btn1.HeadImageToGlobalStorage = buttonImage.sprite;

        }
        else if (Btn5.isChoose)
        {
            Btn1.HeadImageToGlobalStorage = buttonImage.sprite;

        }
        else if (Btn6.isChoose)
        {
            Btn1.HeadImageToGlobalStorage = buttonImage.sprite;

        }
        else if (Btn7.isChoose)
        {
            Btn1.HeadImageToGlobalStorage = buttonImage.sprite;

        }
        else if (Btn8.isChoose)
        {
            Btn1.HeadImageToGlobalStorage = buttonImage.sprite;

        }

    }*/
    private void Start()
    {
        //Debug.Log("正在调用答案检查器");
      
        // 获取当前Button的Image组件

        buttonImage = GetComponent<Image>();

        // 获得选项的脚本引用
        GameObject Button1 = GameObject.Find("Btn1");

        BtnImage1 = Button1.GetComponent<Image>();
        Btn1 = Button1.GetComponent<HeadImage>();

        GameObject Button2 = GameObject.Find("Btn2");

        BtnImage2 = Button2.GetComponent<Image>();
        Btn2 = Button2.GetComponent<HeadImage>();

        GameObject Button3 = GameObject.Find("Btn3");

        BtnImage3 = Button3.GetComponent<Image>();
        Btn3 = Button3.GetComponent<HeadImage>();

        GameObject Button4 = GameObject.Find("Btn4");

        BtnImage4 = Button4.GetComponent<Image>();
        Btn4 = Button4.GetComponent<HeadImage>();

        GameObject Button5 = GameObject.Find("Btn5");

        BtnImage5 = Button5.GetComponent<Image>();
        Btn5 = Button5.GetComponent<HeadImage>();

        GameObject Button6 = GameObject.Find("Btn6");

        BtnImage6 = Button6.GetComponent<Image>();
        Btn6 = Button6.GetComponent<HeadImage>();

        GameObject Button7 = GameObject.Find("Btn7");

        BtnImage7 = Button7.GetComponent<Image>();
        Btn7 = Button7.GetComponent<HeadImage>();

        GameObject Button8 = GameObject.Find("Btn8");

        BtnImage8 = Button8.GetComponent<Image>();
        Btn8 = Button8.GetComponent<HeadImage>();
    }

    public void OnButtonClick()
    {
        Debug.Log("Btn1:" + Btn1.isChoose);
        Debug.Log("Btn2:" + Btn2.isChoose);
        Debug.Log("Btn3:" + Btn3.isChoose);
        Debug.Log("Btn4:" + Btn4.isChoose);
        Debug.Log("Btn5:" + Btn5.isChoose);
        Debug.Log("Btn6:" + Btn6.isChoose);
        Debug.Log("Btn7:" + Btn7.isChoose);
        Debug.Log("Btn8:" + Btn8.isChoose);

        // 切换选择状态
        //isChoose = !isChoose;

        // 更改Sprite
        ChangeSprite();



    }

    private void ChangeSprite()
    {

        // 更改选择状态和Sprite
        isChoose = !isChoose;

        if (!isChoose && number == 1)
        {
            buttonImage.sprite = chosenSprite;
            ResetOptions(0, 1, 1, 1, 1, 1, 1, 1);
            Btn1.HeadImageToGlobalStorage = buttonImage.sprite;


        }
        else if (isChoose && number == 1)
        {
            buttonImage.sprite = unchosenSprite;
            ResetOptions(0, 1, 1, 1, 1, 1, 1, 1);
            //Btn1.HeadImageToGlobalStorage = buttonImage.sprite;

        }
        else if (!isChoose && number == 2)
        {
            buttonImage.sprite = chosenSprite;
            ResetOptions(1, 0, 1, 1, 1, 1, 1, 1);
            Btn1.HeadImageToGlobalStorage = buttonImage.sprite;


        }
        else if (isChoose && number == 2)
        {
            buttonImage.sprite = unchosenSprite;
            ResetOptions(1, 0, 1, 1, 1, 1, 1, 1);
        }
        else if (!isChoose && number == 3)
        {
            buttonImage.sprite = chosenSprite;
            ResetOptions(1, 1, 0, 1, 1, 1, 1, 1);
            Btn1.HeadImageToGlobalStorage = buttonImage.sprite;


        }
        else if (isChoose && number == 3)
        {
            buttonImage.sprite = unchosenSprite;
            ResetOptions(1, 1, 0, 1, 1, 1, 1, 1);
        }
        else if (!isChoose && number == 4)
        {
            buttonImage.sprite = chosenSprite;
            ResetOptions(1, 1, 1, 0, 1, 1, 1, 1);
            Btn1.HeadImageToGlobalStorage = buttonImage.sprite;


        }
        else if (isChoose && number == 4)
        {
            buttonImage.sprite = unchosenSprite;
            ResetOptions(1, 1, 1, 0, 1, 1, 1, 1);
        }
        else if (!isChoose && number == 5)
        {
            buttonImage.sprite = chosenSprite;
            ResetOptions(1, 1, 1, 1, 0, 1, 1, 1);
            Btn1.HeadImageToGlobalStorage = buttonImage.sprite;

        }
        else if (isChoose && number == 5)
        {
            buttonImage.sprite = unchosenSprite;
            ResetOptions(1, 1, 1, 1, 0, 1, 1, 1);
        }
        else if (!isChoose && number == 6)
        {
            buttonImage.sprite = chosenSprite;
            ResetOptions(1, 1, 1, 1, 1, 0, 1, 1);
            Btn1.HeadImageToGlobalStorage = buttonImage.sprite;


        }
        else if (isChoose && number == 6)
        {
            buttonImage.sprite = unchosenSprite;
            ResetOptions(1, 1, 1, 1, 1, 0, 1, 1);
        }
        else if (!isChoose && number == 7)
        {
            buttonImage.sprite = chosenSprite;
            ResetOptions(1, 1, 1, 1, 1, 1, 0, 1);
            Btn1.HeadImageToGlobalStorage = buttonImage.sprite;


        }
        else if (isChoose && number == 7)
        {
            buttonImage.sprite = unchosenSprite;
            ResetOptions(1, 1, 1, 1, 1, 1, 0, 1);
        }
        else if (!isChoose && number == 8)
        {
            buttonImage.sprite = chosenSprite;
            ResetOptions(1, 1, 1, 1, 1, 1, 1, 0);
            Btn1.HeadImageToGlobalStorage = buttonImage.sprite;



        }
        else if (isChoose && number == 8)
        {
            buttonImage.sprite = unchosenSprite;
            ResetOptions(1, 1, 1, 1, 1, 1, 1, 0);
        }

        GlobalStorage.instance.Head = Btn1.HeadImageToGlobalStorage;
    }



    private void ResetOptions(int num1, int num2, int num3, int num4, int num5, int num6, int num7, int num8)
    {
        if (num1 == 1)
        {
            Btn1.isChoose = false;
            BtnImage1.sprite = Btn1.unchosenSprite;
        }
        if (num2 == 1)
        {
            Btn2.isChoose = false;
            BtnImage2.sprite = Btn2.unchosenSprite; 
        }
        if (num3 == 1)
        {
            Btn3.isChoose = false;
            BtnImage3.sprite = Btn3.unchosenSprite; 
        }
        if (num4 == 1)
        {
            Btn4.isChoose = false;
            BtnImage4.sprite = Btn4.unchosenSprite; 
        }
        if (num5 == 1)
        {
            Btn5.isChoose = false;
            BtnImage5.sprite = Btn5.unchosenSprite; 
        }
        if (num6 == 1)
        {
            Btn6.isChoose = false;
            BtnImage6.sprite = Btn6.unchosenSprite; 
        }
        if (num7 == 1)
        {
            Btn7.isChoose = false;
            BtnImage7.sprite = Btn7.unchosenSprite; 
        }
        if (num8 == 1)
        {
            Btn8.isChoose = false;
            BtnImage8.sprite = Btn8.unchosenSprite; 
        }

    }
}