using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Compass : MonoBehaviour
{
    public Vector3 NorthDirection;
    public Transform player;
    public Quaternion MissionDirection;

    public RectTransform Northlayer;
    public RectTransform Missionlayer;

    public Transform missionplace;

    void Update()
    {
        ChangeNorthDirection();
        ChangeMissionDirection();
    }
    public void ChangeNorthDirection()
    {
        NorthDirection.z = player.eulerAngles.y;
        Northlayer.localEulerAngles = NorthDirection;
    }

    public void ChangeMissionDirection()
    {
        Vector3 dir = transform.position - missionplace.position;

        MissionDirection = Quaternion.LookRotation(dir);

        MissionDirection.z = -MissionDirection.y;
        MissionDirection.x = 0;
        MissionDirection.y = 0;

        Missionlayer.localRotation = MissionDirection * Quaternion.Euler(NorthDirection);
    }
}
