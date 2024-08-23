using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class BtM6 : MonoBehaviour, IPointerClickHandler
{
    public Button[] buttons; // ��ť����
    private bool[] buttonStates; // ��ť״̬����
    public TimeFG6 timeFG6; // ���õ� Countdown �ű�

    void Start()
    {
        buttonStates = new bool[buttons.Length];

        for (int i = 0; i < buttons.Length; i++)
        {
            int index = i; // Capture the current index for the lambda
            buttons[i].onClick.AddListener(() => OnButtonClicked(index));
        }
    }

    void OnButtonClicked(int index)
    {
        buttonStates[index] = true;
        CheckAllButtonsClicked();
    }

    void CheckAllButtonsClicked()
    {
        foreach (bool state in buttonStates)
        {
            if (!state) return;
        }

        // ���а�ť��������ˣ�����ҳ����ת
        SceneManager.LoadScene("FangKuai7"); // �滻�����Ŀ�곡������
    }

    // IPointerClickHandler method
    public void OnPointerClick(PointerEventData eventData)
    {
        // Check if the clicked object is not in the buttons array
        GameObject clickedObject = eventData.pointerPress;
        bool isButton = System.Array.Exists(buttons, button => button.gameObject == clickedObject);

        if (!isButton)
        {
            // Reduce time by 10 seconds
            if (timeFG6 != null)
            {
                timeFG6.ReduceTime(10f);
            }
        }
    }
}