using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class JianYing8 : MonoBehaviour
{
    private bool isChoose = false;
    private JianYing8 AOption; // 00ѡ��Ľű�����
    private JianYing8 BOption; // 01ѡ��Ľű�����
    private JianYing8 COption; // 10ѡ��Ľű�����
    private JianYing8 DOption; // 11ѡ��Ľű�����
    public Image targetImage1; // ��Ӷ�Ŀ��Image������
    public Image targetImage2; // ��Ӷ�Ŀ��Image������

    public float correct;
    public float wrong;
    public TimeYG8 timeYG8;
    private void Start()
    {

        // ���ѡ��Ľű�����
        GameObject OA = GameObject.Find("Btn_1");
        AOption = OA.GetComponent<JianYing8>();

        GameObject OB = GameObject.Find("Btn_2");
        BOption = OB.GetComponent<JianYing8>();

        GameObject OC = GameObject.Find("Btn_3");
        COption = OC.GetComponent<JianYing8>();

        GameObject OD = GameObject.Find("Btn_4");
        DOption = OD.GetComponent<JianYing8>();

        //Debug.Log("�Ѿ������ĸ�ѡ��ű�");
    }
    public void OnButtonClickA()
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
        timeYG8.ReduceTime(10f);

        COption.wrong += 1;
    }
    public void OnButtonClickD()
    {

        isChoose = false;
        // ����
        CheckAnswer();
        timeYG8.ReduceTime(10f);

        COption.wrong += 1;
    }
    private void CheckAnswer()
    {
        //Debug.Log("���ڵ��ô𰸼����");
        JianYing8 CorrectOption1 = AOption;
        JianYing8 CorrectOption2 = BOption;

        JianYing8 WrongOption1 = COption;
        JianYing8 WrongOption2 = DOption;

        if (CorrectOption1.isChoose == true &&
            CorrectOption2.isChoose == true &&
            WrongOption1.isChoose == false &&
            WrongOption2.isChoose == false)
        {
            Debug.Log("�����!");
            BOption.correct = 1;
            SceneManager.LoadScene("JianYing9");
        }
        else
        {
            Debug.Log("�����!");




        }
    }
}