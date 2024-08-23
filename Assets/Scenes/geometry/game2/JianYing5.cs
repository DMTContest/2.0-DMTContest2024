using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class JianYing5 : MonoBehaviour
{
    private bool isChoose = false;
    private JianYing5 AOption; // 00ѡ��Ľű�����
    private JianYing5 BOption; // 01ѡ��Ľű�����
    private JianYing5 COption; // 10ѡ��Ľű�����
    private JianYing5 DOption; // 11ѡ��Ľű�����
    public Image targetImage1; // ��Ӷ�Ŀ��Image������
    public Image targetImage2; // ��Ӷ�Ŀ��Image������

    public Button[] choiceButtons; // ѡ��ť����
    public Image silhouetteImage1; // ��һ����ӰͼƬ
    public Image silhouetteImage2; // �ڶ�����ӰͼƬ

    private int correctButtonIndex1 = 1; // ��һ����ȷ��ť������
    private int correctButtonIndex2 = 3; // �ڶ�����ȷ��ť������

    private bool buttonClicked1 = false; // ��¼��һ����ť�Ƿ񱻵��
    private bool buttonClicked2 = false; // ��¼�ڶ�����ť�Ƿ񱻵��

    public float correct;
    public float wrong;
    public TimeYG5 timeYG5;
    private void Start()
    {

        // ���ѡ��Ľű�����
        GameObject OA = GameObject.Find("Btn_1");
        AOption = OA.GetComponent<JianYing5>();

        GameObject OB = GameObject.Find("Btn_2");
        BOption = OB.GetComponent<JianYing5>();

        GameObject OC = GameObject.Find("Btn_3");
        COption = OC.GetComponent<JianYing5>();

        GameObject OD = GameObject.Find("Btn_4");
        DOption = OD.GetComponent<JianYing5>();

        //Debug.Log("�Ѿ������ĸ�ѡ��ű�");
    }
    public void OnButtonClickA()
    {

        isChoose = false;
        // ����
        CheckAnswer();
        timeYG5.ReduceTime(10f);
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

        isChoose = false;
        // ����
        CheckAnswer();
        timeYG5.ReduceTime(10f);
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
    private void CheckAnswer()
    {
        //Debug.Log("���ڵ��ô𰸼����");
        JianYing5 CorrectOption1 = BOption;
        JianYing5 CorrectOption2 = DOption;

        JianYing5 WrongOption1 = AOption;
        JianYing5 WrongOption2 = COption;

        if (CorrectOption1.isChoose == true &&
            CorrectOption2.isChoose == true &&
            WrongOption1.isChoose == false &&
            WrongOption2.isChoose == false)
        {
            Debug.Log("�����!");
            BOption.correct = 1;
            SceneManager.LoadScene("JianYing6");
        }
        else
        {
            Debug.Log("�����!");


            AOption.wrong += 1;


        }
    }
}