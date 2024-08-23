using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pintu10 : MonoBehaviour
{
    private bool isChoose = false;
    private pintu10 AOption; // 00ѡ��Ľű�����
    private pintu10 BOption; // 01ѡ��Ľű�����
    private pintu10 COption; // 10ѡ��Ľű�����
    private pintu10 DOption; // 11ѡ��Ľű�����
    private pintu10 EOption; // 00ѡ��Ľű�����
    private pintu10 FOption; // 01ѡ��Ľű�����
    private pintu10 GOption; // 10ѡ��Ľű�����
    private pintu10 HOption; // 11ѡ��Ľű�����
    public Image targetImage1; // ��Ӷ�Ŀ��Image������
    public Image targetImage2; // ��Ӷ�Ŀ��Image������
    public Image targetImage3; // ��Ӷ�Ŀ��Image������


    public float correct;
    public float wrong;
    public TimePG10 timePG10;
    private void Start()
    {

        // ���ѡ��Ľű�����
        GameObject OA = GameObject.Find("Button-1");
        AOption = OA.GetComponent<pintu10>();

        GameObject OB = GameObject.Find("Button-2");
        BOption = OB.GetComponent<pintu10>();

        GameObject OC = GameObject.Find("Button-3");
        COption = OC.GetComponent<pintu10>();

        GameObject OD = GameObject.Find("Button-4");
        DOption = OD.GetComponent<pintu10>();
        // ���ѡ��Ľű�����
        GameObject OE = GameObject.Find("Button-5");
        EOption = OE.GetComponent<pintu10>();

        GameObject OF = GameObject.Find("Button-6");
        FOption = OF.GetComponent<pintu10>();

        GameObject OG = GameObject.Find("Button-7");
        GOption = OG.GetComponent<pintu10>();

        GameObject OH = GameObject.Find("Button-8");
        HOption = OH.GetComponent<pintu10>();

        //Debug.Log("�Ѿ������ĸ�ѡ��ű�");
    }
    public void OnButtonClickA()
    {
        isChoose = false;
        // ����
        CheckAnswer();
        timePG10.ReduceTime(10f);

    }
    public void OnButtonClickB()
    {
        isChoose = false;
        // ����
        CheckAnswer();
        timePG10.ReduceTime(10f);

    }

    public void OnButtonClickC()
    {
        isChoose = false;
        // ����
        CheckAnswer();
        timePG10.ReduceTime(10f);

    }
    public void OnButtonClickD()
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
    public void OnButtonClickE()
    {

        isChoose = false;
        // ����
        CheckAnswer();
        timePG10.ReduceTime(10f);
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
        timePG10.ReduceTime(10f);
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
        pintu10 CorrectOption1 = DOption;
        pintu10 CorrectOption2 = FOption;
        pintu10 CorrectOption3 = HOption;


        pintu10 WrongOption1 = AOption;
        pintu10 WrongOption2 = BOption;
        pintu10 WrongOption3 = COption;
        pintu10 WrongOption4 = DOption;
        pintu10 WrongOption5 = GOption;

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
            DOption.correct = 1;
            SceneManager.LoadScene("PGFinal");
        }
        else
        {
            Debug.Log("�����!");


            AOption.wrong += 1;


        }
    }
}