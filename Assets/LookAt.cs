using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public Transform target; // The target object to look at

    void Update()
    {
        if (target == null)
        {
            Debug.LogWarning("Target is not assigned!");
            return;
        }

        // Make the object look at the target
        transform.LookAt(target);

        // Adjust the camera's field of view based on target's scale
        Camera.main.fieldOfView = Mathf.Clamp(60 * target.localScale.x, 1, 100);
    }
}
