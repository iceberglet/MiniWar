﻿using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {
	private TextureGenerator terrain;

	// Use this for initialization
	void Start () {
		terrain = this.gameObject.GetComponent<TextureGenerator> ();

        ///******** Testing For Sprite Displays ********
        Faction f = new Faction();
        f.initialize("A Faction", Color.black);
        TroopInfo t = this.gameObject.AddComponent<TroopInfo>();
        t.initialize(TroopInfo.TroopType.Lancer, 500, TroopInfo.TroopRank.Normal, f);

        GameObject troopObj = Troop.instantiate(t, new Vector2(0, 0));
        Troop.instantiate(t, new Vector2(1, 0));
        Troop.instantiate(t, new Vector2(1, 1));
        troopObj.GetComponent<Troop>().troop_stat.status = TroopStats.TroopStatus.Rout;
    }
	
	// Update is called once per frame
	void Update () {
        /******* Dynamic Height Detector *******
		//Debug.Log ("Camera Height: " + Camera.main.pixelHeight);
		Ray ray = Camera.main.ScreenPointToRay(new Vector3(Input.mousePosition.x, -Input.mousePosition.y + Camera.main.pixelHeight, 0));
		RaycastHit hit;
		
		//rayhit on any collider other than the ghost ones AND it's a new position
		if(Physics.Raycast (ray, out hit, Mathf.Infinity))
		{
			Vector3 hitPoint = hit.point;
			float height = terrain.getHeight(hitPoint.x, -hitPoint.y);
			//Debug.Log ("Point hit on plane: "+hitPoint.x+", "+hitPoint.y+" which is of height: "+height);
		}*/
	}
}
