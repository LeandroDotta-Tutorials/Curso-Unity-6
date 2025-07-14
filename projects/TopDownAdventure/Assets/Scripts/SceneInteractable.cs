using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneInteractable : MonoBehaviour, IInteractable
{
    [SerializeField] private string sceneToLoad;
    [SerializeField] private GameObject hintPanel;

    public void Interact()
    {
        SceneManager.LoadScene(sceneToLoad);
    }

    public void OnFocusStart()
    {
        if (hintPanel != null) hintPanel.SetActive(true);
    }

    public void OnFocusEnd()
    {
        if (hintPanel != null) hintPanel.SetActive(false);
    }
}
