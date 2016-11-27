using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

    public GameObject PlayerCamera;
    Vector3 Player_Position;
    //public Vector3 Spot_Position;

    // Use this for initialization
    void Start () {
        //GameObject Player = GameObject.Find("Player");
        //PlayerScript playerscript = Player.GetComponent<PlayerScript>();

        //Fine Spot
        //GameObject Teleport_UI = GameObject.Find("Teleport_UI");
        //UIScript theUIscript = Teleport_UI.GetComponent<UIScript>();
        //Debug.Log(theUIscript);

    }

	// Update is called once per frame
	void Update () {
	
	}


    void TeleportActivation()
    {
        
        //Vector3 Spot_temp = theUIscript.Spot_Position;
        //Spot_temp.z = UIScript.Spot_Position.y;
        //Spot_temp.y = 0;

        //Vector3 temp = PlayerCamera.transform.forward;
        //Vector3 temp = PlayerCamera.transform.TransformDirection(Spot_temp * .1f);

        //transform.Translate(temp);

        //Fix player back to ground level
        Player_Position = transform.position;
        Player_Position.y = 3.649f;
        transform.position = Player_Position;

    }
}
