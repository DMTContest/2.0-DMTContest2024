using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class JianYing7 : MonoBehaviour
{
    private bool isChoose = false;
    private JianYing7 AOption; // 00ѡ��Ľű�����
    private JianYing7 BOption; // 01ѡ��Ľű�����
    private JianYing7 COption; // 10ѡ��Ľű�����
    private JianYing7 DOption; // 11ѡ��Ľű�����
    public Image targetImage1; // ��Ӷ�Ŀ��Image������
    public Image targetImage2; // ��Ӷ�Ŀ��Image������

    public float correct;
    public TimeYG7 timeYG7;
    private void Start()
    {

        // ���ѡ��Ľű�����
        GameObject OA = GameObject.Find("Btn_1");
        AOption = OA.GetComponent<JianYing7>();

        GameObject OB = GameObject.Find("Btn_2");
        BOption = OB.GetComponent<JianYing7>();

        GameObject OC = GameObject.Find("Btn_3");
        COption = OC.GetComponent<JianYing7>();

        GameObject OD = GameObject.Find("Btn_4");
        DOption = OD.GetComponent<JianYing7>();

        //Debug.Log("�Ѿ������ĸ�ѡ��ű�");
    }


    public void OnButtonClickC()
    {

        isChoose = false;
        // ����
        CheckAnswer();
        timeYG7.ReduceTime(10f);
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

    public void OnButtonClickD()
    {

        isChoose = false;
        // ����
        CheckAnswer();
        timeYG7.ReduceTime(10f);
    }
    public void OnButtonClickB()
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
        JianYing7 CorrectOption1 = AOption;
        JianYing7 CorrectOption2 = BOption;

        JianYing7 WrongOption1 = COption;
        JianYing7 WrongOption2 = DOption;

        if (CorrectOption1.isChoose == true &&
            CorrectOption2.isChoose == true &&
            WrongOption1.isChoose == false &&
            WrongOption2.isChoose == false)
        {
            Debug.Log("�����!");
            AOption.correct = 1;
            SceneManager.LoadScene("JianYing8");
        }
    }
}