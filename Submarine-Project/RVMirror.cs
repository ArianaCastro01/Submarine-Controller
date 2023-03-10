using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RVMirror : MonoBehaviour {

    public Transform player;

    private void LateUpdate()
    {
        Vector3 newPosition = player.position;
        newPosition.x = transform.position.x;
        transform.position = newPosition;

        // transform.rotation = Quaternion.Euler(90f, player.eulerAngles.x, 0f);
    }
}
