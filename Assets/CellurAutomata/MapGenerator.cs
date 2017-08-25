using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{

	public int width;
	public int height;

	public string seed;
	public bool useRandomSeed;

	[Range (0, 100)]
	public int randomFillPercent;

	int[,] map;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	void GenerateMap ()
	{
		map = new int[width, height];
		RandomFillMap ();
	}

	void RandomFillMap ()
	{
		if (useRandomSeed) {
			seed = Time.time.ToString ();
		}
	}
}
