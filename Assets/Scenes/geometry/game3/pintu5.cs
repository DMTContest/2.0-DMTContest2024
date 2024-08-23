using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pintu5 : MonoBehaviour
{
    private bool isChoose = false;
    private pintu5 AOption; // 00ѡ��Ľű�����
    private pintu5 BOption; // 01ѡ��Ľű�����
    private pintu5 COption; // 10ѡ��Ľű�����
    private pintu5 DOption; // 11ѡ��Ľű�����
    private pintu5 EOption; // 00ѡ��Ľű�����
    private pintu5 FOption; // 01ѡ��Ľű�����
    private pintu5 GOption; // 10ѡ��Ľű�����
    private pintu5 HOption; // 11ѡ��Ľű�����
    public Image targetImage1; // ��Ӷ�Ŀ��Image������
    public Image targetImage2; // ��Ӷ�Ŀ��Image������
    public Image targetImage3; // ��Ӷ�Ŀ��Image������
    public Image targetImage4; // ��Ӷ�Ŀ��Image������

    public float correct;
    public float wrong;
    public TimePG5 timePG5;
    private void Start()
    {

        // ���ѡ��Ľű�����
        GameObject OA = GameObject.Find("Button-1");
        AOption = OA.GetComponent<pintu5>();

        GameObject OB = GameObject.Find("Button-2");
        BOption = OB.GetComponent<pintu5>();

        GameObject OC = GameObject.Find("Button-3");
        COption = OC.GetComponent<pintu5>();

        GameObject OD = GameObject.Find("Button-4");
        DOption = OD.GetComponent<pintu5>();
        // ���ѡ��Ľű�����
        GameObject OE = GameObject.Find("Button-5");
        EOption = OE.GetComponent<pintu5>();

        GameObject OF = GameObject.Find("Button-6");
        FOption = OF.GetComponent<pintu5>();

        GameObject OG = GameObject.Find("Button-7");
        GOption = OG.GetComponent<pintu5>();

        GameObject OH = GameObject.Find("Button-8");
        HOption = OH.GetComponent<pintu5>();

        //Debug.Log("�Ѿ������ĸ�ѡ��ű�");
    }
    public void OnButtonClickB()
    {
        isChoose = false;
        // ����
        CheckAnswer();
        timePG5.ReduceTime(10f);

    }
    public void OnButtonClickA()
    {
        // �л�ѡ��״̬
        isChoose = true;
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
        isChoose = true;
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
        isChoose = true;
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
        timePG5.ReduceTime(10f);



    }

    public void OnButtonClickF()
    {
        isChoose = true;
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
        timePG5.ReduceTime(10f);

        isChoose = false;
        // ����
        CheckAnswer();
        // �޸�Image��ɫ

    }
    public void OnButtonClickH()
    {
        timePG5.ReduceTime(10f);

        isChoose = false;
        // ����
        CheckAnswer();
        // �޸�Image��ɫ


    }
    private void CheckAnswer()
    {
        //Debug.Log("���ڵ��ô𰸼����");
        pintu5 CorrectOption1 = AOption;
        pintu5 CorrectOption2 = COption;
        pintu5 CorrectOption3 = DOption;
        pintu5 CorrectOption4 = FOption;


        pintu5 WrongOption1 = BOption;
        pintu5 WrongOption2 = EOption;
        pintu5 WrongOption3 = GOption;
        pintu5 WrongOption4 = HOption;
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
            CorrectOption4.isChoose == true &&
            WrongOption1.isChoose == false &&
            WrongOption2.isChoose == false &&
            WrongOption3.isChoose == false &&
            WrongOption4.isChoose == false)
        {
            Debug.Log("�����!");
            AOption.correct = 1;
            SceneManager.LoadScene("pintu6");
        }
        else
        {
            Debug.Log("�����!");

            BOption.wrong += 1;


        }
    }
}