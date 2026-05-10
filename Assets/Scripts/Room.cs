using System;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{

    public enum Directions
    {
        Up,
        Down,
        Left,
        Right
    }
    [SerializeField]
    GameObject topWall;
    [SerializeField]
    GameObject rightWall;
    [SerializeField]
    GameObject leftWall;
    [SerializeField]
    GameObject bottomWall;
    
    Dictionary<Directions, GameObject> walls= 
        new Dictionary<Directions, GameObject>();

    public Vector2Int Index
    {
        get;
        set;
    }

    public bool visited { get; set; } = false;
    
    Dictionary<Directions, bool> dirflags =
        new Dictionary<Directions, bool>();

    private void Start()
    {
        walls[Directions.Up]=topWall;
        walls[Directions.Down]=bottomWall;
        walls[Directions.Left]=leftWall;
        walls[Directions.Right]=rightWall;
    }
    private void SetActive(Directions dir, bool flag)
    {
      walls[dir].SetActive(flag);
    }

    public void SetDirFlag(Directions dir, bool flag)
    {
        dirflags[dir] = flag;
        SetActive(dir, flag);
    }
}