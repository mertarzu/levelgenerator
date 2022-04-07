using UnityEngine;

public class DirtTile : PooledObject,IPassable
{
    bool isTaken;
    bool isPassible = true;
    public override bool IsPooledObjectTaken => isTaken;
    public bool IsPassable => isPassible;

    public override void Dismiss()
    {
        gameObject.SetActive(false);
        isTaken = false;
    }

    public override void SetActive()
    {
        gameObject.SetActive(true);
        isTaken = true;
    }

    public override void Navigate(Vector3 pos)
    {
        transform.position = pos;
        SetActive();
    }
}
