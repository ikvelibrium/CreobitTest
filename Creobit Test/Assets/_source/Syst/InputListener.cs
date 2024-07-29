using UnityEngine;
using UnityEngine.InputSystem;


public class InputListener : MonoBehaviour
{

    [SerializeField] private LayerMask _button;
    [SerializeField] private Camera _camera;
    [SerializeField] Score _score;
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            Ray ray = _camera.ScreenPointToRay(Mouse.current.position.ReadValue());

            if (Physics.Raycast(ray: ray, hitInfo: out RaycastHit hit) && hit.collider)
            {

                if (LayerChecker.CheckLayersEquality(hit.collider.gameObject.layer, _button))
                {
                    _score.AddPoints();
                }
            }
        }
    }
}
