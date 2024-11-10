using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToolsMenuManager : MonoBehaviour
{
    [SerializeField] private Button ImageRedactorButton;
    [SerializeField] private Button ResultButton;
    [SerializeField] private Button ChatButton;
    [SerializeField] private GameObject ChatWindow;
    [SerializeField] private GameObject ImageRedactorWindow;
    [SerializeField] private GameObject ResultWindow;
    
    public void ChooseChat()
    {
        ChatWindow.SetActive(true);
        ImageRedactorWindow.SetActive(false);
        ResultWindow.SetActive(false);
    }
    
    public void ChooseResult()
    {
        ChatWindow.SetActive(false);
        ImageRedactorWindow.SetActive(false);
        ResultWindow.SetActive(true);
    }
    
    public void ChooseImageRedactor()
    {
        ChatWindow.SetActive(false);
        ImageRedactorWindow.SetActive(true);
        ResultWindow.SetActive(false);
    }
    
}
