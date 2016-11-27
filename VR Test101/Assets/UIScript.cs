using UnityEngine;
using UnityEngine.UI;
using UnityEngine.VR;
using System.Collections;

public class UIScript : MonoBehaviour
{
    public float Teleport_movementScale = .003f;

    GameObject Grid;
    GameObject Spot;
    public GameObject Player;
    //public GameObject PlayerCamera;

    public Vector3 Spot_Position;
    Vector3 Spot_defaultPosition;
    Vector3 Player_Position;

    Quaternion HMD_rotation;
    Vector3 HMD_position;

    bool trigger_isinUse = false;

    void Awake()
    {

        Grid = transform.Find("Grid").gameObject;
        Spot = Grid.transform.Find("Spot").gameObject;
        Spot_defaultPosition = Spot.transform.localPosition;

        //Find Player
        //GameObject Player = GameObject.Find("Player");
        //PlayerScript playerscript = Player.GetComponent<PlayerScript>();

    }

    void Update()
    {
        MoveSpot();
    }

    void MoveSpot()
    {
        if ((Input.GetAxisRaw("Teleport_Trigger") > 0))
        {

            float h = Input.GetAxis("Horizontal") * Teleport_movementScale;
            float v = Input.GetAxis("Vertical") * Teleport_movementScale;

            Vector3 position_change = transform.TransformDirection(h, v, 0);

            Spot.transform.position += position_change;

            trigger_isinUse = true;
        }

        if ((Input.GetAxisRaw("Teleport_Trigger") <= 0))
        {
            if (trigger_isinUse == true)
            {
                //Debug.Log("Spot Position Before = " + Spot.transform.localPosition);

                Spot_Position = Spot.transform.localPosition;

                PlayerScript.TeleportActivation(Spot_Position);
                ResetSpot();

                trigger_isinUse = false;
            }
        }
    }
    void ResetSpot()
    {
        Spot.transform.localPosition = Spot_defaultPosition;
    }

    //void TeleportActivation()
    //{

    //    Vector3 Spot_temp = Spot_Position;
    //    Spot_temp.z = Spot_Position.y;
    //    Spot_temp.y = 0;

    //    //Vector3 temp = PlayerCamera.transform.forward;
    //    Vector3 temp = PlayerCamera.transform.TransformDirection(Spot_temp * .1f);

    //    //Debug.Log(PlayerCamera.transform.Translate(Spot_temp));

    //    //Debug.Log("Player Value BE = " + Player.transform.localPosition);
    //    //Debug.Log("Temp Value = " + temp);
    //    Player.transform.Translate(temp);

    //    //Debug.Log(PlayerCamera.transform.forward);

    //    //Debug.Log("Player Value AF = " + Player.transform.localPosition);

    //    //Fix player back to ground level
    //    Player_Position = Player.transform.position;
    //    Player_Position.y = 3.649f;
    //    Player.transform.position = Player_Position;

    //}
    





}