using UnityEngine;

public class GeneratorMenuManager : MonoBehaviour
{
    [SerializeField] private GameObject LandscapeWindow;
    [SerializeField] private GameObject PropsWindow;

    public void ChooseLandscapeWindow()
    {
        LandscapeWindow.SetActive(true);
        PropsWindow.SetActive(false);
    }

    public void ChoosePropsWindow()
    {
        LandscapeWindow.SetActive(false);
        PropsWindow.SetActive(true);
    }
}
