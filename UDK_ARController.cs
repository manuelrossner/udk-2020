using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

namespace UnityEngine.XR.Interaction.Toolkit.AR {


    public class UDK_ARController : MonoBehaviour
    {
        public PlaceOnPlane PlaceOnPlane;
        public Material transparentFloor;
        public GameObject groundCube;

        public void Update() {
            if (PlaceOnPlane.spawnedObject != null) {
                Debug.Log(PlaceOnPlane.spawnedObject);
                ChangeGameObjectStatus();
            }
        }

        public void ChangeGameObjectStatus() {

            var placementAnchor = GameObject.Find("AR Placed Cube(Clone)");

            if (groundCube == null) {
                groundCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                groundCube.name = "TransparentFloor";
                groundCube.GetComponent<Renderer>().material = transparentFloor;
                groundCube.transform.localScale = new Vector3(1000,.1f,1000);
            }

            groundCube.transform.position = new Vector3(placementAnchor.transform.position.x, placementAnchor.transform.position.y + 0.05f, placementAnchor.transform.position.z);
            groundCube.transform.parent = placementAnchor.transform;
        }
    }
}