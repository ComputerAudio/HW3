using UnityEngine;
using System.Collections;

public class FirstPersonWalkMechanics : WalkMechanics {
    public Transform cameraFollow;

    protected override Vector3 getWalkVector()
    {
        Vector3 fDirection = new Vector3(cameraFollow.forward.x, 0, cameraFollow.forward.z).normalized;
        Vector3 hDirection = new Vector3(fDirection.z, 0, -fDirection.x);
        return (fDirection * getVInput() + hDirection * getHInput()).normalized;


    }

}
