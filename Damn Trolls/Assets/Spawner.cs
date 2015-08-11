using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public enum SpawnTypes
	{
		Normal,
		Once
	}
	public enum EnemyLevels
	{
		Easy
	}

	public EnemyLevels enemylevels = EnemyLevels.Easy;
	public GameObject Enemies;
	public int totalEnemy = 5;
	private int numEnemy = 0;
	private int spawnedEnemy = 0;
	private int SpawnID;
	public bool Spawn = true;
	public SpawnTypes spawnType = SpawnTypes.Normal;

	void Start()
	{
		SpawnID = Random.Range (1, 500);
	}

	void Update()
	{
		if(Spawn)
		{
			if(spawnType == SpawnTypes.Normal)
			{
				if(numEnemy < totalEnemy)
				{
					spawnEnemy();
				}
			}
			else if (spawnType == SpawnTypes.Once)
			{
				// checks to see if the overall spawned num of enemies is more or equal to the total to be spawned
				if(spawnedEnemy >= totalEnemy)
				{
					//sets the spawner to false
					Spawn = false;
				}
				else
				{
					// spawns an enemy
					spawnEnemy();
				}
			}
		}
	}
	private void spawnEnemy()
	{
		if (enemylevels == EnemyLevels.Easy)
		{
			if(Enemies != null)
			{
				GameObject Enemy = (GameObject) Instantiate(Enemies, gameObject.transform.position, Quaternion.identity);
			}
		}
	}

}
