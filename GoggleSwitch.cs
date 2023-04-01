using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GoggleSwitch : MonoBehaviour
{
    [SerializeField] private Tilemap[] tilemapsToFlip;

    public GameObject otherObject;
    public ItemInteraction ItemInteractionScript;


    private bool isFlipped = false;
    public bool ItemGot = false;

    private void Start()
    {
        ItemInteractionScript = otherObject.GetComponent<ItemInteraction>();
    }
    private void Update()
    {
        
        ItemGot = ItemInteractionScript.ItemGot;
        if (Input.GetKeyDown(KeyCode.G) && ItemGot)
        {
            isFlipped = !isFlipped;

            foreach (var tilemap in tilemapsToFlip)
            {
                tilemap.GetComponent<Renderer>().sortingOrder *= -1;
            }
        }
    }
}

internal class OtherScript
{
    public bool ItemGot { get; internal set; }
}