using UnityEngine;
using UnityEngine.UI;

public class PanelController : MonoBehaviour
{

    [SerializeField] private GameObject panel1;
    [SerializeField] private GameObject panel2;
    [SerializeField] private GameObject panel3;
    [SerializeField] private GameObject panel4;


    private void Awake()
    {
        HideAllPanels();
    }

    public void ShowPanel1()
    {
        ShowPanel(panel1);
        HidePanel(panel2);
        HidePanel(panel3);
        HidePanel(panel4);


    }

    public void ShowPanel2()
    {
        ShowPanel(panel2);
        HidePanel(panel1);
        HidePanel(panel3);
        HidePanel(panel4);
    }

    public void ShowPanel3()
    {
        ShowPanel(panel3);
        HidePanel(panel2);
        HidePanel(panel1);
        HidePanel(panel4);
    }

    public void ShowPanel4()
    {
        ShowPanel(panel4);
        HidePanel(panel2);
        HidePanel(panel3);
        HidePanel(panel1);
    }

    private void ShowPanel(GameObject panelToShow)
    {

        // 显示新的面板
        panelToShow.SetActive(true);
        //currentPanel = panelToShow;
    }

        private void HidePanel(GameObject panelToShow)
    {

        // 显示新的面板
        panelToShow.SetActive(false);
        //currentPanel = panelToShow;
    }

    private void HideAllPanels()
    {
        panel1.SetActive(false);
        panel2.SetActive(false);
        panel3.SetActive(false);
        panel4.SetActive(false);
    }
}
