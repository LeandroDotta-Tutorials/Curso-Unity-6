using UnityEngine;
using UnityEngine.InputSystem;

public class LevelSelection : MonoBehaviour
{
    private SceneLoader sceneLoader;
    private LevelSelectionPoint selectedPoint;
    private PlayerInput input;
    private InputAction actionInteract;

    private void Start()
    {
        sceneLoader = FindFirstObjectByType<SceneLoader>();
        input = FindFirstObjectByType<PlayerInput>();
        actionInteract = input.actions.FindAction("Interact");

        actionInteract.performed += Interact;
        LevelSelectionPoint.OnPointSelected += PointSelected;
        LevelSelectionPoint.OnPointDeselected += PointDeselected;
    }

    private void OnDestroy()
    {
        actionInteract.performed -= Interact;
        LevelSelectionPoint.OnPointSelected -= PointSelected;
        LevelSelectionPoint.OnPointDeselected -= PointDeselected;
    }
    
    private void Interact(InputAction.CallbackContext context)
    {
        if (!selectedPoint) return;

        string sceneName = $"{SceneNames.LEVEL_PREFIX}{selectedPoint.level}";
        sceneLoader.Load(sceneName);
    }

    private void PointSelected(LevelSelectionPoint point)
    {
        selectedPoint = point;
    }

    private void PointDeselected(LevelSelectionPoint point)
    {
        selectedPoint = null;
    }
    

}
