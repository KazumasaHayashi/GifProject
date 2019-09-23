using UnityEngine;

public class CameraController : MonoBehaviour
{
    public CameraShake shake;

    private void Update()
    {
        if ( Input.GetKeyDown( KeyCode.Z ) )
        {
            shake.Shake( 0.25f, 0.05f );
        }
    }
}