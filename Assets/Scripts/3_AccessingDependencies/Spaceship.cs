using UnityEngine;

public class Spaceship : MonoBehaviour
{
    public Alien alienPilot;

    private void OnEnable()
    {
        Debug.Log("<color=orange>Spaceship is piloted by:</color> <color=white>" + alienPilot.alienName + "</color>");
    }
}
