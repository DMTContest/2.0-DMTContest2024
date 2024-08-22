using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ReturnToMainScene : MonoBehaviour
{
    public Button backButton;

    private void Start()
    {
        // 注册按钮的点击事件
        if (backButton != null)
        {
            backButton.onClick.AddListener(OnBackButtonClicked);
        }
    }

    private void OnBackButtonClicked()
    {
        // 加载指定的场景
        SceneManager.LoadScene("New Main");
    }
}