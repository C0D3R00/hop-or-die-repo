using UnityEngine;
using UnityEngine.EventSystems;

public class InputState : MonoBehaviour
{
    public InputNames CurrentInput { get; private set; }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)/* && !EventSystem.current.IsPointerOverGameObject()*/)
        {
            if (Input.mousePosition.x < Screen.width / 2f)
            {
                CurrentInput = InputNames.TAP_LEFT;
            }
            else
            {
                CurrentInput = InputNames.TAP_RIGHT;
            }
        }
        else if (Input.GetMouseButtonUp(0) || Input.GetMouseButton(0))
        {
            CurrentInput = InputNames.NONE;
        }
    }
}
