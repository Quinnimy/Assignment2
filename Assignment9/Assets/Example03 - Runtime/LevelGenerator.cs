/*
 * Quinn Lamkin
 * Assignment9
 * Move to click, attach to player characterGenerates level for player to navigate
 * added in mesh baker
 */
using UnityEngine;
//added in from vid
using UnityEngine.AI;

public class LevelGenerator : MonoBehaviour {

	public int width = 10;
	public int height = 10;

	public GameObject wall;
	public GameObject player;

	private bool playerSpawned = false;


	//from vid
	//needed so we can mesh after level loads
	public NavMeshSurface surface;

	// Use this for initialization
	void Start () {
		GenerateLevel();
		//from vid, baking the mesh after level generates
		surface.BuildNavMesh();
	}
	
	// Create a grid based level
	void GenerateLevel()
	{
		// Loop over the grid
		for (int x = 0; x <= width; x+=2)
		{
			for (int y = 0; y <= height; y+=2)
			{
				// Should we place a wall?
				if (Random.value > .7f)
				{
					// Spawn a wall
					Vector3 pos = new Vector3(x - width / 2f, 1f, y - height / 2f);
					Instantiate(wall, pos, Quaternion.identity, transform);
				} else if (!playerSpawned) // Should we spawn a player?
				{
					// Spawn the player
					Vector3 pos = new Vector3(x - width / 2f, 1.25f, y - height / 2f);
					Instantiate(player, pos, Quaternion.identity);
					playerSpawned = true;
				}
			}
		}
	}

}
