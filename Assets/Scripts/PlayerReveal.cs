using UnityEngine;

public class PlayerReveal : MonoBehaviour
{
    public GenerateMaze mazeGenerator; // assign your maze
    private Room currentRoom;

    void Update()
    {
        RevealRoomUnderPlayer();
    }

    void RevealRoomUnderPlayer()
    {
        Vector2 pos = transform.position;
        int x = Mathf.FloorToInt(pos.x / mazeGenerator.roomWidth);
        int y = Mathf.FloorToInt(pos.y / mazeGenerator.roomHeight);

        if (x >= 0 && x < mazeGenerator.numX && y >= 0 && y < mazeGenerator.numY)
        {
            Room room = mazeGenerator.rooms[x, y];
            if (room != currentRoom)
            {
                currentRoom = room;
                room.Reveal();

                // Optional: reveal adjacent rooms for small visibility
                foreach (Room.Directions dir in System.Enum.GetValues(typeof(Room.Directions)))
                {
                    int nx = x, ny = y;
                    switch (dir)
                    {
                        case Room.Directions.TOP: ny++; break;
                        case Room.Directions.RIGHT: nx++; break;
                        case Room.Directions.BOTTOM: ny--; break;
                        case Room.Directions.LEFT: nx--; break;
                    }
                    if (nx >= 0 && nx < mazeGenerator.numX && ny >= 0 && ny < mazeGenerator.numY)
                        mazeGenerator.rooms[nx, ny].Reveal();
                }
            }
        }
    }
}