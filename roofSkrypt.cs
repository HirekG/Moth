using UnityEngine;
using UnityEngine.Tilemaps;

public class RoofTilemapSortingOrder : MonoBehaviour
{
    public int sortingOrder = 20;
    public string playerTag = "Player";
    public int defaultSortingOrder = -10;

    private Tilemap roofTilemap;

    private void Start()
    {
        // Find the Tilemap named "Roof" in the scene
        roofTilemap = GameObject.Find("Roof").GetComponent<Tilemap>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(playerTag))
        {
            roofTilemap.GetComponent<Renderer>().sortingOrder = sortingOrder;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag(playerTag))
        {
            roofTilemap.GetComponent<Renderer>().sortingOrder = defaultSortingOrder;
        }
    }
}
