using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostRotateScript : MonoBehaviour
{
    [SerializeField] Direction thisDirection;
    [SerializeField] Transform transformGhost;

    public void Rotate()
    {
        transformGhost.rotation = RotationGhost(thisDirection);
    }

    Quaternion RotationGhost(Direction direction)
    {
        switch (direction)
        {
            case Direction.right:
                return Quaternion.Euler(0, 0, 0);
            case Direction.left:
                return Quaternion.Euler(0, 180, 0);
            case Direction.forward:
                return Quaternion.Euler(0, 90, 0);

            default:
                return new Quaternion(0, 0, 0, transform.rotation.w);
        }
    }

    enum Direction { left, right, forward }
}