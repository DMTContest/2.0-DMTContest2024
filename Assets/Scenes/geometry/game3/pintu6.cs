using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pintu6 : MonoBehaviour
{
    private bool isChoose = false;
    private pintu6 AOption; // 00ѡ��Ľű�����
    private pintu6 BOption; // 01ѡ��Ľű�����
    private pintu6 COption; // 10ѡ��Ľű�����
    private pintu6 DOption; // 11ѡ��Ľű�����
    private pintu6 EOption; // 00ѡ��Ľű�����
    private pintu6 FOption; // 01ѡ��Ľű�����
    private pintu6 GOption; // 10ѡ��Ľű�����
    private pintu6 HOption; // 11ѡ��Ľű�����
    public Image targetImage1; // ��Ӷ�Ŀ��Image������
    public Image targetImage2; // ��Ӷ�Ŀ��Image������
    public Image targetImage3; // ��Ӷ�Ŀ��Image������
    public Image targetImage4; // ��Ӷ�Ŀ��Image������

    public float correct;
    public float wrong;
    public TimePG6 timePG6;
    private void Start()
    {

        // ���ѡ��Ľű�����
        GameObject OA = GameObject.Find("Button-1");
        AOption = OA.GetComponent<pintu6>();

        GameObject OB = GameObject.Find("Button-2");
        BOption = OB.GetComponent<pintu6>();

        GameObject OC = GameObject.Find("Button-3");
        COption = OC.GetComponent<pintu6>();

        GameObject OD = GameObject.Find("Button-4");
        DOption = OD.GetComponent<pintu6>();
        // ���ѡ��Ľű�����
        GameObject OE = GameObject.Find("Button-5");
        EOption = OE.GetComponent<pintu6>();

        GameObject OF = GameObject.Find("Button-6");
        FOption = OF.GetComponent<pintu6>();

        GameObject OG = GameObject.Find("Button-7");
        GOption = OG.GetComponent<pintu6>();

        GameObject OH = GameObject.Find("Button-8");
        HOption = OH.GetComponent<pintu6>();
    }
    public void OnButtonClickB()
    {
        isChoose = false;
        // ����
        CheckAnswer();
        timePG6.ReduceTime(10f);

    }
    public void OnButtonClickA()
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
    public void OnButtonClickE()
    {

        isChoose = false;
        // ����
        CheckAnswer();
        timePG6.ReduceTime(10f);



    }

    public void OnButtonClickF()
    {

        // �л�ѡ��״̬
        isChoose = !isChoose;
        // ����
        CheckAnswer();
        // �޸�Image��ɫ
        if (targetImage4 != null)
        {
            targetImage4.color = Color.green; // ����ɫ����Ϊ��ɫ
        }
    }
    public void OnButtonClickG()
    {
        timePG6.ReduceTime(10f);

        isChoose = false;
        // ����
        CheckAnswer();
        // �޸�Image��ɫ

    }
    public void OnButtonClickH()
    {
        timePG6.ReduceTime(10f);

        isChoose = false;
        // ����
        CheckAnswer();
        // �޸�Image��ɫ


    }
    private void CheckAnswer()
    {
        //Debug.Log("���ڵ��ô𰸼����");
        pintu6 CorrectOption1 = AOption;
        pintu6 CorrectOption2 = COption;
        pintu6 CorrectOption3 = DOption;
        pintu6 CorrectOption4 = FOption;


        pintu6 WrongOption1 = BOption;
        pintu6 WrongOption2 = EOption;
        pintu6 WrongOption3 = GOption;
        pintu6 WrongOption4 = HOption;

        if (CorrectOption1.isChoose == true &&
            CorrectOption2.isChoose == true &&
            CorrectOption3.isChoose == true &&
            CorrectOption4.isChoose == true &&
            WrongOption3.isChoose == false &&
            WrongOption1.isChoose == false &&
            WrongOption4.isChoose == false &&
            WrongOption2.isChoose == false)
        {
            Debug.Log("�����!");
            AOption.correct = 1;
            SceneManager.LoadScene("pintu7");
        }
        else
        {
            Debug.Log("�����!");


            BOption.wrong += 1;


        }
    }
}