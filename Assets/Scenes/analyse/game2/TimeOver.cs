using UnityEngine;
using System.Collections;

public class TimeOver: MonoBehaviour
{
    [SerializeField]private string TargetScene = "AG2Final";
    private void Start()
    {
        StartCoroutine(ChangeScene());
    }

    private IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(2f);
        // 切换到下一个场景
        UnityEngine.SceneManagement.SceneManager.LoadScene(TargetScene);
    }
}