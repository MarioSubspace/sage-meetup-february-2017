using UnityEngine;

public class Alien : MonoBehaviour
{
    public string alienName;

    Snack[] snacks;
    Spaceship spaceship;

    private void OnEnable()
    {
        snacks = GetComponentsInChildren<Snack>();
        spaceship = FindObjectOfType<Spaceship>();

        PrintDebugOutput();
    }

    void PrintDebugOutput()
    {
        foreach (Snack snak in snacks)
        {
            Debug.Log("<color=orange>Alien has snack:</color> <color=cyan>" + snak.name + "</color>");
        }

        Debug.Log("<color=orange>Alien has spaceship:</color> <color=red>" + spaceship.name + "</color>");
    }
}
