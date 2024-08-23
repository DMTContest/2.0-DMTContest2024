using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pintu7 : MonoBehaviour
{
    private bool isChoose = false;
    private pintu7 AOption; // 00ѡ��Ľű�����
    private pintu7 BOption; // 01ѡ��Ľű�����
    private pintu7 COption; // 10ѡ��Ľű�����
    private pintu7 DOption; // 11ѡ��Ľű�����
    private pintu7 EOption; // 00ѡ��Ľű�����
    private pintu7 FOption; // 01ѡ��Ľű�����
    private pintu7 GOption; // 10ѡ��Ľű�����
    private pintu7 HOption; // 11ѡ��Ľű�����
    public Image targetImage1; // ��Ӷ�Ŀ��Image������
    public Image targetImage2; // ��Ӷ�Ŀ��Image������
    public Image targetImage3; // ��Ӷ�Ŀ��Image������


    public float correct;
    public float wrong;
    public TimePG7 timePG7;
    private void Start()
    {

        // ���ѡ��Ľű�����
        GameObject OA = GameObject.Find("Button-1");
        AOption = OA.GetComponent<pintu7>();

        GameObject OB = GameObject.Find("Button-2");
        BOption = OB.GetComponent<pintu7>();

        GameObject OC = GameObject.Find("Button-3");
        COption = OC.GetComponent<pintu7>();

        GameObject OD = GameObject.Find("Button-4");
        DOption = OD.GetComponent<pintu7>();
        // ���ѡ��Ľű�����
        GameObject OE = GameObject.Find("Button-5");
        EOption = OE.GetComponent<pintu7>();

        GameObject OF = GameObject.Find("Button-6");
        FOption = OF.GetComponent<pintu7>();

        GameObject OG = GameObject.Find("Button-7");
        GOption = OG.GetComponent<pintu7>();

        GameObject OH = GameObject.Find("Button-8");
        HOption = OH.GetComponent<pintu7>();
        //Debug.Log("�Ѿ������ĸ�ѡ��ű�");
    }
    public void OnButtonClickB()
    {
        isChoose = false;
        // ����
        CheckAnswer();
        timePG7.ReduceTime(10f);

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
        isChoose = false;
        // ����
        CheckAnswer();
        timePG7.ReduceTime(10f);
    }
    public void OnButtonClickD()
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
    public void OnButtonClickE()
    {

        isChoose = false;
        // ����
        CheckAnswer();
        timePG7.ReduceTime(10f);

    }

    public void OnButtonClickF()
    {
        isChoose = false;
        // ����
        CheckAnswer();
        timePG7.ReduceTime(10f);
    }
    public void OnButtonClickG()
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
    public void OnButtonClickH()
    {
        timePG7.ReduceTime(10f);

        isChoose = false;
        // ����
        CheckAnswer();
        // �޸�Image��ɫ


    }
    private void CheckAnswer()
    {
        //Debug.Log("���ڵ��ô𰸼����");
        pintu7 CorrectOption1 = AOption;
        pintu7 CorrectOption2 = DOption;
        pintu7 CorrectOption3 = GOption;


        pintu7 WrongOption1 = BOption;
        pintu7 WrongOption2 = COption;
        pintu7 WrongOption3 = EOption;
        pintu7 WrongOption4 = FOption;
        pintu7 WrongOption5 = HOption;
        Debug.Log($"AOption.isChoose: {AOption.isChoose}");
        Debug.Log($"BOption.isChoose: {BOption.isChoose}");
        Debug.Log($"COption.isChoose: {COption.isChoose}");
        Debug.Log($"DOption.isChoose: {DOption.isChoose}");
        Debug.Log($"EOption.isChoose: {EOption.isChoose}");
        Debug.Log($"FOption.isChoose: {FOption.isChoose}");
        Debug.Log($"GOption.isChoose: {GOption.isChoose}");
        Debug.Log($"HOption.isChoose: {HOption.isChoose}");
        if (CorrectOption1.isChoose == true &&
            CorrectOption2.isChoose == true &&
            CorrectOption3.isChoose == true &&
            WrongOption1.isChoose == false &&
            WrongOption2.isChoose == false &&
            WrongOption3.isChoose == false &&
            WrongOption4.isChoose == false &&
            WrongOption5.isChoose == false)
        {
            Debug.Log("�����!");
            AOption.correct = 1;
            SceneManager.LoadScene("pintu8");
        }
        else
        {
            Debug.Log("�����!");


            BOption.wrong += 1;


        }
    }
}