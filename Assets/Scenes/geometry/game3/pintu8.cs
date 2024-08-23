using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pintu8 : MonoBehaviour
{
    private bool isChoose = false;
    private pintu8 AOption; // 00ѡ��Ľű�����
    private pintu8 BOption; // 01ѡ��Ľű�����
    private pintu8 COption; // 10ѡ��Ľű�����
    private pintu8 DOption; // 11ѡ��Ľű�����
    private pintu8 EOption; // 00ѡ��Ľű�����
    private pintu8 FOption; // 01ѡ��Ľű�����
    private pintu8 GOption; // 10ѡ��Ľű�����
    private pintu8 HOption; // 11ѡ��Ľű�����
    public Image targetImage1; // ��Ӷ�Ŀ��Image������
    public Image targetImage2; // ��Ӷ�Ŀ��Image������
    public Image targetImage3; // ��Ӷ�Ŀ��Image������


    public float correct;
    public float wrong;
    public TimePG8 timePG8;
    private void Start()
    {

        // ���ѡ��Ľű�����
        GameObject OA = GameObject.Find("Button-1");
        AOption = OA.GetComponent<pintu8>();

        GameObject OB = GameObject.Find("Button-2");
        BOption = OB.GetComponent<pintu8>();

        GameObject OC = GameObject.Find("Button-3");
        COption = OC.GetComponent<pintu8>();

        GameObject OD = GameObject.Find("Button-4");
        DOption = OD.GetComponent<pintu8>();
        // ���ѡ��Ľű�����
        GameObject OE = GameObject.Find("Button-5");
        EOption = OE.GetComponent<pintu8>();

        GameObject OF = GameObject.Find("Button-6");
        FOption = OF.GetComponent<pintu8>();

        GameObject OG = GameObject.Find("Button-7");
        GOption = OG.GetComponent<pintu8>();

        GameObject OH = GameObject.Find("Button-8");
        HOption = OH.GetComponent<pintu8>();
        //Debug.Log("�Ѿ������ĸ�ѡ��ű�");
    }
    public void OnButtonClickA()
    {
        isChoose = false;
        // ����
        CheckAnswer();
        timePG8.ReduceTime(10f);

    }
    public void OnButtonClickB()
    {
        // �л�ѡ��״̬
        isChoose = !isChoose;
        // ����
        CheckAnswer();
        // �޸�Image��ɫ
        if (targetImage1 != null)
        {
            targetImage1.color = Color.green; // ����ɫ����Ϊ��ɫ
        }

    }

    public void OnButtonClickC()
    {
        // �л�ѡ��״̬
        isChoose = !isChoose;
        // ����
        CheckAnswer();
        // �޸�Image��ɫ
        if (targetImage2 != null)
        {
            targetImage2.color = Color.green; // ����ɫ����Ϊ��ɫ
        }
       
    }
    public void OnButtonClickD()
    {
        isChoose = false;
        // ����
        CheckAnswer();
        timePG8.ReduceTime(10f);

    }
    public void OnButtonClickE()
    {

        isChoose = false;
        // ����
        CheckAnswer();
        timePG8.ReduceTime(10f);

    }

    public void OnButtonClickF()
    {

        // �л�ѡ��״̬
        isChoose = !isChoose;
        // ����
        CheckAnswer();
        // �޸�Image��ɫ
        if (targetImage3 != null)
        {
            targetImage3.color = Color.green; // ����ɫ����Ϊ��ɫ
        }

    }
    public void OnButtonClickG()
    {

        isChoose = false;
        // ����
        CheckAnswer();
        timePG8.ReduceTime(10f);
    }
    public void OnButtonClickH()
    {
        timePG8.ReduceTime(10f);

        isChoose = false;
        // ����
        CheckAnswer();
        // �޸�Image��ɫ


    }
    private void CheckAnswer()
    {
        //Debug.Log("���ڵ��ô𰸼����");
        pintu8 CorrectOption1 = BOption;
        pintu8 CorrectOption2 = COption;
        pintu8 CorrectOption3 = FOption;


        pintu8 WrongOption1 = AOption;
        pintu8 WrongOption2 = DOption;
        pintu8 WrongOption3 = EOption;
        pintu8 WrongOption4 = GOption;
        pintu8 WrongOption5 = HOption;

        if (CorrectOption1.isChoose == true &&
            CorrectOption2.isChoose == true &&
            CorrectOption3.isChoose == true &&
            WrongOption3.isChoose == false &&
            WrongOption1.isChoose == false &&
            WrongOption4.isChoose == false &&
            WrongOption5.isChoose == false &&
            WrongOption2.isChoose == false)
        {
            Debug.Log("�����!");
            BOption.correct = 1;
            SceneManager.LoadScene("pintu9");
        }
        else
        {
            Debug.Log("�����!");


            AOption.wrong += 1;


        }
    }
}