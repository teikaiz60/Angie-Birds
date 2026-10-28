using UnityEngine;
using UnityEngine.InputSystem;

public class SlingShotArea : MonoBehaviour
{

    [SerializeField]private LayerMask _slingshotAreMask;
    public bool IsWithinSlingshotArea()
    {
        Vector2 worldPosition = Camera.main.ScreenToWorldPoint(InputManager.MousePosition);
        if (Physics2D.OverlapPoint(worldPosition, _slingshotAreMask))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
