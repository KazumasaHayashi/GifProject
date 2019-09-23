// using UnityEngine;
// using System.Collections;

// public class CameraController : MonoBehaviour {
//     private float timeleft;
//     public CameraShake shake;

//     void Update () {
//         //だいたい1秒ごとに処理を行う
//         timeleft -= Time.deltaTime;
//         if (timeleft <= 0.0) {
//             timeleft = 0.0f;

//             shake.Shake(0.25f, 0.05f);
//         }
//     }
// }

using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
    public CameraShake shake;
    [SerializeField]
    private float distance;
    private float timeFrame;

    private void Update()
    {
        timeFrame += Time.deltaTime;
        if ( timeFrame >= distance )
        {
            shake.Shake( 0.25f, 0.05f );
        }

        // if ( Input.GetKeyDown( KeyCode.Z ) )
        // {
        //     shake.Shake( 0.25f, 0.05f );
        // }
    }
}