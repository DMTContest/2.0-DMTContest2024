using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class JianYing10 : MonoBehaviour
{
    private bool isChoose = false;
    private JianYing10 AOption; // 00ѡ��Ľű�����
    private JianYing10 BOption; // 01ѡ��Ľű�����
    private JianYing10 COption; // 10ѡ��Ľű�����
    private JianYing10 DOption; // 11ѡ��Ľű�����
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
    public TimeYG10 timeYG10;
    private void Start()
    {

        // ���ѡ��Ľű�����
        GameObject OA = GameObject.Find("Btn_1");
        AOption = OA.GetComponent<JianYing10>();

        GameObject OB = GameObject.Find("Btn_2");
        BOption = OB.GetComponent<JianYing10>();

        GameObject OC = GameObject.Find("Btn_3");
        COption = OC.GetComponent<JianYing10>();

        GameObject OD = GameObject.Find("Btn_4");
        DOption = OD.GetComponent<JianYing10>();

        //Debug.Log("�Ѿ������ĸ�ѡ��ű�");
    }
    public void OnButtonClickB()
    {

        isChoose = false;
        // ����
        CheckAnswer();
        timeYG10.ReduceTime(10f);
        BOption.wrong += 1;
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

        if (targetImage2 != null)
        {
            targetImage2.color = Color.green; // ����ɫ����Ϊ��ɫ
        }

    }
    public void OnButtonClickD()
    {
        timeYG10.ReduceTime(10f);

        isChoose = false;
        // ����
        CheckAnswer();
        // �޸�Image��ɫ
        BOption.wrong += 1;


    }
    private void CheckAnswer()
    {
        //Debug.Log("���ڵ��ô𰸼����");
        JianYing10 CorrectOption1 = AOption;
        JianYing10 CorrectOption2 = COption;

        JianYing10 WrongOption1 = BOption;
        JianYing10 WrongOption2 = DOption;

        if (CorrectOption1.isChoose == true &&
            CorrectOption2.isChoose == true &&
            WrongOption1.isChoose == false &&
            WrongOption2.isChoose == false)
        {
            Debug.Log("�����!");
            AOption.correct = 1;
            SceneManager.LoadScene("YGFinal");
        }
        else
        {
            Debug.Log("�����!");





        }
    }
}