using UnityEngine;

public interface ITTTCell
{
    public abstract void Interaction();
    public GameObject PlaceForFigure { get; set; }
}