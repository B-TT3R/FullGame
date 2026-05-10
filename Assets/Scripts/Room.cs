using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{
    public enum Directions
    {
        TOP,
        RIGHT,
        BOTTOM,
        LEFT,
        NONE,
    }

    [Header("Wall GameObjects (assign in inspector)")]
    [SerializeField] private GameObject topWall;
    [SerializeField] private GameObject rightWall;
    [SerializeField] private GameObject bottomWall;
    [SerializeField] private GameObject leftWall;

    private Dictionary<Directions, GameObject> walls =
        new Dictionary<Directions, GameObject>();

    [Header("Fog Overlay (optional)")]
    [SerializeField] private GameObject fogOverlay;

    // Flags for wall existence
    private Dictionary<Directions, bool> dirflags =
        new Dictionary<Directions, bool>();

    public Vector2Int Index { get; set; }
    public bool visited { get; set; } = false;

    private void Awake()
    {
        // Initialize walls dictionary
        walls[Directions.TOP] = topWall;
        walls[Directions.RIGHT] = rightWall;
        walls[Directions.BOTTOM] = bottomWall;
        walls[Directions.LEFT] = leftWall;

        // Initialize all walls as present
        foreach (var dir in walls.Keys)
        {
            if (walls[dir] != null)
            {
                dirflags[dir] = true;
                walls[dir].SetActive(true);
            }
        }
    }

    /// <summary>
    /// Sets the wall GameObject active or inactive and updates the flag
    /// </summary>
    public void SetDirFlag(Directions dir, bool exists)
    {
        dirflags[dir] = exists;

        if (walls.ContainsKey(dir) && walls[dir] != null)
        {
            walls[dir].SetActive(exists);
        }
    }

    /// <summary>
    /// Reveal this room (for fog-of-war)
    /// </summary>
    public void Reveal()
    {
        if (fogOverlay != null)
        {
            fogOverlay.SetActive(false);
        }
    }

    /// <summary>
    /// Reveal neighboring rooms within a radius
    /// </summary>
    public void RevealNeighbors()
    {
        Collider2D[] hits = Physics2D.OverlapCircleAll(transform.position, 15f);
        foreach (Collider2D hit in hits)
        {
            Room room = hit.GetComponent<Room>();
            if (room != null)
            {
                room.Reveal();
            }
        }
    }
}