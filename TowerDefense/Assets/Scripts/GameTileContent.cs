using UnityEngine;

public enum GameTileContentType
{
    Empty,
    Destination,
    Wall,
    SpawnPoint
}

public class GameTileContent : MonoBehaviour
{
    [SerializeField] private GameTileContentType _type;

    public GameTileContentType Type => _type;

    public GameTileContentFactory OriginFactory { get; set; }

    public void Recycle()
    {
        OriginFactory.Reclaim(this);
    }
}
