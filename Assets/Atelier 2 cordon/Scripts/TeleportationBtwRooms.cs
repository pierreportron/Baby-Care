using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportationBtwRooms : MonoBehaviour
{
    public Transform TPbedroom;
    public Transform TPbathroom;
    public Transform player;


    public void GoToBedroom()
    {
        player.position = TPbedroom.position;
    }

    public void GoToBathroom()
    {
        player.position = TPbathroom.position;
    }
}
