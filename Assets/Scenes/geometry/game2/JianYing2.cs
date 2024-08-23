using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class JianYing2 : MonoBehaviour
{
    private bool isChoose = false;
    private JianYing2 AOption; // 00ѡ��Ľű�����
    private JianYing2 BOption; // 01ѡ��Ľű�����
    private JianYing2 COption; // 10ѡ��Ľű�����
    private JianYing2 DOption; // 11ѡ��Ľű�����
    public Image targetImage1; // ��Ӷ�Ŀ��Image������


    public float correct;
    public float wrong;
    public TimeYG2 timeYG2;
    private void Start()
    {

        // ���ѡ��Ľű�����
        GameObject OA = GameObject.Find("Btn_1");
        AOption = OA.GetComponent<JianYing2>();

        GameObject OB = GameObject.Find("Btn_2");
        BOption = OB.GetComponent<JianYing2>();

        GameObject OC = GameObject.Find("Btn_3");
        COption = OC.GetComponent<JianYing2>();

        GameObject OD = GameObject.Find("Btn_4");
        DOption = OD.GetComponent<JianYing2>();

        //Debug.Log("�Ѿ������ĸ�ѡ��ű�");
    }
    public void OnButtonClickB()
    {
        isChoose = false;
        // ����
        CheckAnswer();
        timeYG2.ReduceTime(10f);
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
       
        
        // ����
        CheckAnswer();

        timeYG2.ReduceTime(10f);

        isChoose = false;
        // ����
    }
    public void OnButtonClickD()
    {
        timeYG2.ReduceTime(10f);

        isChoose = false;
        // ����
        CheckAnswer();
        // �޸�Image��ɫ
        

    }
    private void CheckAnswer()
    {
        //Debug.Log("���ڵ��ô𰸼����");
        JianYing2 CorrectOption1 = AOption;


        JianYing2 WrongOption1 = BOption;
        JianYing2 WrongOption2 = DOption;
        JianYing2 WrongOption3 = COption;

        if (CorrectOption1.isChoose == true &&
            WrongOption3.isChoose == false &&
            WrongOption1.isChoose == false &&
            WrongOption2.isChoose == false)
        {
            Debug.Log("�����!");
            AOption.correct = 1;
            SceneManager.LoadScene("JianYing3");
        }
        else
        {
            Debug.Log("�����!");


            BOption.wrong += 1;


        }
    }
}