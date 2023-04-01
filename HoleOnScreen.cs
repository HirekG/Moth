using UnityEngine;

public class HoleOnScreen : MonoBehaviour
{
    public GameObject otherObject;
    public GoggleSwitch GoggleSwitchScript;

    private void Start()
    {
        GoggleSwitchScript = otherObject.GetComponent<GoggleSwitch>();
    }

    // This variable keeps track of whether the hole has been seen by the player.
    public bool HoleSeen = false;

    // This function is called when the player enters the trigger area.
    private void OnTriggerEnter(Collider other)
    {
        // Check if the player has entered the trigger area.
        if (other.CompareTag("Player") && !GoggleSwitchScript.NormalVision)
        {
            // Set the holeSeen variable to true.
            HoleSeen = true;
        }
    }
}
