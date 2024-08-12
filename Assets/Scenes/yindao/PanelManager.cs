using UnityEngine;

public class PanelManager : MonoBehaviour
{
    
    public void OpenPanel(GameObject Panel)
    {
        if (Panel != null)
        {
            bool isActive = Panel.activeSelf;

            Panel.SetActive(!isActive);
        }
    }
}