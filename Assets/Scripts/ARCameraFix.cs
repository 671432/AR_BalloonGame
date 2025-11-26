using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ARCameraFix : MonoBehaviour
{
    ARCameraBackground bg;
    ARCameraManager camManager;

    void Start()
    {
        bg = GetComponent<ARCameraBackground>();
        camManager = GetComponent<ARCameraManager>();

        // Force refresh AR background
        StartCoroutine(ResetARCamera());
    }

    System.Collections.IEnumerator ResetARCamera()
    {
        yield return null;

        if (bg != null)
        {
            bg.enabled = false;
            yield return null;
            bg.enabled = true;
        }

        if (camManager != null)
        {
            camManager.enabled = false;
            yield return null;
            camManager.enabled = true;
        }
    }
}
