using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pintu9 : MonoBehaviour
{
    private bool isChoose = false;
    private pintu9 AOption; // 00ѡ��Ľű�����
    private pintu9 BOption; // 01ѡ��Ľű�����
    private pintu9 COption; // 10ѡ��Ľű�����
    private pintu9 DOption; // 11ѡ��Ľű�����
    private pintu9 EOption; // 00ѡ��Ľű�����
    private pintu9 FOption; // 01ѡ��Ľű�����
    private pintu9 GOption; // 10ѡ��Ľű�����
    private pintu9 HOption; // 11ѡ��Ľű�����
    public Image targetImage1; // ��Ӷ�Ŀ��Image������
    public Image targetImage2; // ��Ӷ�Ŀ��Image������
    public Image targetImage3; // ��Ӷ�Ŀ��Image������


    public float correct;
    public float wrong;
    public TimePG9 timePG9;
    private void Start()
    {

        // ���ѡ��Ľű�����
        // ���ѡ��Ľű�����
        GameObject OA = GameObject.Find("Button-1");
        AOption = OA.GetComponent<pintu9>();

        GameObject OB = GameObject.Find("Button-2");
        BOption = OB.GetComponent<pintu9>();

        GameObject OC = GameObject.Find("Button-3");
        COption = OC.GetComponent<pintu9>();

        GameObject OD = GameObject.Find("Button-4");
        DOption = OD.GetComponent<pintu9>();
        // ���ѡ��Ľű�����
        GameObject OE = GameObject.Find("Button-5");
        EOption = OE.GetComponent<pintu9>();

        GameObject OF = GameObject.Find("Button-6");
        FOption = OF.GetComponent<pintu9>();

        GameObject OG = GameObject.Find("Button-7");
        GOption = OG.GetComponent<pintu9>();

        GameObject OH = GameObject.Find("Button-8");
        HOption = OH.GetComponent<pintu9>();
        //Debug.Log("�Ѿ������ĸ�ѡ��ű�");
    }
    public void OnButtonClickA()
    {
        isChoose = false;
        // ����
        CheckAnswer();
        timePG9.ReduceTime(10f);

    }
    public void OnButtonClickB()
    {
        isChoose = false;
        // ����
        CheckAnswer();
        timePG9.ReduceTime(10f);

    }

    public void OnButtonClickC()
    {
        isChoose = false;
        // ����
        CheckAnswer();
        timePG9.ReduceTime(10f);

    }
    public void OnButtonClickD()
    {
        isChoose = false;
        // ����
        CheckAnswer();
        timePG9.ReduceTime(10f);

    }
    public void OnButtonClickE()
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

    public void OnButtonClickF()
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
    public void OnButtonClickG()
    {

        isChoose = false;
        // ����
        CheckAnswer();
        timePG9.ReduceTime(10f);
    }
    public void OnButtonClickH()
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
    private void CheckAnswer()
    {
        //Debug.Log("���ڵ��ô𰸼����");
        pintu9 CorrectOption1 = EOption;
        pintu9 CorrectOption2 = FOption;
        pintu9 CorrectOption3 = HOption;


        pintu9 WrongOption1 = AOption;
        pintu9 WrongOption2 = BOption;
        pintu9 WrongOption3 = COption;
        pintu9 WrongOption4 = DOption;
        pintu9 WrongOption5 = GOption;

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
            EOption.correct = 1;
            SceneManager.LoadScene("pintu10");
        }
        else
        {
            Debug.Log("�����!");


            AOption.wrong += 1;


        }
    }
}