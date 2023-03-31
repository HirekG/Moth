using UnityEngine;
using UnityEngine.Tilemaps;

public class TilemapLayerFlipper : MonoBehaviour
{
    [SerializeField] private Tilemap[] tilemapsToFlip;

    private bool isFlipped = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            isFlipped = !isFlipped;

            foreach (var tilemap in tilemapsToFlip)
            {
                tilemap.GetComponent<Renderer>().sortingOrder *= -1;
            }
        }
    }
}
